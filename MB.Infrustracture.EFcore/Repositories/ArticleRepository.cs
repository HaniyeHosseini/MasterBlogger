
using MB.Application.Contracts.Articlee;
using MB.Domain.ArticleAggg;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace MB.Infrustracture.EFcore.Repositories
{
  public  class ArticleRepository : IArticleRepository
    {
        private readonly MasterBlogerContext _context;

        public ArticleRepository(MasterBlogerContext context)
        {
            _context = context;
        }

        public List<ArticleViewModel> GetList()
        {
            return _context.Articles.Include(x => x.ArticleCategory).Select(x => new ArticleViewModel()
            {
                Id=x.Id,
                CreationDate=x.CreationDate.ToString(CultureInfo.InvariantCulture),
                ArticleCategory=x.ArticleCategory.Title,
                IsDeleted = x.IsDeleted,
                Title=x.Title,
            }).ToList();
        }
    }
}
