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
    public class Address : INotifyPropertyChanged
    {
        private string _city;
        private string _street;
        private int _house;
        private int? _flat;

        public Address(Person person)
        {
            Person = person;
        }

        public Address()
        {
        }

        public Address(Guid personId, string city, string street, int house, int? flat, Person person)
        {
            _city = city;
            _street = street;
            _house = house;
            _flat = flat;
            PersonId = personId;
            Person = person;
        }
        
        public string City
        {
            get { return _city; }
            set
            {
                if (value == _city) return;
                _city = value;
                OnPropertyChanged();
            }
        }

        public string Street
        {
            get { return _street; }
            set
            {
                if (value == _street) return;
                _street = value;
                OnPropertyChanged();
            }
        }

        public int House
        {
            get { return _house; }
            set
            {
                if (value == _house) return;
                _house = value;
                OnPropertyChanged();
            }
        }

        public int? Flat
        {
            get { return _flat; }
            set
            {
                if (value == _flat) return;
                _flat = value;
                OnPropertyChanged();
            }
        }

        public Guid PersonId { get; private set; }
        
        public virtual Person Person { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
