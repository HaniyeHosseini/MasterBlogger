using MB.Domain.ArticleCategoryAgg;
using MB.Domain.ArticleCategoryAgg.Exeptions;
using MB.Domain.ArticleCategoryAgg.Services;
using System;

namespace MB.Domain.ArticleCategoryAgg.Services
{
    public class ArticleCategoryValidation : IArticleCategoryValidation
    {
        private readonly IArticleCategoryRepository articleCategoryRepository;
        public ArticleCategoryValidation()
        {
                
        }
        public ArticleCategoryValidation(IArticleCategoryRepository articleCategoryRepository)
        {
            this.articleCategoryRepository = articleCategoryRepository;
        }

        public void CheckCategoryValidationAlredayExist(string title)
        {
            if (articleCategoryRepository.Exist(title))
                throw new DuplicatedRecordExeption("This Record Already Exists in Database");
        }
    }
}
