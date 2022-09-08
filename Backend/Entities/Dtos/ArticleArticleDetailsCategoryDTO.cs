using Core.Entities;

namespace Entities.Dtos
{
    public class ArticleArticleDetailsCategoryDTO:ManageID,IDto
    {
        public string CategoryName { get; set; }
        public string ArticleDetail { get; set; }
        public string Title { get; set; }
        public DateTime Date { get; set; }
    }
}
