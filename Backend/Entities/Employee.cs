using Core.Entities;

namespace Entities
{
    public class Employee:ManageID,IEntity
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Position { get; set; }
        public string Explanation { get; set; }

    }
}
