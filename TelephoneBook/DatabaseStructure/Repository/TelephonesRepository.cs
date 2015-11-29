using System;
using TelephoneBook.DatabaseStructure.DbContext;
using TelephoneBook.TelephonesLib;

namespace TelephoneBook.DatabaseStructure.Repository
{
    public class TelephonesRepository : Repository<Telephone>, ITelephonesRepository
    {
        public TelephonesRepository(Phones phones) : base(phones)
        {
            Context = phones;
        }

        public override bool Edit(Telephone val)
        {
            Telephone telephone = Context.Telephones.Find(val.Id);
            if (telephone == null)
            {
                throw new ArgumentNullException("value", "Can't find telephone with such id");
            }
            val.CopyTo(telephone);
            return true;
        }
    }
}