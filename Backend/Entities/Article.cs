using Core.Entities;

namespace Entities
{
    public class Article:ManageID,IEntity
    {
        public int CategoryId { get; set; }
        public DateTime Date { get; set; }
        public string Title { get; set; }
        public Category Category { get; set; }
        public ArticleDetail articleDetail { get; set; }

    }
}
