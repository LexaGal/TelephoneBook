using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using TelephoneBook.DatabaseStructure;
using TelephoneBook.DatabaseStructure.DbContext;
using TelephoneBook.DatabaseStructure.Repository;
using TelephoneBook.DatabaseStructure.UnitOfWork;
using TelephoneBook.TelephonesLib;

namespace TelephoneBook
{
    public partial class TelephonesForm : Form
    {
        private BindingList<Person> _persons;
        private readonly PhonesUnitOfWork _phonesUnitOfWork;

        public TelephonesForm()
        {
            InitializeComponent();

            _phonesUnitOfWork = new PhonesUnitOfWork();

            CreatePersonsWithTelephonesList();

            SetBindingForTelephonesDataGridView();

            BindingSource bindingSource = new BindingSource {DataSource = _persons};
            PersonsListBox.DataSource = bindingSource;
        }

        private void CreatePersonsWithTelephonesList()
        {
            _persons = new BindingList<Person>(_phonesUnitOfWork.Repository<Person>().GetAll())
            {
                AllowEdit = true,
                AllowNew = true,
                AllowRemove = true
            };
        }


        private void SetBindingForTelephonesDataGridView()
        {
            TelephonesDataGridView.DataSource = new BindingList<Telephone>(_persons.First().Telephones)
            {
                AllowEdit = true,
                AllowNew = true,
                AllowRemove = true
            };
        }

        private void PersonsListBoxSelectedIndexChanged(object sender, EventArgs e)
        {
            Person person = PersonsListBox.SelectedItem as Person;
            if (person != null)
            {
                if (person.Telephones != null)
                {
                    TelephonesDataGridView.DataSource = new BindingList<Telephone>(person.Telephones);
                }
                ResetTbsBindings(person);
            }
        }

        private void ResetTbsBindings(Person person)
        {
            NameTb.DataBindings.Clear();
            SurnameTb.DataBindings.Clear();
            PatronymicTb.DataBindings.Clear();
            CityTb.DataBindings.Clear();
            StreetTb.DataBindings.Clear();
            HouseTb.DataBindings.Clear();
            FlatTb.DataBindings.Clear();

            NameTb.DataBindings.Add("Text", person, "Name", false, DataSourceUpdateMode.Never);
            SurnameTb.DataBindings.Add("Text", person, "Surname", false, DataSourceUpdateMode.Never);
            PatronymicTb.DataBindings.Add("Text", person, "Patronymic", false, DataSourceUpdateMode.Never);
            CityTb.DataBindings.Add("Text", person.Address, "City", false, DataSourceUpdateMode.Never);
            StreetTb.DataBindings.Add("Text", person.Address, "Street", false, DataSourceUpdateMode.Never);
            HouseTb.DataBindings.Add("Text", person.Address, "House", false, DataSourceUpdateMode.Never);
            FlatTb.DataBindings.Add("Text", person.Address, "Flat", false, DataSourceUpdateMode.Never);
        }

        private void AddNewPersonButtonClick(object sender, EventArgs e)
        {
            string name = NameTb.Text;
            string surname = SurnameTb.Text;
            string patronymic = PatronymicTb.Text;
            string c = CityTb.Text;
            string s = StreetTb.Text;
            string h = HouseTb.Text;
            string f = FlatTb.Text;

            Person person = new Person(Guid.NewGuid(), name, surname, patronymic, new List<Telephone>(), null);
            Address address = new Address(person.Id, c, s, Convert.ToInt32(h), f.ToNullableInt32(), person);
            person.Address = address;
            
            _persons.Add(person);

            _phonesUnitOfWork.Repository<Address>().Save(address, address.PersonId);
            _phonesUnitOfWork.SaveChanges();
            _phonesUnitOfWork.Repository<Person>().Save(person, person.Id);
            _phonesUnitOfWork.SaveChanges();
        }

        private void SavePersonButtonClick(object sender, EventArgs e)
        {
            string name = NameTb.Text;
            string surname = SurnameTb.Text;
            string patronymic = PatronymicTb.Text;

            Person person = PersonsListBox.SelectedItem as Person;
            if (person != null)
            {
                person.Name = name;
                person.Surname = surname;
                person.Patronymic = patronymic;
                _phonesUnitOfWork.Repository<Person>().Save(person, person.Id);
                _phonesUnitOfWork.SaveChanges();
            }
        }

        private void RemovePersonButtonClick(object sender, EventArgs e)
        {
            Person person = PersonsListBox.SelectedItem as Person;
            if (person != null)
            {
                _phonesUnitOfWork.Repository<Person>().Delete(person.Id);
                _phonesUnitOfWork.SaveChanges();
                _persons.Remove(person);
            }
        }

        private List<Telephone> DataGridViewRowsToTelephones()
        {
            List<Telephone> telephones = new List<Telephone>();

            for (int i = 0; i < TelephonesDataGridView.SelectedRows.Count; i++)
            {
                DataGridViewRow selectedRow = TelephonesDataGridView.SelectedRows[i];
                if (selectedRow.DataBoundItem != null)
                {
                    telephones.Add(selectedRow.DataBoundItem as Telephone);
                }
            }
            return telephones;
        }

        private void SaveTelephonesButtonClick(object sender, EventArgs e)
        {
            List<Telephone> telephones = DataGridViewRowsToTelephones();
            Person person = PersonsListBox.SelectedItem as Person;

            if (person != null)
            {
                foreach (var telephone in DataGridViewRowsToTelephones())
                {
                    if (telephone.Person != null)
                    {
                        _phonesUnitOfWork.Repository<Telephone>().Save(telephone, telephone.Id);
                        person.AddTelephone(telephone);
                    }
                }
                _phonesUnitOfWork.SaveChanges();
                MessageBox.Show($"{telephones.Count} telephone(s) saved\n");
            }
        }

        private void RemoveTelephonesButtonClick(object sender, EventArgs e)
        {
            List<Telephone> telephones = DataGridViewRowsToTelephones();
            Person person = PersonsListBox.SelectedItem as Person;

            if (person != null)
            {
                telephones.ForEach(telephone =>
                {
                    if (!(telephone.PersonId == Guid.Empty))
                    {
                        {
                            person.Telephones.Remove(telephone);
                            _phonesUnitOfWork.Repository<Telephone>().Delete(telephone.Id);
                        }
                    }
                });
                _phonesUnitOfWork.SaveChanges();
                MessageBox.Show(
                    $"{telephones.Count(telephone => telephone.PersonId != Guid.Empty)} telephone(s) deleted\n");

                // !!!
                TelephonesDataGridView.DataSource = new BindingList<Telephone>(person.Telephones);
            }
        }

        private void TelephonesForm_Load(object sender, EventArgs e)
        {
        }

        private void SaveAddressButtonClick(object sender, EventArgs e)
        {
            Person person = PersonsListBox.SelectedItem as Person;
            string c = CityTb.Text;
            string s = StreetTb.Text;
            string h = HouseTb.Text;
            string f = FlatTb.Text;

            if (person != null)
            {
                person.Address.City = c;
                person.Address.Street = s;
                person.Address.House = Convert.ToInt32(h);
                person.Address.Flat = f.ToNullableInt32();
                _phonesUnitOfWork.Repository<Address>().Save(person.Address, person.Id);
                _phonesUnitOfWork.SaveChanges();
            }
        }
    }
}
