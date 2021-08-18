using MB.Infrustracture.EFcore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MB.Infrustraucture.Query
{
    public class ArticleQuery : IArticleQuery
    {
        public MasterBlogerContext _context { get; set; }
        public List<ArticleViewQuery> GetArticles()
        {
            return _context.Articles.Include(x => x.ArticleCategory).Select(x => new ArticleViewQuery
            {
                Id = x.Id,
                Title = x.Title,
                ShortDiscription = x.ShortDiscription,
                CreationDate = x.CreationDate.ToString(),
                ArticleCategory = x.ArticleCategory.Title,
                Image = x.Image
            }).ToList();
        }
    }
}
