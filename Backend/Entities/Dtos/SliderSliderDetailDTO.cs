using Core.Entities;

namespace Entities.Dtos
{
    public class SliderSliderDetailDIO:ManageID,IDto
    {
        public string SliderDetail { get; set; }
        public string Title { get; set; }
    }
}
