using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace GoPark2020.Models
{
    public class UserDiscount
    {
        [Key]
        public int UserDiscountID { get; set; }
        //The following are 2 foreign keys.
        //[ForeignKey("UserID")]
        public int UserID { get; set; }
        //[ForeignKey("DiscountID")]
        public int DiscountID { get; set; }
        public virtual User User { get; set; }
        public virtual Discount Discount { get; set; }

    }
}
