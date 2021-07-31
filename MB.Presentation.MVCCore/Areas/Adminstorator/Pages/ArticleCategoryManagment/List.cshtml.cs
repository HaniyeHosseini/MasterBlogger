using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MB.Application.Contracts.ArticleCategory;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MB.Presentation.MVCCore.Areas.Adminstorator.Pages.ArticleCategoryManagment
{
    public class ListModel : PageModel
    {
        public List<ArticleCategoryViewModel> Articlecategories { get; set; }
        private readonly IArticleCategpryApplication articleCategpryApplication;

        public ListModel(IArticleCategpryApplication articleCategpryApplication)
        {
            this.articleCategpryApplication = articleCategpryApplication;
        }

        public void OnGet()
        {
            Articlecategories = articleCategpryApplication.List();
        }

        public RedirectToPageResult OnPostRemove(long id)
        {
            articleCategpryApplication.Remove(id);
            return RedirectToPage("./list");
        }
        public RedirectToPageResult OnPostActivate(long id)
        {
            articleCategpryApplication.Activate(id);
            return RedirectToPage("./list");
        }
    }
}
