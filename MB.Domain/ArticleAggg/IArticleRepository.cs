using MB.Application.Contracts.Articlee;
using System;
using System.Collections.Generic;
using System.Text;

namespace MB.Domain.ArticleAggg
{
   public interface IArticleRepository
    {
        List<ArticleViewModel> GetList();
    }
}
