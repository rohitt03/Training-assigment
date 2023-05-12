using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace VehicleManagment.Model
{
    public class VehicleContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=WSAMZN-BN2QIPRD\SQLEXPRESS;Database=VehicleManagmentDatabase;Trusted_Connection=True;");
        }
        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<ServiceHistory> ServiceHistories { get; set; }
    }
}
