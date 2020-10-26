using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoParkDB2020.Models
{
    public class User
    {
        public int UserID { get; set; }
        public string FirstName { get; set; }
        public bool RequiresHandicapAccomodation { get; set; }
        public int PassportNumber { get; set; }
        public string Notes { get; set; }
    }
}
