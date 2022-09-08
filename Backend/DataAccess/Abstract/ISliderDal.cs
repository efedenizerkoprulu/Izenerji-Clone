using Core.DataAccess;
using Entities;
using Entities.Dtos;

namespace DataAccess.Abstract
{
    public interface ISliderDal: IEntityRepository<Slider>
    {
        public List<SliderSliderDetailDIO> GetSlider();
        public SliderSliderDetailDIO GetSliderById(int id);
    }
}
