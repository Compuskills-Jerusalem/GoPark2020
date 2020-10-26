using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoParkDB2020.Models
{
    public class Phone
    {
        public int PhoneID { get; set; }
        //This is a foreign key.
        public int UserID { get; set; }
        public int PhoneNumber { get; set; }


    }
}
