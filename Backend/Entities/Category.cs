using Core.Entities;

namespace Entities
{
    public class Category:ManageID,IEntity
    {
        public string Name { get; set; }
        public List<Article> articles { get; set; }
    }
}
