using MB.Domain.ArticleCategoryAgg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MB.Infrustracture.EFcore.Repositories
{
    public class ArticleCategoryRepository : IArticleCategoryRepository
    {
        private readonly MasterBlogerContext _context;

        public ArticleCategoryRepository(MasterBlogerContext context)
        {
            _context = context;
        }

        public void Add(ArticleCategory entiti)

        {
            _context.ArticleCategories.Add(entiti);
            Save();
        }

        public bool Exist(string title)
        {
            return _context.ArticleCategories.Any(x => x.Title == title);
        }

        public List<ArticleCategory> GetAll()
        {
            return _context.ArticleCategories.OrderByDescending(x=>x.Id).ToList();
        }

        public ArticleCategory GetBy(long Id)
        {
            return _context.ArticleCategories.Find(Id);
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
