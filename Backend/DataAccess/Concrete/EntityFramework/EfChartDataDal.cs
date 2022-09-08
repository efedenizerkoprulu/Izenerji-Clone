using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfChartDataDal : EfEntityRepositoryBase<ChartData, İzenerjiContext>, IChartDataDal
    {
        public List<ChartDataDayDTO> GetData()
        {
            using (var context = new İzenerjiContext())
            {
                var getChartData = (from charData in context.ChartDatas
                                    join day in context.Days
                                    on charData.DayId equals day.Id
                                    select new ChartDataDayDTO
                                    {
                                        Id = charData.Id,
                                        Data = charData.Data,
                                        DayName = day.Name

                                    }).ToList();
                return getChartData;
            }
        }
    }
}
