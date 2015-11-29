using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using TelephoneBook.TelephonesLib;

namespace TelephoneBook.Models.Mapping
{
    public class TelephoneMap : EntityTypeConfiguration<Telephone>
    {
        public TelephoneMap()
        {
            // Primary Key
            HasKey(t => t.Id);

            // Properties
            Property(t => t.Number)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            ToTable("Telephone");
            Property(t => t.Id).HasColumnName("Id");
            Property(t => t.PersonId).HasColumnName("PersonId");
            Property(t => t.Description).HasColumnName("Description");
            Property(t => t.Number).HasColumnName("Number");
        }
    }
}
