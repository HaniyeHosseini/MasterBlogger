using MB.Application;
using MB.Application.Contracts.ArticleCategory;
using MB.Domain.ArticleCategoryAgg;
using MB.Domain.ArticleCategoryAgg.Services;
using MB.Infrustracture.EFcore;
using MB.Infrustracture.EFcore.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace MB.Infrustructure.Core
{
    public class Bootstrapper
    {
        public static void Config(IServiceCollection services,string connectionstring )
        {

            services.AddTransient<IArticleCategpryApplication, ArticleCategoryApplication>();
            services.AddTransient<IArticleCategoryRepository, ArticleCategoryRepository>();
            services.AddTransient<IArticleCategoryValidation, ArticleCategoryValidation>();
            services.AddDbContext<MasterBlogerContext>(options => options.UseSqlServer(connectionstring));

        }
    }
}
