namespace RentACar.Migrations
{
    using RentACar.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<RentACar.DAL.CarContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(RentACar.DAL.CarContext context)
        {
            context.Cars.AddOrUpdate(x => new { x.CarBrand, x.CarModel },
                new Car() { Id = 1, CarBrand = "Lamborghini", CarModel = "Huracan Evo Spyder", CarYear = "2018", EngineVolume = "6.5 L", HorsePower = "640 CV (470 kW)", TypeOfEngine = "Premium Gasoline", MilageVolume = "7.7 gals/100 miles", Image = "LamboEvoSpyder.jpg" },
                new Car() { Id = 2, CarBrand = "BMW", CarModel = "bmv i8", CarYear = "2019", EngineVolume = "96 kW (131 PS; 129 hp) and 250 N⋅m (184 lb⋅ft)", HorsePower = "369", TypeOfEngine = "Electric", MilageVolume = "a turbocharged 1.5-liter 3-cylinder gasoline engine", Image = "BmwI8.jpg" },
                new Car() { Id = 3, CarBrand = "Ferrari", CarModel = "458 Spider", CarYear = "2011", EngineVolume = "4.5 L", HorsePower = "789", TypeOfEngine = "Fuel", MilageVolume = "5.5 kmpl", Image = "Ferrari.jpg" }
                );
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
