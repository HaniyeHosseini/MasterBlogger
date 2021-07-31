using System;
using System.Collections.Generic;
using System.Text;

namespace MB.Domain.ArticleCategoryAgg
{
   public interface IArticleCategoryRepository
    {
        List<ArticleCategory> GetAll();
        void Add(ArticleCategory entiti);

        ArticleCategory GetBy(long Id);
        void Save();
        bool Exist(string title);
    }
}
