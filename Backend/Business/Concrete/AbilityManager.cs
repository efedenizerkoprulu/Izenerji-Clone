using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities;

namespace Business.Concrete
{
    public class AbilityManager : IAbilityService
    {
        IAbilityDal _abilityDal;

        public AbilityManager(IAbilityDal abilityDal)
        {
            _abilityDal = abilityDal;
        }

        public IDataResult<List<Ability>> GetAbilityList()
        {
            return new SuccessDataResult<List<Ability>>(_abilityDal.GetAll());
        }
    }
}
