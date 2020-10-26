using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoParkDB2020.Models
{
    public class PaymentMethod
    {
        public int PaymentMethodID { get; set; }

        //this one is a refrence
        public int UserID { get; set; }
    }
}
