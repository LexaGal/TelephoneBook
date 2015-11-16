using System.Data.Entity;
using TelephoneBook.TelephonesLib;

namespace TelephoneBook.DatabaseStructure
{
    public class Phones : DbContext
    {
        public virtual DbSet<Person> Persons { get; set; }
        public virtual DbSet<Telephone> Telephones { get; set; }

        public Phones()
        {
            Configuration.LazyLoadingEnabled = true;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Person>().ToTable("Person");
            modelBuilder.Entity<Telephone>().ToTable("Telephone");
        }
    }
}