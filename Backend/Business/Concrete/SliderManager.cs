using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class SliderManager:ISliderService
    {
        ISliderDal _sliderDal;

        public SliderManager(ISliderDal sliderDal)
        {
            _sliderDal = sliderDal;
        }

        public IDataResult<SliderSliderDetailDIO> GetSliderById(int id)
        {
            return new SuccessDataResult<SliderSliderDetailDIO>(_sliderDal.GetSliderById(id));
        }

        public IDataResult<List<SliderSliderDetailDIO>> GetSliderList()
        {
           return new SuccessDataResult<List<SliderSliderDetailDIO>>(_sliderDal.GetSlider());
        }
    }
}
