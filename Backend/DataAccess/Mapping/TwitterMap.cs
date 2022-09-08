using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Mapping
{
    internal class TwitterMap : IEntityTypeConfiguration<Twitter>
    {
        public void Configure(EntityTypeBuilder<Twitter> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Tweet)
                .HasMaxLength(200)
            .HasColumnType("varchar(MAX)");

            builder.ToTable("Twitters");

            builder.Property(x => x.Id).HasColumnName("ID");
            builder.Property(x => x.Tweet).HasColumnName("Tweet");
        }
    }
}
