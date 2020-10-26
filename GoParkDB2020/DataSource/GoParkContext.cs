using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using GoParkDB2020.Models;

namespace GoParkDB2020.DataSource
{
    public class GoParkContext : DbContext
    {
        public DbSet<Discount> Discounts { get; set; }
        
        public DbSet<ParkingLot> ParkingLot { get; set; }

        public DbSet<PaymentMethod> PaymentMethods { get; set; }
        public DbSet<Phone>Phones{ get; set; }
        public DbSet<Spot> Spots { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserDiscount>UserDiscounts  { get; set; }
        public DbSet<UserParkingLot>  UserParkingLots{ get; set; }
 
    }
}
