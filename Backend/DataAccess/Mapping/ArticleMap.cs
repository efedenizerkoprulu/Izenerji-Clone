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
    public class ArticleMap : IEntityTypeConfiguration<Article>
    {
        public void Configure(EntityTypeBuilder<Article> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Title)
                .HasMaxLength(30)
                .HasColumnType("Varchar")
                .IsRequired();
            builder.Property(x => x.Date)
               .HasColumnType("DateTime2")
               .HasDefaultValueSql("getdate()");
               

            builder.ToTable("Articles");

            builder.Property(x => x.Id).HasColumnName("ID");  
            builder.Property(x => x.CategoryId).HasColumnName("CategoryId");
            builder.Property(x => x.Title).HasColumnName("Title");
            builder.Property(x => x.Date).HasColumnName("Date");

            builder.HasOne(x => x.Category).WithMany(y => y.articles).HasForeignKey(z => z.CategoryId);
        }
    }
}
