using Core.Entities;

namespace Entities
{
    public class SliderDetail:ManageID,IEntity
    {
        public int SliderID { get; set; }
        public string Explanation { get; set; }
        public Slider Slider { get; set; }
    }
}
