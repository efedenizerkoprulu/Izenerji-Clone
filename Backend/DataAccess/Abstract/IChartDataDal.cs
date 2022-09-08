using Core.DataAccess;
using Entities;
using Entities.Dtos;

namespace DataAccess.Abstract
{
    public interface IChartDataDal: IEntityRepository<ChartData>
    {
        List<ChartDataDayDTO> GetData();
    }
}
