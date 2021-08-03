using MB.Domain.ArticleCategoryAgg;
using System;
using System.Collections.Generic;
using System.Text;

namespace MB.Domain.Article
{
    public class Article
    {
        public long Id { get;  private set; }

        public string Title { get; private set; }

        public string  ShortDiscribtion { get; private set; }

        public string Image { get; private set; }

        public string Content { get; private set; }

        public bool IsDeleted { get; private set; }

        public DateTime CreationDate { get; private set; }
        public long ArticleCategoryId { get; private set; }

        public ArticleCategory ArticleCategory { get; private set; }

        protected Article()
        {
                
        }

        public Article(string title, string shortDiscribtion, string image, string content,long articlecategoryid)
        {
            Title = title;
            ShortDiscribtion = shortDiscribtion;
            Image = image;
            Content = content;
            IsDeleted = false;
            CreationDate = DateTime.Now;
            ArticleCategoryId = articlecategoryid;

        }
    }
}
