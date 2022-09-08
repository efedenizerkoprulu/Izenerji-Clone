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
    public class EmployeeMap : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Firstname)
                .HasMaxLength(20)
                .HasColumnType("Varchar")
                .IsRequired();

            builder.Property(x => x.Lastname)
                .HasMaxLength(20)
                .HasColumnType("Varchar")
                .IsRequired();

            builder.Property(x => x.Position)
                .HasMaxLength(30)
                .HasColumnType("Varchar")
                .IsRequired();

            builder.Property(x => x.Explanation)
                .HasMaxLength(200)
            .HasColumnType("varchar(MAX)");

            builder.ToTable("Employees");

            builder.Property(x => x.Id).HasColumnName("ID");
            builder.Property(x => x.Firstname).HasColumnName("Firstname");
            builder.Property(x => x.Lastname).HasColumnName("Lastname");
            builder.Property(x => x.Position).HasColumnName("Position");
            builder.Property(x => x.Explanation).HasColumnName("Explanation");
        }
    }
}
