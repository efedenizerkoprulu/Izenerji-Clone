using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities;

namespace Business.Concrete
{
    public class TwitterManager : ITwitterService
    {
        ITwitterDal _twitterDal;

        public TwitterManager(ITwitterDal twitterDal)
        {
            _twitterDal = twitterDal;
        }

        public IDataResult<List<Twitter>> GetTwitterList()
        {
           return new SuccessDataResult<List<Twitter>>(_twitterDal.GetAll());
        }
    }
}
