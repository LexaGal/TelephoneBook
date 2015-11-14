using System.Data.Entity;
using TelephoneBook.TelephonesLib;

namespace TelephoneBook.DatabaseStructure
{
    public class Phones : DbContext
    {
        public DbSet<Person> Persons { get; set; }
        public DbSet<Telephone> Telephones { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Person>().ToTable("Person");
            modelBuilder.Entity<Telephone>().ToTable("Telephone");
        }
    }
}