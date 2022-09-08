using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class ChartData:ManageID,IEntity
    {
        public int DayId { get; set; }
        public int Data { get; set; }
        public Day Day { get; set; }

    }
}
