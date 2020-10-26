using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoParkDB2020.Models
{
    public class UserDiscount
    {
        public int UserDiscountID { get; set; }
        //The following are 2 foreign keys.
        public int UserID { get; set; }
        public int DiscountID { get; set; }
    }
}
