using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleManagment.Model
{
    public class Vehicle:AbstractVehicle
    {
        public Vehicle()
        {
            IsAccidental = false;
            IsInSrvice = false;
        }
        public string Number { get; set; }
        public string OwnerName { get; set; }
        public bool IsAccidental { get; set; }
        public bool IsInSrvice { get; set; }
        public DateTime SellingDate { get; set; }
        public DateTime ExpiryDate
        {
            get { return SellingDate.AddYears(15); }
        }
        public string Notes { get; set; }
        public double Discount { get; set; }
        public List<ServiceHistory> Histories { get; set; }

        public override string ToString()
        {
            return base.ToString()+ $"\n\t\"VehicleNumber\": {Number},\n\t\"Color\": {base.Color.ToString()},\n\t\"OwnerName\": \"{OwnerName}\",\n\t\"SellingDate\": \"{SellingDate}\",\n\t\"ExpireDate\": \"{ExpiryDate}\"\n}}"
;
        }
    }
}
