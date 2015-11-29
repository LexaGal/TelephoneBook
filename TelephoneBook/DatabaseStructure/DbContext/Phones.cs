using System.Data.Entity;
using TelephoneBook.Models.Mapping;
using TelephoneBook.TelephonesLib;

namespace TelephoneBook.DatabaseStructure.DbContext
{
    public class Phones : System.Data.Entity.DbContext
    {
        public DbSet<Person> Persons { get; set; }
        public DbSet<Telephone> Telephones { get; set; }
        public DbSet<Address> Addresses { get; set; }

        public Phones() : base("Name=Phones")
        {
            Configuration.LazyLoadingEnabled = true;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new AddressMap());
            modelBuilder.Configurations.Add(new PersonMap());
            modelBuilder.Configurations.Add(new TelephoneMap());
        }
    }
}