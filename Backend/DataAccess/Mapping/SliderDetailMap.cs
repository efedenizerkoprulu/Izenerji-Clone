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
    public class SliderDetailMap : IEntityTypeConfiguration<SliderDetail>
    {
        public void Configure(EntityTypeBuilder<SliderDetail> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Explanation)
                .HasColumnType("varchar(MAX)");
               

            builder.ToTable("SliderDetails");

            builder.Property(x => x.Id).HasColumnName("ID");
            builder.Property(x => x.SliderID).HasColumnName("SliderID");
            builder.Property(x => x.Explanation).HasColumnName("Explanation");

            builder.HasOne(x => x.Slider).WithOne(y => y.SliderDetail);
        }
    
    }
}
