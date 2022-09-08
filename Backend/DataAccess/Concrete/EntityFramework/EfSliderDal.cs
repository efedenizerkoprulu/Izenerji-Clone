using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities;
using Entities.Dtos;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfSliderDal : EfEntityRepositoryBase<Slider, İzenerjiContext>, ISliderDal
    {
        public List<SliderSliderDetailDIO> GetSlider()
        {
            using (var context = new İzenerjiContext())
            {
                var getSlider = (from slider in context.Sliders
                                 join sliderDetail in context.SliderDetails
                                 on slider.Id equals sliderDetail.SliderID
                                 select new SliderSliderDetailDIO
                                 {
                                     Id = slider.Id,
                                     Title = slider.Title,
                                     SliderDetail = sliderDetail.Explanation,

                                 }).ToList();
                return getSlider;
            }
        }

        public SliderSliderDetailDIO GetSliderById(int id)
        {
            var sliderlist = GetSlider();
            return sliderlist.Where(x => x.Id == id).FirstOrDefault();
        }
    }
}
