using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Mapping
{
    public class İmageItemMap : IEntityTypeConfiguration<İmageItem>
    {
        public void Configure(EntityTypeBuilder<İmageItem> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Title)
                .HasMaxLength(50)
                .HasColumnType("Varchar")
                .IsRequired();

            builder.Property(x => x.Explanation)
                .HasMaxLength(200)
            .HasColumnType("Varchar");

            builder.ToTable("ImageItems");

            builder.Property(x => x.Id).HasColumnName("ID");
            builder.Property(x => x.Title).HasColumnName("Title");
            builder.Property(x => x.Explanation).HasColumnName("Explanation");
        }
    }
}
