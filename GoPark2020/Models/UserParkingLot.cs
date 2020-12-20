using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace GoPark2020.Models
{
    public class UserParkingLot
    {
        [Key]
        public int UserParkingLotsID { get; set; }
        // The 2 following references are foreign keys.
        //[ForeignKey("UserID")]
        public int UserID { get; set; }
        //[ForeignKey("ParkingLotID")]
        public int ParkingLotID { get; set; }
        public virtual User User { get; set; }
        public virtual ParkingLot ParkingLot { get; set; }
    }
}
