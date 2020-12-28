using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace GoPark2020.Models
{
    public class Discount
    {
        [Key]
        public int DiscountID { get; set; }
        public string DiscountName { get; set; }
        public virtual ICollection<UserDiscount> UserDiscounts { get; set; }


    }
}
