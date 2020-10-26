using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GoPark2020.Models
{
    public class Discount
    {
        [Required]
        public string DiscountName { get; set; }
    }
}