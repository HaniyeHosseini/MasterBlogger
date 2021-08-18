using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MB.Application;
using MB.Application.Contracts.ArticleCategory;
using MB.Application.Contracts.Articlee;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace MB.Presentation.MVCCore.Areas.Adminstorator.Pages.ArticleManagment
{
    public class CreateModel : PageModel
    {
       
        private readonly IArticleCategpryApplication _articleCategpryApplication;
        private readonly IArticleApplication _articleApplication;
        public List<SelectListItem> ArticleCategory { get; set; }

        public CreateModel(IArticleCategpryApplication articleCategpryApplication, IArticleApplication articleApplication)
        {
            _articleCategpryApplication = articleCategpryApplication;
            _articleApplication = articleApplication;
        }

        public void OnGet()
        {

          ArticleCategory= _articleCategpryApplication.List().Select(x => new SelectListItem(x.Title,x.Id.ToString())).ToList();

        }
        public RedirectToPageResult OnPost(CreateArticle article)
        {
            _articleApplication.Create(article);
            return RedirectToPage("./list");
        }
    }
}
