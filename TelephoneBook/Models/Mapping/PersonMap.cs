using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using TelephoneBook.TelephonesLib;

namespace TelephoneBook.Models.Mapping
{
    public class PersonMap : EntityTypeConfiguration<Person>
    {
        public PersonMap()
        {
            // Primary Key
            HasKey(t => t.Id);

            // Properties
            Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            Property(t => t.Surname)
                .IsRequired()
                .HasMaxLength(50);

            Property(t => t.Patronymic)
                .HasMaxLength(50);

            // Table & Column Mappings
            ToTable("Person");
            Property(t => t.Id).HasColumnName("Id");
            Property(t => t.Name).HasColumnName("Name");
            Property(t => t.Surname).HasColumnName("Surname");
            Property(t => t.Patronymic).HasColumnName("Patronymic");


        }
    }
}
