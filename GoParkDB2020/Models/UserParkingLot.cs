using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoParkDB2020.Models
{
    public class UserParkingLot
    {
        public int UserParkingLotsID { get; set; }
        // The 2 following references are foreign keys.
        public int UserID { get; set; }
        public int ParkingLotID { get; set; }
    }
}
