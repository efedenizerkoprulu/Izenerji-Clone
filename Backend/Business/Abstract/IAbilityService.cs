using Core.Utilities.Results;
using Entities;

namespace Business.Abstract
{
    public interface IAbilityService
    {
        IDataResult<List<Ability>> GetAbilityList();
    }
}
