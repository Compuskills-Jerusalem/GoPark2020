using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoPark2020.Models
{
   public class ParkingLot
    {        
        [Key]
        public int ParkingLotID { get; set; }
        public virtual ICollection<Spot> Spots { get; set; }
        public virtual ICollection<UserParkingLot> UserParkingLots { get; set; }

    }
}
