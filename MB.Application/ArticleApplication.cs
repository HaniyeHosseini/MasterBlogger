<<<<<<< HEAD
﻿using MB.Application.Contracts.Articlee;
=======
﻿using MB.Application.Contracts;
using MB.Application.Contracts.Articlee;
using MB.Domain.ArticleAggg;
using MB.Infrustracture.EFcore.Repositories;
>>>>>>> 30d24378789c5032be26dc1e818df7a32ab19aa6
using System;
using System.Collections.Generic;
using System.Text;

namespace MB.Application
{
<<<<<<< HEAD
    class ArticleApplication : IArticleApplication
    {

=======
    public class ArticleApplication : IArticleApplication
    {
        private readonly IArticleRepository _iarticleRepository;

        public ArticleApplication(IArticleRepository articleRepository)
        {
            this._iarticleRepository = articleRepository;
        }

        public void Create(CreateArticle command)
        {
            var article = new Article(command.Title, command.Image, command.ShortDiscription
                , command.Content, command.ArticleCategoryId);
            _iarticleRepository.Create(article);
        }

        public void Edit(EditArticle command)
        {
            var article = _iarticleRepository.GetBy(command.Id);
            article.Edit(command.Title, command.Image, command.ShortDiscription, command.Content, command.ArticleCategoryId);
            _iarticleRepository.Save();
            
        }

        public EditArticle GetBy(long Id)
        {
            var article=_iarticleRepository.GetBy(Id);
            return new EditArticle()
            {
                Id=article.Id,
                ShortDiscription=article.ShortDiscription,
                ArticleCategoryId=article.ArticleCategoryId,
                Content=article.Content,
                Image=article.Image,
                Title=article.Title,
            };
        }

        public List<ArticleViewModel> GetList()
        {
           var articles= _iarticleRepository.GetList();
            return articles;
            
        }
>>>>>>> 30d24378789c5032be26dc1e818df7a32ab19aa6
    }
}
