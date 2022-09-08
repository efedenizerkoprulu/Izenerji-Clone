using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Dtos;

namespace Business.Concrete
{
    public class ChartDataManager : IChartDataService
    {
        IChartDataDal _chartDataDal;

        public ChartDataManager(IChartDataDal chartDataDal)
        {
            _chartDataDal = chartDataDal;
        }

        public IDataResult<List<ChartDataDayDTO>> GetChartData()
        {
            return new SuccessDataResult<List<ChartDataDayDTO>>(_chartDataDal.GetData());
        }
    }
}
