using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TelephoneBook.DatabaseStructure;
using TelephoneBook.DatabaseStructure.Repository;
using TelephoneBook.TelephonesLib;

namespace TelephoneBook
{
    public partial class TelephonesForm : Form
    {
        private BindingList<Person> _persons;
        private readonly ITelephonesRepository _telephonesRepository;
        private readonly IPersonsRepository _personsRepository;

        public TelephonesForm()
        {
            InitializeComponent();

            Phones phones = new Phones();
            _personsRepository = new PersonsRepository(phones);
            _telephonesRepository = new TelephonesRepository(phones);

            CreatePersonsWithTelephonesList();

            SetBindingForTelephonesDataGridView();

            BindingSource bindingSource = new BindingSource { DataSource = _persons };
            PersonsComboBox.DataSource = bindingSource;
        }

        private void CreatePersonsWithTelephonesList()
        {
            _persons = new BindingList<Person>(_personsRepository.GetAll())
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

        private void PersonsComboBoxSelectedIndexChanged(object sender, EventArgs e)
        {
            Person person = PersonsComboBox.SelectedItem as Person;
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

            NameTb.DataBindings.Add("Text", person, "Name", false, DataSourceUpdateMode.Never);
            SurnameTb.DataBindings.Add("Text", person, "Surname", false, DataSourceUpdateMode.Never);
            PatronymicTb.DataBindings.Add("Text", person, "Patronymic", false, DataSourceUpdateMode.Never);
        }

        private void AddNewPersonButtonClick(object sender, EventArgs e)
        {
            string name = NameTb.Text;
            string surname = SurnameTb.Text;
            string patronymic = PatronymicTb.Text;

            Person person = new Person(Guid.NewGuid(), name, surname, patronymic, new List<Telephone>());
            _persons.Add(person);

            _personsRepository.Save(person, person.Id);
        }

        private void SavePersonButtonClick(object sender, EventArgs e)
        {
            string name = NameTb.Text;
            string surname = SurnameTb.Text;
            string patronymic = PatronymicTb.Text;

            Person person = PersonsComboBox.SelectedItem as Person;
            if (person != null)
            {
                person.Name = name;
                person.Surname = surname;
                person.Patronymic = patronymic;
                _personsRepository.Save(person, person.Id);
            }
        }

        private void RemovePersonButtonClick(object sender, EventArgs e)
        {
            Person person = PersonsComboBox.SelectedItem as Person;
            if (person != null)
            {
                _personsRepository.Delete(person.Id);
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
            Person person = PersonsComboBox.SelectedItem as Person;

            if (person != null)
            {
                DataGridViewRowsToTelephones().ForEach(telephone =>
                {
                    person.AddTelephone(telephone);
                    _telephonesRepository.Save(telephone, telephone.Id);
                });
                MessageBox.Show(string.Format("{0} telephone(s) saved\n", telephones.Count));
            }
        }

        private void RemoveTelephonesButtonClick(object sender, EventArgs e)
        {
            List<Telephone> telephones = DataGridViewRowsToTelephones();
            Person person = PersonsComboBox.SelectedItem as Person;

            if (person != null)
            {
                telephones.ForEach(telephone =>
                {
                    if (!(telephone.PersonId == Guid.Empty))
                    {
                        {
                            person.Telephones.Remove(telephone);
                            _telephonesRepository.Delete(telephone.Id);
                        }
                    }
                });
                MessageBox.Show(string.Format("{0} telephone(s) deleted\n",
                    telephones.Count(telephone => telephone.PersonId != Guid.Empty)));

                // !!!
                TelephonesDataGridView.DataSource = new BindingList<Telephone>(person.Telephones);
            }
        }
        
    }
}
