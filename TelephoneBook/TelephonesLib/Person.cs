using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.CompilerServices;
using TelephoneBook.Annotations;

namespace TelephoneBook.TelephonesLib
{
    public class Person : INotifyPropertyChanged
    {
        private string _name;
        private string _surname;
        private string _patronymic;

        [Key]
        public Guid Id { get; private set; }

        public string Name
        {
            get { return _name; }
            set
            {
                if (value == _name) return;
                _name = value;
                OnPropertyChanged();
            }
        }

        public string Surname
        {
            get { return _surname; }
            set
            {
                if (value == _surname) return;
                _surname = value;
                OnPropertyChanged();
            }
        }

        public string Patronymic
        {
            get { return _patronymic; }
            set
            {
                if (value == _patronymic) return;
                _patronymic = value;
                OnPropertyChanged();
            }
        }

        [NotMapped]
        public List<Telephone> Telephones { get; private set; }

        public Person(Guid id, string name, string surname, string patronymic, List<Telephone> telephones)
        {
            Id = id;
            Name = name;
            Surname = surname;
            Patronymic = patronymic;
            Telephones = telephones ?? new List<Telephone>();
        }

        public Person()
        {
            Telephones = new List<Telephone>();
        }

        public void AddTelephone(Telephone telephone)
        {
            if (Telephones == null)
            {
                Telephones = new List<Telephone>();
            }

            if (telephone.PersonId == Guid.Empty)
            {
                telephone.PersonId = Id;
            }

            Telephone oldTelephone = Telephones.SingleOrDefault(tele => tele.Id == telephone.Id);
            if (oldTelephone != null)
            {
                telephone.CopyTo(oldTelephone);
                return;
            }
            
            Telephones.Add(telephone);
        }

        public void CopyTo(Person person)
        {
            person.Id = Id;
            person.Name = Name;
            person.Surname = Surname;
            person.Patronymic = Patronymic;
        }

        public override string ToString()
        {
            return String.Format("{0} {1} {2}", Name, Surname, Patronymic);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}