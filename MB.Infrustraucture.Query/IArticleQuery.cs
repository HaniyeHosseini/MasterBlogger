using System.Collections.Generic;
using System.Text;

namespace MB.Infrustraucture.Query
{
    public interface IArticleQuery
    {
        List<ArticleViewQuery> GetArticles();
    }
}
