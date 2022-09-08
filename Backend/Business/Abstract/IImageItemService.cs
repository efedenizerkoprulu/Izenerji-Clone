using Core.Utilities.Results;
using Entities;

namespace Business.Abstract
{
    public interface IImageItemService
    {
        IDataResult<List<İmageItem>> GetİmageList();
    }
}
