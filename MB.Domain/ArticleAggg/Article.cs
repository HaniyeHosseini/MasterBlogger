using MB.Domain.ArticleCategoryAgg;
using System;
using System.Collections.Generic;
using System.Text;

namespace MB.Domain.ArticleAggg
{
    public class Article
    {
<<<<<<< HEAD
        public long Id { get;private set; }
        public string Title { get; private set; }
        public bool IsDeleted { get; private set; }
        public string Image { get; private set; }

        public string ShortDiscription { get; private set; }
        public string Content { get; private set; }
       
        public DateTime CreationDate { get; private set; }


        public long ArticleCategoryId { get; private set; }
        public ArticleCategory ArticleCategory { get; private set; }

        protected Article()
=======
        public long Id { get; private set; }
        public string Title { get; private set; }
        public string Image { get; private set; }
        public string ShortDiscription { get; private set; }
        public string Content { get; private set; }

        public bool IsDeleted { get; private set; }
        public DateTime CreationDate { get;private set; }

        public ArticleCategory ArticleCategory { get; private set; }
        public long ArticleCategoryId { get; private set; }

        public Article()
>>>>>>> 30d24378789c5032be26dc1e818df7a32ab19aa6
        {
                
        }

<<<<<<< HEAD
        public Article(string title, string image, string shortDiscription, string content, long articleCategoryId)
        {
=======
        public Article( string title, string image, string shortDiscription, string content, long articleCategoryId)
        {
            
>>>>>>> 30d24378789c5032be26dc1e818df7a32ab19aa6
            Title = title;
            Image = image;
            ShortDiscription = shortDiscription;
            Content = content;
            ArticleCategoryId = articleCategoryId;
<<<<<<< HEAD
            CreationDate = DateTime.Now;
            IsDeleted = false;
=======
            IsDeleted = false;
            CreationDate = DateTime.Now;
          
        }
        public void Edit(string title, string image, string shortDiscription, string content, long articleCategoryId)
        {

            Title = title;
            Image = image;
            ShortDiscription = shortDiscription;
            Content = content;
            ArticleCategoryId = articleCategoryId;
            
>>>>>>> 30d24378789c5032be26dc1e818df7a32ab19aa6
        }
    }
}
