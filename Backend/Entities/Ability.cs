using Core.Entities;

namespace Entities
{
    public class Ability: ManageID,IEntity
    {
        public string Name { get; set; }
        public int SuccsessPercentage { get; set; }
    }
}
