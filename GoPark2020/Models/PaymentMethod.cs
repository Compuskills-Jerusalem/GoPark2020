﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GoPark2020.Models
{
    public class PaymentMethod
    {
        [Key]
        public int PaymentMethodID { get; set; }

        //[ForeignKey("UserID")]
        public int UserID { get; set; }
        public virtual User User { get; set; }
    }
}
