using System;
using System.Collections.Generic;
using System.Text;
using VehicleManagment.Model;

namespace VehicleManagment.Factory
{
    public class VehicleDbFactory
    {
        private static VehicleContext vehicleContext;
        static VehicleDbFactory()
        {
            vehicleContext = new VehicleContext();
        }
        public static VehicleContext GetVehicleDbConnection()
        {
            if (vehicleContext == null)
            {
                vehicleContext = new VehicleContext();
                return vehicleContext; ;
            }
            return vehicleContext;
        }
    }
}
