using MB.Domain.ArticleAggg;
using MB.Domain.ArticleCategoryAgg.Exeptions;
using MB.Domain.ArticleCategoryAgg.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace MB.Domain.ArticleCategoryAgg
{
    public class ArticleCategory
    {
        public long Id { get; private set; }



        public string Title { get; private set; }

        public DateTime CreationDate { get; private set; }

        public bool IsDeleted { get; private set; }
        public ArticleCategory()
        {

<<<<<<< HEAD
        }
        public ArticleCategory(string title, IArticleCategoryValidation articleCategoryValidation)
=======
        public ICollection <Article> Articles { get; set; }
        public ArticleCategory()
        {
                
        }

        public ArticleCategory(string title , IArticleCategoryValidation articleCategoryValidation)
>>>>>>> 30d24378789c5032be26dc1e818df7a32ab19aa6
        {
            GurdAgainstEmptyTitle(title);
          articleCategoryValidation.CheckCategoryValidationAlredayExist(title);

            Title = title;
            CreationDate = DateTime.Now;
            IsDeleted = false;
            Articles = new List<Article>();
        }

        public void GurdAgainstEmptyTitle(string title)
        {
            if (string.IsNullOrWhiteSpace(title))
                throw new DuplicatedRecordExeption("This Title Already Exists in Database");
        }
        public void Rename(string title)
        {
            GurdAgainstEmptyTitle(title);

            Title = title;
        }

        public void Remove()
        {
            IsDeleted = true;
        }

        public void Restore()
        {
            IsDeleted = false;
        }
    }
}
