using MB.Domain.Article;
using System;
using System.Collections.Generic;
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


    }
}
