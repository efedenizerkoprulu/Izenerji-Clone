using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Mapping
{
    public class SliderMap : IEntityTypeConfiguration<Slider>
    {
        public void Configure(EntityTypeBuilder<Slider> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Title)
                .HasMaxLength(50)
                .HasColumnType("Varchar")
                .IsRequired();

            builder.ToTable("Sliders");

            builder.Property(x => x.Id).HasColumnName("ID");
            builder.Property(x => x.Title).HasColumnName("Title");
            
        }
    }
}
