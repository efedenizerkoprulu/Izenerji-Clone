using Core.Entities;

namespace Entities
{
    public class Twitter:ManageID,IEntity
    {
        public string Tweet { get; set; }
    }
}
