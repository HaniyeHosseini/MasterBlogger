namespace MB.Application.Contracts.Articlee
{
    public class CreateArticle
    {
        public string Title { get; set; }
        public string ShortDiscription { get; set; }
        public string Content { get; set; }
        public long ArticleCategoryId { get; set; }


        public string Image { get; set; }

    }
}
