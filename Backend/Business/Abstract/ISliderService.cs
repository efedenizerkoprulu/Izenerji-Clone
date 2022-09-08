using Core.Utilities.Results;
using Entities;
using Entities.Dtos;

namespace Business.Abstract
{
    public interface ISliderService
    {
        IDataResult<List<SliderSliderDetailDIO>> GetSliderList();
        IDataResult<SliderSliderDetailDIO> GetSliderById(int id);
    }
}
