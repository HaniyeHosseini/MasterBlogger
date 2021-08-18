using System;
using System.Collections.Generic;
using System.Text;

namespace MB.Application.Contracts.Articlee
{
    public interface IArticleApplication
    {
<<<<<<< HEAD
=======
        List<ArticleViewModel> GetList();
        EditArticle GetBy(long Id);
        void Create(CreateArticle command);
        void Edit(EditArticle command);
>>>>>>> 30d24378789c5032be26dc1e818df7a32ab19aa6

    }
}
