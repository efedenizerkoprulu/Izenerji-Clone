using Core.Entities;

namespace Entities
{
    public class Slider:ManageID,IEntity
    {
        public string Title { get; set; }
        public SliderDetail SliderDetail { get; set; }
    }
}
