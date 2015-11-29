using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using TelephoneBook.TelephonesLib;

namespace TelephoneBook.Models.Mapping
{
    public class AddressMap : EntityTypeConfiguration<Address>
    {
        public AddressMap()
        {
            // Properties
            Property(t => t.City)
                .IsRequired()
                .HasMaxLength(50);

            Property(t => t.Street)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            ToTable("Address");
            Property(t => t.City).HasColumnName("City");
            Property(t => t.Street).HasColumnName("Street");
            Property(t => t.House).HasColumnName("House");
            Property(t => t.Flat).HasColumnName("Flat");
            Property(t => t.PersonId).HasColumnName("PersonId");

            HasKey(a => a.PersonId)
                .HasRequired(a => a.Person)
                .WithRequiredDependent(a => a.Address);
        }
    }
}
