using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace VehicleManagment.Model
{
    public class ServiceHistory
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ServiceId { get; set; }
        public DateTime ServiceDate { get; set; }
        public string ServiceType { get; set; }
        public decimal ServiceCost { get; set; }
        public Vehicle Vehicles { get; set; }
        public override string ToString()
        {
            return $"{{\n\t\"ServiceId\": {ServiceId},\n\t\"ServiceDate\": \"{ServiceDate}\",\n\t\"ServiceType\": \"{ServiceType}\",\n\t\"ServiceCost\": {ServiceCost}\n}}"; 
        }


    }
}
