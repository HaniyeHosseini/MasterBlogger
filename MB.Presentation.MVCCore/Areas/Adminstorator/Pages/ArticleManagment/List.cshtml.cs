using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MB.Application.Contracts.Articlee;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MB.Presentation.MVCCore.Areas.Adminstorator.Pages.ArticleManagment
{
    public class ListModel : PageModel
    {
        private readonly IArticleApplication _iarticleApplication;
        public List<ArticleViewModel> Articles { get; set; }
        public ListModel(IArticleApplication articleApplication)
        {
            _iarticleApplication = articleApplication;
        }

        public void OnGet()
        {
           
            Articles = _iarticleApplication.GetList();

        }
    }
}
