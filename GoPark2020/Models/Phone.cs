using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace GoPark2020.Models
{
    public class Phone
    {
        [Key]
        public int PhoneID { get; set; }

        //[ForeignKey("UserID")]
        public int UserID { get; set; }
        public int PhoneNumber { get; set; }
        public virtual User User { get; set; }
    }
}
