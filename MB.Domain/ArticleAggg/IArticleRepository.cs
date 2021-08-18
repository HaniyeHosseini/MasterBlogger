using MB.Application.Contracts.Articlee;
using System;
using System.Collections.Generic;
using System.Text;

namespace MB.Domain.ArticleAggg
{
   public interface IArticleRepository
    {  


       List<ArticleViewModel> GetList();

        void Create(Article entiti);

        Article GetBy(long id);

        void Save();
    }
}
