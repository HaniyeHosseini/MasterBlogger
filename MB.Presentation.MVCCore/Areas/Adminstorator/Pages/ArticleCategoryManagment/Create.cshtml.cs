using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MB.Application.Contracts.ArticleCategory;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MB.Presentation.MVCCore.Areas.Adminstorator.Pages.ArticleCategoryManagment
{
    public class CreateModel : PageModel
    {
        private readonly IArticleCategpryApplication articleCategoryApplication;

        public CreateModel(IArticleCategpryApplication articleCategoryApplication)
        {
            this.articleCategoryApplication = articleCategoryApplication;
        }

        public void OnGet()
        {

        }
        public RedirectToPageResult OnPost(CreateArticleCategory command)
        {
            articleCategoryApplication.Create(command);
            return RedirectToPage("./List");
        }

        
    }
}
