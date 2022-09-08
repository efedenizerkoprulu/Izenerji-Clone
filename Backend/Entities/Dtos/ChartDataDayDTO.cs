using Core.Entities;

namespace Entities.Dtos
{
    public class ChartDataDayDTO:ManageID,IDto
    {
        public int Data { get; set; }
        public string DayName { get; set; }

    }
}
