using System;
using System.Collections.Generic;
using System.Text;
using VehicleManagment.Model;
using VehicleManagment.CustomException;
using System.Linq;

namespace VehicleManagment.Service
{
    public static class VehicleExtensions
    {
        public static IEnumerable<Vehicle> GetAllVehicleByBrand(this IQueryable<Vehicle> vehicles, string brand)
        {
            var result = vehicles.Where(v => v.Brand == brand);
            if (result.Any())
                return result;
            throw new RecordsNotFoundException("No records were found with this brand.");
        }
        public static IEnumerable<Vehicle> GetAllVehicleByColor(this IQueryable<Vehicle> vehicles, Colors? color)
        {
            var result = vehicles.Where(v => v.Color == color);
            if (result.Any())
                return result;
            throw new RecordsNotFoundException("No records were found with this " + color.ToString() + " color.");
        }

        public static IEnumerable<Vehicle> GetAllVehicleByAccidentalStatus(this IQueryable<Vehicle> vehicles, bool status)
        {
            var result = vehicles.Where(v => v.IsAccidental == status);
            if (result.Any())
                return result;
            throw new RecordsNotFoundException("No records were found.");
        }

        public static IEnumerable<Vehicle> GetAllVehicleByTransmissionType(this IQueryable<Vehicle> vehicles, TransmissionType? transmissionType)
        {
            var result = vehicles.Where(v => v.TransmissionType == transmissionType);
            if (result.Any())
                return result;
            throw new RecordsNotFoundException("No records were found with this " + transmissionType.ToString() + " transmission type.");
        }
    }

}
