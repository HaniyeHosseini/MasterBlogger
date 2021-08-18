using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MB.Application.Contracts.ArticleCategory;
using MB.Application.Contracts.Articlee;
using MB.Domain.ArticleAggg;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace MB.Presentation.MVCCore.Areas.Adminstorator.Pages.ArticleManagment
{
    public class EditModel : PageModel
    {
        private readonly IArticleApplication articleApplication;
        private readonly IArticleCategpryApplication articleCategpryApplication;
       [BindProperty] public EditArticle Article { get; set; }
        public List<SelectListItem> ArticleCategories { get; set; }

        public EditModel(IArticleApplication articleApplication, IArticleCategpryApplication articleCategpryApplication)
        {
            this.articleApplication = articleApplication;
            this.articleCategpryApplication = articleCategpryApplication;
        }

        public void OnGet(long id)
        {
            Article = articleApplication.GetBy(id);
            ArticleCategories = articleCategpryApplication.List()
                .Select(x => new SelectListItem(text: x.Title, value: x.Id.ToString())).ToList();



        }
        public RedirectToPageResult OnPost()
        {
            articleApplication.Edit(Article);
            return RedirectToPage("./list");
        }
    }
}
