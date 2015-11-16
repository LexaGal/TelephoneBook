using System;
using TelephoneBook.TelephonesLib;

namespace TelephoneBook.DatabaseStructure.Repository
{
    public class PersonsRepository : Repository<Person>, IPersonsRepository
    {
        public PersonsRepository(Phones phones)
        {
            Context = phones;
        }

        public override bool Edit(Person val)
        {
            //using (Context = new Phones())
            //{
                Person person = Context.Persons.Find(val.Id);
                if (person == null)
                {
                    throw new ArgumentNullException("value", "Can't find person with such id");
                }
                val.CopyTo(person);
                Context.SaveChanges();
                return true;
            //}
        }
    }
}