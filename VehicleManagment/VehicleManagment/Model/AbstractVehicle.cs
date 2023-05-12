using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace VehicleManagment.Model
{
    public abstract class AbstractVehicle
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int VehicleId { get; protected set; }
        public string VehicleType { get; set; }
        public string Brand { get;set; }
        public string Model { get;set; }
        public FuelTypes FuelType{ get; set; }
        public TransmissionType TransmissionType { get; set; }    
        public Colors Color { get; set; }
        public int LaunchYear { get; set; }
        public double BasePrice { get; set; }

        public override string ToString()
        {
            return $"{{\n\t\"VehicleId\": {VehicleId},\n\t\"Brand\": \"{Brand}\",\n\t\"Model\": \"{Model}\",\n\t\"LaunchYear\": {LaunchYear},\n\t\"BasePrice\": {BasePrice}";
        }
    }
}
