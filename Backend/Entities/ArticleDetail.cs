using Core.Entities;

namespace Entities
{
    public class ArticleDetail:ManageID,IEntity
    {
        public int ArticleID { get; set; }
        public string Explanation { get; set; }
        public Article Article { get; set; }

    }
}
