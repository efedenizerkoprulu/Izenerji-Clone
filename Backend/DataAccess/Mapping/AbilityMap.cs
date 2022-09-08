using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Mapping
{
    public class AbilityMap : IEntityTypeConfiguration<Ability>
    {
        public void Configure(EntityTypeBuilder<Ability> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Name)
                .HasMaxLength(40)
                .HasColumnType("Varchar")
                .IsRequired();

            builder.ToTable("Abilities");

            builder.Property(x => x.Id).HasColumnName("ID");
            builder.Property(x => x.SuccsessPercentage).HasColumnName("SuccsessPercentage");
            builder.Property(x=> x.Name).HasColumnName("Name");
        }

      
    }
}
