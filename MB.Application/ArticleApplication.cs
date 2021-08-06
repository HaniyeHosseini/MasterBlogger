using MB.Application.Contracts;
using MB.Application.Contracts.Articlee;
using MB.Domain.ArticleAggg;
using MB.Infrustracture.EFcore.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace MB.Application
{
    public class ArticleApplication : IArticleApplication
    {
        private readonly IArticleRepository _iarticleRepository;

        public ArticleApplication(ArticleRepository articleRepository)
        {
            this._iarticleRepository = articleRepository;
        }

        public List<ArticleViewModel> GetList()
        {
            return _iarticleRepository.GetList();
            
        }
    }
}
