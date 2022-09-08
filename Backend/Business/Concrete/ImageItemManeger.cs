using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ImageItemManeger : IImageItemService
    {
        IImageItemDal _imageItemDal;

        public ImageItemManeger(IImageItemDal imageItemDal)
        {
            _imageItemDal = imageItemDal;
        }

        public IDataResult<List<İmageItem>> GetİmageList()
        {
            return new SuccessDataResult<List<İmageItem>>(_imageItemDal.GetAll());
        }
    }
}
