using MB.Application.Contracts.ArticleCategory;
using MB.Domain.ArticleCategoryAgg;
using MB.Domain.ArticleCategoryAgg.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MB.Application
{
    public class ArticleCategoryApplication : IArticleCategpryApplication
    {
        private readonly IArticleCategoryRepository articleCategoryRepository;
        private readonly IArticleCategoryValidation articleCategoryValidation;
        public ArticleCategoryApplication(IArticleCategoryRepository articleCategoryRepository,IArticleCategoryValidation articleCategoryValidation)
        {
            this.articleCategoryValidation = articleCategoryValidation;
            this.articleCategoryRepository = articleCategoryRepository;
        }

        public void Create(CreateArticleCategory command)
        {
            var articlecategory = new ArticleCategory(command.Title,articleCategoryValidation);
            articleCategoryRepository.Add(articlecategory);
           

        }

        public RenameArticleCategory Get(long Id)
        {
            var articlecategory = articleCategoryRepository.GetBy(Id);
             var result = new RenameArticleCategory() {
                 Id=articlecategory.Id,
             Title=articlecategory.Title,
             };
            return result;
        }

        public List<ArticleCategoryViewModel> List()
        {
            var articlecategories = articleCategoryRepository.GetAll();
            var result = new List <ArticleCategoryViewModel>();
            foreach(var articlecaategory in  articlecategories)
            {
                result.Add(new ArticleCategoryViewModel
                {
                    Id = articlecaategory.Id,
                    Title = articlecaategory.Title,
                    CraetionDate = articlecaategory.CreationDate.ToString(),
                    IsDeleted = articlecaategory.IsDeleted,
                });
                    
            }
            return result;
        }

        public void Remove(long Id)
        {
           var articleCategory = articleCategoryRepository.GetBy(Id);
            articleCategory.Remove();
            articleCategoryRepository.Save();

        }

        public void Rename(RenameArticleCategory command)
        {
            var articlecategory = articleCategoryRepository.GetBy(command.Id);
            articlecategory.Rename(command.Title);
            articleCategoryRepository.Save(); 
        }

        public void Activate(long Id)
        {
            var articleCategory = articleCategoryRepository.GetBy(Id);
            articleCategory.Restore();
            articleCategoryRepository.Save();
        }
    }
}
