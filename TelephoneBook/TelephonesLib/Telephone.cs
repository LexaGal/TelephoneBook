using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace TelephoneBook.TelephonesLib
{
    public class Telephone
    {
        public Telephone()
        {
            Id = Guid.NewGuid();
        }

        public Telephone(Guid id, Guid personId, string description, string number, Person person)
        {
            Id = id;
            PersonId = personId;
            Description = description;
            Number = number;
            Person = person;
        }

        [Key]
        [Browsable(false)]
        public Guid Id { get; private set; }

        [Browsable(false)]
        public Guid PersonId { get; set; }

        public string Description { get; set; }
        public string Number { get; set; }

        [Browsable(false)]
        public virtual Person Person { get; set; }

        public void CopyTo(Telephone telephone)
        {
            telephone.Id = Id;
            telephone.PersonId = PersonId;
            telephone.Description = Description;
            telephone.Number = Number;
            telephone.Person = Person;
        }

        public override string ToString()
        {
            return String.Format("{0}: {1}", Description, Number);
        }
    }
}