namespace GoPark2020.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Discount",
                c => new
                    {
                        DiscountID = c.Int(nullable: false, identity: true),
                        DiscountName = c.String(),
                    })
                .PrimaryKey(t => t.DiscountID);
            
            CreateTable(
                "dbo.UserDiscount",
                c => new
                    {
                        UserDiscountID = c.Int(nullable: false, identity: true),
                        UserID = c.Int(nullable: false),
                        DiscountID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.UserDiscountID)
                .ForeignKey("dbo.Discount", t => t.DiscountID, cascadeDelete: true)
                .ForeignKey("dbo.User", t => t.UserID, cascadeDelete: true)
                .Index(t => t.UserID)
                .Index(t => t.DiscountID);
            
            CreateTable(
                "dbo.User",
                c => new
                    {
                        UserID = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        RequiresHandicapAccomodation = c.Boolean(nullable: false),
                        PassportNumber = c.Int(nullable: false),
                        Notes = c.String(),
                    })
                .PrimaryKey(t => t.UserID);
            
            CreateTable(
                "dbo.PaymentMethod",
                c => new
                    {
                        PaymentMethodID = c.Int(nullable: false, identity: true),
                        UserID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.PaymentMethodID)
                .ForeignKey("dbo.User", t => t.UserID, cascadeDelete: true)
                .Index(t => t.UserID);
            
            CreateTable(
                "dbo.Phone",
                c => new
                    {
                        PhoneID = c.Int(nullable: false, identity: true),
                        UserID = c.Int(nullable: false),
                        PhoneNumber = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.PhoneID)
                .ForeignKey("dbo.User", t => t.UserID, cascadeDelete: true)
                .Index(t => t.UserID);
            
            CreateTable(
                "dbo.Spot",
                c => new
                    {
                        SpotID = c.Int(nullable: false, identity: true),
                        ParkingLotID = c.Int(nullable: false),
                        CurrentUserID = c.Int(nullable: false),
                        Floor_Number = c.Int(nullable: false),
                        Row_Number = c.Int(nullable: false),
                        IsHandicap = c.Boolean(nullable: false),
                        User_UserID = c.Int(),
                    })
                .PrimaryKey(t => t.SpotID)
                .ForeignKey("dbo.ParkingLot", t => t.ParkingLotID, cascadeDelete: true)
                .ForeignKey("dbo.User", t => t.User_UserID)
                .Index(t => t.ParkingLotID)
                .Index(t => t.User_UserID);
            
            CreateTable(
                "dbo.ParkingLot",
                c => new
                    {
                        ParkingLotID = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.ParkingLotID);
            
            CreateTable(
                "dbo.UserParkingLot",
                c => new
                    {
                        UserParkingLotsID = c.Int(nullable: false, identity: true),
                        UserID = c.Int(nullable: false),
                        ParkingLotID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.UserParkingLotsID)
                .ForeignKey("dbo.ParkingLot", t => t.ParkingLotID, cascadeDelete: true)
                .ForeignKey("dbo.User", t => t.UserID, cascadeDelete: true)
                .Index(t => t.UserID)
                .Index(t => t.ParkingLotID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UserDiscount", "UserID", "dbo.User");
            DropForeignKey("dbo.Spot", "User_UserID", "dbo.User");
            DropForeignKey("dbo.UserParkingLot", "UserID", "dbo.User");
            DropForeignKey("dbo.UserParkingLot", "ParkingLotID", "dbo.ParkingLot");
            DropForeignKey("dbo.Spot", "ParkingLotID", "dbo.ParkingLot");
            DropForeignKey("dbo.Phone", "UserID", "dbo.User");
            DropForeignKey("dbo.PaymentMethod", "UserID", "dbo.User");
            DropForeignKey("dbo.UserDiscount", "DiscountID", "dbo.Discount");
            DropIndex("dbo.UserParkingLot", new[] { "ParkingLotID" });
            DropIndex("dbo.UserParkingLot", new[] { "UserID" });
            DropIndex("dbo.Spot", new[] { "User_UserID" });
            DropIndex("dbo.Spot", new[] { "ParkingLotID" });
            DropIndex("dbo.Phone", new[] { "UserID" });
            DropIndex("dbo.PaymentMethod", new[] { "UserID" });
            DropIndex("dbo.UserDiscount", new[] { "DiscountID" });
            DropIndex("dbo.UserDiscount", new[] { "UserID" });
            DropTable("dbo.UserParkingLot");
            DropTable("dbo.ParkingLot");
            DropTable("dbo.Spot");
            DropTable("dbo.Phone");
            DropTable("dbo.PaymentMethod");
            DropTable("dbo.User");
            DropTable("dbo.UserDiscount");
            DropTable("dbo.Discount");
        }
    }
}
