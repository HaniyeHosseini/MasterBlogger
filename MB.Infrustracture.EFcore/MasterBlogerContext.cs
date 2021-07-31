using MB.Domain.ArticleCategoryAgg;
using MB.Infrustracture.EFcore.Mappings;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace MB.Infrustracture.EFcore
{
    public class MasterBlogerContext : DbContext
    {
        public DbSet <ArticleCategory> ArticleCategories { get; set; }
        public MasterBlogerContext(DbContextOptions<MasterBlogerContext> options) : base(options)
        {
                
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ArticleCategoryMapping());
            base.OnModelCreating(modelBuilder);
        }
    }
}
