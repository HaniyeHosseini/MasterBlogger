using MB.Domain.Article;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace MB.Infrustracture.EFcore.Mappings
{
    public class ArticleMapping : IEntityTypeConfiguration<Article>
    {
        public void Configure(EntityTypeBuilder<Article> builder)
        {
            builder.ToTable("Articles");
            builder.HasKey(x => x.Id);
            builder.Property(z => z.Title);
            builder.Property(z => z.ShortDiscribtion);
            builder.Property(z => z.Image);
            builder.Property(z => z.Content);
            builder.Property(z => z.CreationDate);
            builder.Property(z => z.IsDeleted);
            builder.HasOne(x=>x.ArticleCategory).


        }
    }
}
