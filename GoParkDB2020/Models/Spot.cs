using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoPark2020.Models
{
    public class Spot
    {
        public int SpotID { get; set; }
        public int ParkingLotID { get; set; }
        public int CurrentUserID { get; set; }
        public int Floor_Number { get; set; }
        public int Row_Number { get; set; }
        public bool IsHandicap { get; set; }
    }
}
