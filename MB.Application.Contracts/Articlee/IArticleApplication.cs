using System;
using System.Collections.Generic;
using System.Text;

namespace MB.Application.Contracts.Articlee
{
    public interface IArticleApplication
    {
        List<ArticleViewModel> GetList();
        EditArticle GetBy(long Id);
        void Create(CreateArticle command);
        void Edit(EditArticle command);

    }
}
