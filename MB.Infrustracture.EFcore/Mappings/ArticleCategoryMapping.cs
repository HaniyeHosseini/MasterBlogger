using MB.Domain.ArticleCategoryAgg;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace MB.Infrustracture.EFcore.Mappings
{
    public class ArticleCategoryMapping : IEntityTypeConfiguration<ArticleCategory>
    {
        public void Configure(EntityTypeBuilder<ArticleCategory> builder)
        {
            builder.ToTable("ArticleCategories");
            builder.HasKey(x => x.Id);
            builder.Property(z => z.Title);
            builder.Property(z => z.CreationDate);
            builder.Property(z => z.IsDeleted);

            builder.HasMany(x => x.Articles)
                .WithOne(x => x.ArticleCategory)
                .HasForeignKey(x => x.ArticleCategoryId);


        }
    }
}
