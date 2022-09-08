using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Mapping
{
    internal class ChartDataMap : IEntityTypeConfiguration<ChartData>
    {
        public void Configure(EntityTypeBuilder<ChartData> builder)
        {
            builder.HasKey(x => x.Id);

            builder.ToTable("ChartDatas");

            builder.Property(x => x.Id).HasColumnName("ID");
            builder.Property(x => x.DayId).HasColumnName("DayId");
            builder.Property(x => x.Data).HasColumnName("Data");

            builder.HasOne(x=> x.Day).WithMany(y=> y.Charts).HasForeignKey(z=> z.DayId);
        }
    }
}
