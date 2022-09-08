using Core.DataAccess;
using Entities;

namespace DataAccess.Abstract
{
    public interface IEmployeeDal: IEntityRepository<Employee>
    {
    }
}
