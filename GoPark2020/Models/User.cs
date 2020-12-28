using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace GoPark2020.Models
{
    public class User
    {
        [Key]
        public int UserID { get; set; }
        public string FirstName { get; set; }
        public bool RequiresHandicapAccomodation { get; set; }
        public int PassportNumber { get; set; }
        public string Notes { get; set; }
        public virtual ICollection<PaymentMethod> PaymentMethods { get; set; }
        public virtual ICollection<Phone> Phones { get; set; }
        public virtual ICollection<Spot> Spots { get; set; }
        public virtual ICollection<UserDiscount> UserDiscounts { get; set; }
        public virtual ICollection<UserParkingLot> UserParkingLots { get; set; }


    }
}
