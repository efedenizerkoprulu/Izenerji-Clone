using Core.Entities;

namespace Entities
{
    public class İmageItem:ManageID,IEntity
    {
        public string Title { get; set; }
        public string Explanation { get; set; }
    }
}
