using System;
using System.Collections.Generic;
using System.Text;
using VehicleManagment.Service;
namespace VehicleManagment.Factory
{
    class VehicleServiceFactory
    {
        public static VehicleService GetVehicleService()
        {
            return new VehicleService();
        }
    }
}
