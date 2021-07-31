using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MB.Application.Contracts.ArticleCategory;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MB.Presentation.MVCCore.Areas.Adminstorator.Pages.ArticleCategoryManagment
{
    public class EditModel : PageModel
    {
        private readonly IArticleCategpryApplication articlecategoryApplication;
      [BindProperty]  public RenameArticleCategory ArticleCategory { get; set; }

        public EditModel(IArticleCategpryApplication articlecategoryApplication)
        {
            this.articlecategoryApplication = articlecategoryApplication;
        }

        public void OnGet(long Id)
        {
            ArticleCategory = articlecategoryApplication.Get(Id);

        }

        public RedirectToPageResult OnPost()
        {
            articlecategoryApplication.Rename(ArticleCategory);
            return RedirectToPage("./list");
        }
    }
}
