using System.Collections.Generic;
using System.Text;

namespace MB.Domain.ArticleCategoryAgg.Services
{
    public interface IArticleCategoryValidation
    {
        void CheckCategoryValidationAlredayExist(string title);

    }
}
