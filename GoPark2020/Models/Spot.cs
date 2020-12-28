using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace GoPark2020.Models
{
    public class Spot
    {
        [Key]
        public int SpotID { get; set; }
        //[ForeignKey("ParkingLotID")]
        public int ParkingLotID { get; set; }

        //[ForeignKey("CurrentUserID")]
        public int CurrentUserID { get; set; }
        public int Floor_Number { get; set; }
        public int Row_Number { get; set; }
        public bool IsHandicap { get; set; }
        public virtual ParkingLot ParkingLot { get; set; }
        public virtual User User { get; set; } 
    }
}
