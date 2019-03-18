using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using RentACar.Models;

namespace RentACar.DAL
{
    public class CarContext : DbContext
    {
        public CarContext() : base("CarContext")
        {
        }

        public DbSet<Car> Cars  { get; set; }

    }
}