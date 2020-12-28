using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using GoPark2020.Models;
using System.Data.Entity.ModelConfiguration.Conventions;


namespace GoPark2020
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

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
