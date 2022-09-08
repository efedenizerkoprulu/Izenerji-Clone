using Core.Utilities.Results;
using Entities;

namespace Business.Abstract
{
    public interface ITwitterService
    {
        IDataResult<List<Twitter>> GetTwitterList();
    }
}
