using System;
using System.Collections.Generic;
using System.Text;

namespace MB.Application.Contracts.Articlee
{
    public interface IArticleApplication
    {
        List<ArticleViewModel> GetList();

    }
}
