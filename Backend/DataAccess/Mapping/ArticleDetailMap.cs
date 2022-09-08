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
    internal class ArticleDetailMap : IEntityTypeConfiguration<ArticleDetail>
    {
        public void Configure(EntityTypeBuilder<ArticleDetail> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Explanation)
                .HasColumnType("varchar(MAX)");

            builder.ToTable("ArticleDetails");

            builder.Property(x => x.Id).HasColumnName("ID");
            builder.Property(x => x.ArticleID).HasColumnName("ArticleID");
            builder.Property(x => x.Explanation).HasColumnName("Explanation");

            builder.HasOne(x => x.Article).WithOne(y => y.articleDetail);
        }
    }
}
