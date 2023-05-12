using System;
using System.Collections.Generic;
using System.Text;
using VehicleManagment.Service;
namespace VehicleManagment.Factory
{
    class VehicleInformationPortalFactory
    {
        public static VehicleInformationPortalService GetVehicleInformationPortalService()
        {
            return new VehicleInformationPortalService();
        }
    }
}
