using System;
using TelephoneBook.DatabaseStructure.DbContext;
using TelephoneBook.TelephonesLib;

namespace TelephoneBook.DatabaseStructure.Repository
{
    public class PersonsRepository : Repository<Person>, IPersonsRepository
    {
        public PersonsRepository(Phones phones) : base(phones)
        {
            Context = phones;
        }

        public override bool Edit(Person val)
        {
            Person person = Context.Persons.Find(val.Id);
            if (person == null)
            {
                throw new ArgumentNullException("value", "Can't find person with such id");
            }
            val.CopyTo(person);
            return true;
        }
    }
}