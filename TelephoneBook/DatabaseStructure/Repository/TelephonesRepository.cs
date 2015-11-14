using System;
using TelephoneBook.TelephonesLib;

namespace TelephoneBook.DatabaseStructure.Repository
{
    public class TelephonesRepository : Repository<Telephone>, ITelephonesRepository
    {
        public override bool Edit(Telephone val)
        {
            using (Context = new Phones())
            {
                Telephone telephone = Context.Telephones.Find(val.Id);
                if (telephone == null)
                {
                    throw new ArgumentNullException("value", "Can't find telephone with such id");
                }
                val.CopyTo(telephone);
                Context.SaveChanges();
                return true;
            }
        }
    }
}