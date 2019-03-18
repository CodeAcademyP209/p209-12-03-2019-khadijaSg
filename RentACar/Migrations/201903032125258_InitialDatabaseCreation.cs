namespace RentACar.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialDatabaseCreation : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cars",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CarBrand = c.String(nullable: false, maxLength: 100),
                        CarModel = c.String(nullable: false, maxLength: 100),
                        CarYear = c.String(nullable: false, maxLength: 100),
                        EngineVolume = c.String(nullable: false, maxLength: 100),
                        HorsePower = c.String(nullable: false, maxLength: 100),
                        TypeOfEngine = c.String(nullable: false, maxLength: 100),
                        MilageVolume = c.String(nullable: false, maxLength: 100),
                        Image = c.String(maxLength: 300),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Cars");
        }
    }
}
