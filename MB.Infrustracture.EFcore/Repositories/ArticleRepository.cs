
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
    public class ArticleRepository : IArticleRepository
    {
        private readonly MasterBlogerContext _context;

        public ArticleRepository(MasterBlogerContext context)
        {
            _context = context;
        }

        public void Create(Article entiti)
        {

            _context.Articles.Add(entiti);
            Save();

        }

      

        public Article GetBy(long id)
        {
            return _context.Articles.Find(id);
        }

        public List<ArticleViewModel> GetList()
        {


            return _context.Articles.Include(x => x.ArticleCategory).Select(x => new ArticleViewModel
            {
                Id = x.Id,
                Title = x.Title,
                ArticleCategory = x.ArticleCategory.Title,
                IsDeleted = x.IsDeleted,
                CreationDate = x.CreationDate.ToString(CultureInfo.InvariantCulture)
            }).ToList();

        }
        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
