using System;
using System.Collections.Generic;
using System.Text;
using VehicleManagment.Factory;
using VehicleManagment.Model;
using System.Linq;
using VehicleManagment.CustomException;
using System.Linq.Expressions;

namespace VehicleManagment.Service
{
    class VehicleService
    {
        private readonly VehicleContext _vehicleContext;
        public VehicleService()
        {
            _vehicleContext = VehicleDbFactory.GetVehicleDbConnection();
        }
        public bool AddVehicle(Vehicle vehicle)
        {
            _vehicleContext.Vehicles.Add(vehicle);
            if (_vehicleContext.SaveChanges() > 0)
                return true;
            throw new DatabaseException("Internal server issue try after some time");

        }
       
        public bool AddvehicleToServicing(ServiceHistory serviceHistory)
        {
            _vehicleContext.ServiceHistories.Add(serviceHistory);
            if (_vehicleContext.SaveChanges() > 0)
                return true;
            throw new DatabaseException("Internal server issue try after some time");
        }

        public void ModifyServiceStatus(bool status,int vehicleId)
        {
            GetVehicleById(vehicleId).IsInSrvice=status;
        }
        public IEnumerable<ServiceHistory> GetServiceDetailById(int vehicleId)
        {
          IEnumerable<ServiceHistory> Services=_vehicleContext.ServiceHistories.Where(temp => temp.Vehicles.VehicleId == vehicleId);
            if (Services.Any())
                return Services;
            throw new RecordsNotFoundException("No service history Exist for this vehicle");
        }
       
        public Vehicle GetVehicleById(int vehicleId)
        {
            Vehicle vehicle = _vehicleContext.Vehicles.Find(vehicleId);
            if (vehicle == null)
                throw new VehicleNotFoundException("Vehicle not found please enter existing ID");
            return vehicle;
        }
        public IEnumerable<Vehicle> GetallVehicle()
        {       
            var vehicles = _vehicleContext.Vehicles;
            if (vehicles.Any())
                return vehicles;
            throw new RecordsNotFoundException("No records were found.");
        }
        public IEnumerable<Vehicle> GetallVehicleByBrand(string brand)
        {
            return _vehicleContext.Vehicles.GetAllVehicleByBrand(brand);
        }
        public IEnumerable<Vehicle> GetallVehicleByColor(Colors? color)
        {
            return _vehicleContext.Vehicles.GetAllVehicleByColor(color);
        }
        public IEnumerable<Vehicle> GetallVehicleByAccidentalStatus(bool status)
        {
            return _vehicleContext.Vehicles.GetAllVehicleByAccidentalStatus(status);
        }
        public IEnumerable<Vehicle> GetallVehicleByTransmissionType(TransmissionType? transmissionType)
        {
            return _vehicleContext.Vehicles.GetAllVehicleByTransmissionType(transmissionType);  
        }

        public T GetRecordById<T>(int id) where T : Vehicle
        {
            T record = _vehicleContext.Find<T>(id);
            if (record == null)
                throw new RecordsNotFoundException($"Record with ID {id} not found.");
            return record;
        }

        /*   public void AddVehicle()
          {
              List<Vehicle> li = new List<Vehicle>();
              li.Add(new Vehicle { VehicleType = "Car", Brand = "Tata", Model = "Nexon", FuelType = FuelTypes.ELECTRIC, TransmissionType = TransmissionType.AUTOMATIC, Color = Colors.WHITE, LaunchYear = 2014, BasePrice = 1450000, Number = "MH-08-AL-9876", OwnerName = "Mayur padade", SellingDate = new DateTime(2016, 12, 1), Notes = "The Tata Nexon is a subcompact crossover SUV produced by the Indian automaker Tata Motors since 2017. It is the first crossover SUV from the brand, and occupies the sub-4 metre crossover SUV segment in India", Discount = 25000 });
              li.Add(new Vehicle { VehicleType = "Car", Brand = "Tata", Model = "Tiago", FuelType = FuelTypes.PETROL, TransmissionType = TransmissionType.MANUAL, Color = Colors.RED, LaunchYear = 2016, BasePrice = 600000, Number = "MH-08-BB-1234", OwnerName = "Amit Sharma", SellingDate = new DateTime(2017, 6, 15), Notes = "The Tata Tiago is a hatchback produced by Tata Motors since 2016. It has won several awards for its design and features.", Discount = 10000 });

              li.Add(new Vehicle { VehicleType = "Motorcycle", Brand = "Tata", Model = "JTP", FuelType = FuelTypes.PETROL, TransmissionType = TransmissionType.MANUAL, Color = Colors.BLACK, LaunchYear = 2018, BasePrice = 110000, Number = "MH-08-CC-5678", OwnerName = "Rahul Desai", SellingDate = new DateTime(2019, 1, 12), Notes = "The Tata JTP is a sporty motorcycle produced by Tata Motors since 2018. It has a powerful engine and is known for its performance.", Discount = 5000 });

              li.Add(new Vehicle { VehicleType = "Truck", Brand = "Tata", Model = "Ultra", FuelType = FuelTypes.DIESEL, TransmissionType = TransmissionType.MANUAL, Color = Colors.BLUE, LaunchYear = 2019, BasePrice = 2200000, Number = "MH-08-DD-9012", OwnerName = "Sujata Patel", SellingDate = new DateTime(2020, 2, 20), Notes = "The Tata Ultra is a heavy-duty truck produced by Tata Motors since 2019. It is designed for carrying heavy loads and is known for its durability and reliability.", Discount = 80000 });

              li.Add(new Vehicle { VehicleType = "Van", Brand = "Tata", Model = "Winger", FuelType = FuelTypes.DIESEL, TransmissionType = TransmissionType.MANUAL, Color = Colors.WHITE, LaunchYear = 2007, BasePrice = 1200000, Number = "MH-08-EE-3456", OwnerName = "Ravi Gupta", SellingDate = new DateTime(2008, 3, 10), Notes = "The Tata Winger is a multi-purpose van produced by Tata Motors since 2007. It is used for both passenger and cargo transportation and is known for its versatility and comfort.", Discount = 40000 });
              li.Add(new Vehicle { VehicleType = "Car", Brand = "Honda", Model = "Civic", FuelType = FuelTypes.PETROL, TransmissionType = TransmissionType.MANUAL, Color = Colors.SILVER, LaunchYear = 2006, BasePrice = 1200000, Number = "MH-12-AB-1234", OwnerName = "Rajesh Kumar", SellingDate = new DateTime(2007, 5, 15), Notes = "The Honda Civic is a popular sedan produced by Honda since 1972. It is known for its reliability, performance, and fuel efficiency.", Discount = 50000 });

              li.Add(new Vehicle { VehicleType = "Motorcycle", Brand = "Honda", Model = "CBR 150R", FuelType = FuelTypes.PETROL, TransmissionType = TransmissionType.MANUAL, Color = Colors.RED, LaunchYear = 2018, BasePrice = 130000, Number = "MH-12-CD-5678", OwnerName = "Rakesh Singh", SellingDate = new DateTime(2019, 3, 12), Notes = "The Honda CBR 150R is a sports bike produced by Honda since 2002. It has a powerful engine and is known for its handling and speed.", Discount = 8000 });

              li.Add(new Vehicle { VehicleType = "Truck", Brand = "Honda", Model = "Acty", FuelType = FuelTypes.DIESEL, TransmissionType = TransmissionType.MANUAL, Color = Colors.BLUE, LaunchYear = 1977, BasePrice = 1800000, Number = "MH-12-EF-9012", OwnerName = "Suresh Patil", SellingDate = new DateTime(1978, 9, 20), Notes = "The Honda Acty is a microvan produced by Honda since 1977. It is known for its fuel efficiency and versatility.", Discount = 60000 });

              li.Add(new Vehicle { VehicleType = "Van", Brand = "Honda", Model = "Odyssey", FuelType = FuelTypes.PETROL, TransmissionType = TransmissionType.AUTOMATIC, Color = Colors.WHITE, LaunchYear = 1994, BasePrice = 2500000, Number = "MH-12-GH-3456", OwnerName = "Anita Sharma", SellingDate = new DateTime(1995, 12, 10), Notes = "The Honda Odyssey is a minivan produced by Honda since 1994. It is known for its spacious and comfortable interior, as well as its reliability and safety features.", Discount = 100000 });
              li.Add(new Vehicle { VehicleType = "Car", Brand = "Maruti Suzuki", Model = "Swift", FuelType = FuelTypes.PETROL, TransmissionType = TransmissionType.MANUAL, Color = Colors.RED, LaunchYear = 2005, BasePrice = 700000, Number = "MH-01-AB-1234", OwnerName = "Rajesh Kumar", SellingDate = new DateTime(2006, 3, 15), Notes = "The Maruti Suzuki Swift is a popular hatchback produced by Maruti Suzuki since 2005. It is known for its sporty looks, fuel efficiency, and fun-to-drive character.", Discount = 25000 });

              li.Add(new Vehicle { VehicleType = "Motorcycle", Brand = "Maruti Suzuki", Model = "Intruder", FuelType = FuelTypes.PETROL, TransmissionType = TransmissionType.MANUAL, Color = Colors.BLACK, LaunchYear = 2017, BasePrice = 120000, Number = "MH-01-CD-5678", OwnerName = "Rakesh Singh", SellingDate = new DateTime(2018, 5, 12), Notes = "The Maruti Suzuki Intruder is a cruiser motorcycle produced by Maruti Suzuki since 2017. It has a powerful engine and is known for its comfortable ride and stylish looks.", Discount = 8000 });

              li.Add(new Vehicle { VehicleType = "Truck", Brand = "Maruti Suzuki", Model = "Super Carry", FuelType = FuelTypes.DIESEL, TransmissionType = TransmissionType.MANUAL, Color = Colors.WHITE, LaunchYear = 2016, BasePrice = 550000, Number = "MH-01-EF-9012", OwnerName = "Suresh Patil", SellingDate = new DateTime(2017, 9, 20), Notes = "The Maruti Suzuki Super Carry is a compact pickup truck produced by Maruti Suzuki since 2016. It is known for its practicality, fuel efficiency, and low maintenance costs.", Discount = 25000 });

              li.Add(new Vehicle { VehicleType = "Van", Brand = "Maruti Suzuki", Model = "Eeco", FuelType = FuelTypes.PETROL, TransmissionType = TransmissionType.MANUAL, Color = Colors.SILVER, LaunchYear = 2010, BasePrice = 400000, Number = "MH-01-GH-3456", OwnerName = "Anita Sharma", SellingDate = new DateTime(2011, 12, 10), Notes = "The Maruti Suzuki Eeco is a budget van produced by Maruti Suzuki since 2010. It is known for its spacious interior, fuel efficiency, and low maintenance costs.", Discount = 15000 });
              li.Add(new Vehicle { VehicleType = "Car", Brand = "Mahindra & Mahindra", Model = "XUV500", FuelType = FuelTypes.DIESEL, TransmissionType = TransmissionType.AUTOMATIC, Color = Colors.BLACK, LaunchYear = 2011, BasePrice = 1200000, Number = "MH-02-AB-1234", OwnerName = "Rajesh Kumar", SellingDate = new DateTime(2012, 4, 25), Notes = "The Mahindra XUV500 is a popular SUV produced by Mahindra & Mahindra since 2011. It is known for its spacious interior, comfortable ride, and off-road capability.", Discount = 50000 });

              li.Add(new Vehicle { VehicleType = "Motorcycle", Brand = "Mahindra & Mahindra", Model = "Centuro", FuelType = FuelTypes.PETROL, TransmissionType = TransmissionType.MANUAL, Color = Colors.RED, LaunchYear = 2013, BasePrice = 55000, Number = "MH-02-CD-5678", OwnerName = "Rakesh Singh", SellingDate = new DateTime(2014, 7, 18), Notes = "The Mahindra Centuro is a commuter motorcycle produced by Mahindra & Mahindra since 2013. It is known for its fuel efficiency, low maintenance costs, and features like anti-theft alarm and find-me lamps.", Discount = 5000 });

              li.Add(new Vehicle { VehicleType = "Truck", Brand = "Mahindra & Mahindra", Model = "Bolero Pickup", FuelType = FuelTypes.DIESEL, TransmissionType = TransmissionType.MANUAL, Color = Colors.WHITE, LaunchYear = 2007, BasePrice = 600000, Number = "MH-02-EF-9012", OwnerName = "Suresh Patil", SellingDate = new DateTime(2008, 10, 5), Notes = "The Mahindra Bolero Pickup is a popular pickup truck produced by Mahindra & Mahindra since 2007. It is known for its ruggedness, low maintenance costs, and ability to carry heavy loads.", Discount = 25000 });

              li.Add(new Vehicle { VehicleType = "Van", Brand = "Mahindra & Mahindra", Model = "Supro", FuelType = FuelTypes.DIESEL, TransmissionType = TransmissionType.MANUAL, Color = Colors.SILVER, LaunchYear = 2015, BasePrice = 550000, Number = "MH-02-GH-3456", OwnerName = "Anita Sharma", SellingDate = new DateTime(2016, 12, 1), Notes = "The Mahindra Supro is a compact van produced by Mahindra & Mahindra since 2015. It is known for its fuel efficiency, low maintenance costs, and spacious interior.", Discount = 15000 });
              li.Add(new Vehicle { VehicleType = "Car", Brand = "Hyundai", Model = "i20", FuelType = FuelTypes.PETROL, TransmissionType = TransmissionType.MANUAL, Color = Colors.BLUE, LaunchYear = 2008, BasePrice = 700000, Number = "MH-12-AB-1234", OwnerName = "Amit Singh", SellingDate = new DateTime(2009, 5, 15), Notes = "The Hyundai i20 is a premium hatchback produced by the South Korean automaker Hyundai since 2008. It is known for its stylish design, spacious interior, and good ride quality.", Discount = 25000 });

              li.Add(new Vehicle { VehicleType = "Motorcycle", Brand = "Hyundai", Model = "Venue", FuelType = FuelTypes.PETROL, TransmissionType = TransmissionType.MANUAL, Color = Colors.BLACK, LaunchYear = 2019, BasePrice = 75000, Number = "MH-12-CD-5678", OwnerName = "Rahul Patil", SellingDate = new DateTime(2020, 3, 7), Notes = "The Hyundai Venue is a compact crossover SUV produced by Hyundai since 2019. It is known for its modern design, fuel efficiency, and value for money.", Discount = 5000 });

              li.Add(new Vehicle { VehicleType = "Truck", Brand = "Hyundai", Model = "Mighty", FuelType = FuelTypes.DIESEL, TransmissionType = TransmissionType.MANUAL, Color = Colors.WHITE, LaunchYear = 2004, BasePrice = 1200000, Number = "MH-12-EF-9012", OwnerName = "Sandeep Gupta", SellingDate = new DateTime(2005, 8, 25), Notes = "The Hyundai Mighty is a medium-duty truck produced by Hyundai since 2004. It is known for its durability, reliability, and low maintenance costs.", Discount = 50000 });

              li.Add(new Vehicle { VehicleType = "Van", Brand = "Hyundai", Model = "Starex", FuelType = FuelTypes.DIESEL, TransmissionType = TransmissionType.AUTOMATIC, Color = Colors.SILVER, LaunchYear = 1997, BasePrice = 2000000, Number = "MH-12-GH-3456", OwnerName = "Priya Shah", SellingDate = new DateTime(1998, 11, 11), Notes = "The Hyundai Starex is a popular van produced by Hyundai since 1997. It is known for its spacious interior, comfort, and versatility.", Discount = 100000 });


              li.Add(new Vehicle { VehicleType = "Car", Brand = "Honda", Model = "Civic", FuelType = FuelTypes.PETROL, TransmissionType = TransmissionType.AUTOMATIC, Color = Colors.RED, LaunchYear = 2005, BasePrice = 1000000, Number = "MH-08-BC-1234", OwnerName = "Rajesh Sharma", SellingDate = new DateTime(2006, 9, 3), Notes = "The Honda Civic is a compact car produced by Honda since 1972. It is known for its sporty design, fuel efficiency, and reliability.", Discount = 50000 });

              li.Add(new Vehicle { VehicleType = "Truck", Brand = "Mahindra & Mahindra", Model = "Bolero", FuelType = FuelTypes.DIESEL, TransmissionType = TransmissionType.MANUAL, Color = Colors.WHITE, LaunchYear = 2000, BasePrice = 800000, Number = "MH-12-DE-5678", OwnerName = "Aniket Singh", SellingDate = new DateTime(2001, 4, 20), Notes = "The Mahindra Bolero is a popular pickup truck produced by Mahindra & Mahindra since 2000. It is known for its rugged design, powerful engine, and versatility.", Discount = 40000 });

              li.Add(new Vehicle { VehicleType = "Van", Brand = "Hyundai", Model = "H1", FuelType = FuelTypes.DIESEL, TransmissionType = TransmissionType.AUTOMATIC, Color = Colors.GRAY, LaunchYear = 1997, BasePrice = 1500000, Number = "MH-12-FG-9012", OwnerName = "Anita Mehta", SellingDate = new DateTime(1998, 7, 16), Notes = "The Hyundai H1 is a popular van produced by Hyundai since 1997. It is known for its spacious interior, comfort, and versatility.", Discount = 75000 });

              li.Add(new Vehicle { VehicleType = "Car", Brand = "Maruti Suzuki", Model = "Swift", FuelType = FuelTypes.PETROL, TransmissionType = TransmissionType.MANUAL, Color = Colors.BLUE, LaunchYear = 2005, BasePrice = 600000, Number = "MH-08-HI-3456", OwnerName = "Ravi Kumar", SellingDate = new DateTime(2006, 2, 11), Notes = "The Maruti Suzuki Swift is a popular hatchback produced by Maruti Suzuki since 2005. It is known for its stylish design, fuel efficiency, and affordability.", Discount = 30000 });

              li.Add(new Vehicle { VehicleType = "Motorcycle", Brand = "Honda", Model = "CBR", FuelType = FuelTypes.PETROL, TransmissionType = TransmissionType.MANUAL, Color = Colors.BLACK, LaunchYear = 2004, BasePrice = 150000, Number = "MH-12-IJ-7890", OwnerName = "Manish Patel", SellingDate = new DateTime(2005, 10, 2), Notes = "The Honda CBR is a popular sports bike produced by Honda since 1987. It is known for its speed, agility, and performance.", Discount = 10000 });
              li.Add(new Vehicle { VehicleType = "Car", Brand = "Hyundai", Model = "Verna", FuelType = FuelTypes.DIESEL, TransmissionType = TransmissionType.AUTOMATIC, Color = Colors.SILVER, LaunchYear = 2006, BasePrice = 1200000, Number = "MH-12-LM-5678", OwnerName = "Priya Shah", SellingDate = new DateTime(2007, 5, 20), Notes = "The Hyundai Verna is a popular sedan produced by Hyundai since 2006. It is known for its stylish design, comfort, and performance.", Discount = 60000 });

              li.Add(new Vehicle { VehicleType = "Van", Brand = "Maruti Suzuki", Model = "Eeco", FuelType = FuelTypes.ELECTRIC, TransmissionType = TransmissionType.MANUAL, Color = Colors.YELLOW, LaunchYear = 2010, BasePrice = 700000, Number = "MH-08-NO-9012", OwnerName = "Sudhir Singh", SellingDate = new DateTime(2011, 8, 12), Notes = "The Maruti Suzuki Eeco is a popular van produced by Maruti Suzuki since 2010. It is known for its spacious interior, fuel efficiency, and affordability.", Discount = 35000 });

              li.Add(new Vehicle { VehicleType = "Motorcycle", Brand = "Mahindra & Mahindra", Model = "Gusto", FuelType = FuelTypes.PETROL, TransmissionType = TransmissionType.MANUAL, Color = Colors.RED, LaunchYear = 2014, BasePrice = 60000, Number = "MH-12-PQ-3456", OwnerName = "Shashi Singh", SellingDate = new DateTime(2015, 3, 1), Notes = "The Mahindra Gusto is a popular scooter produced by Mahindra & Mahindra since 2014. It is known for its comfortable ride, fuel efficiency, and affordability.", Discount = 3000 });

              li.Add(new Vehicle { VehicleType = "Truck", Brand = "Honda", Model = "Ridgeline", FuelType = FuelTypes.PETROL, TransmissionType = TransmissionType.AUTOMATIC, Color = Colors.BLACK, LaunchYear = 2005, BasePrice = 2000000, Number = "MH-08-RS-6789", OwnerName = "Alok Patel", SellingDate = new DateTime(2006, 11, 18), Notes = "The Honda Ridgeline is a popular pickup truck produced by Honda since 2005. It is known for its spacious interior, powerful engine, and reliability.", Discount = 100000 });
              li.Add(new Vehicle { VehicleType = "Car",Brand = "Hyundai",Model = "Creta",FuelType = FuelTypes.DIESEL,TransmissionType = TransmissionType.AUTOMATIC,Color = Colors.WHITE,LaunchYear = 2015,BasePrice = 1300000,Number = "MH-12-TU-1234",OwnerName = "Neha Deshmukh",SellingDate = new DateTime(2016, 7, 22),Notes = "The Hyundai Creta is a popular compact SUV produced by Hyundai since 2015. It is known for its stylish design, spacious interior, and advanced features.",Discount = 65000});
              li.Add(new Vehicle { VehicleType = "Van", Brand = "Maruti Suzuki", Model = "Omni", FuelType = FuelTypes.PETROL, TransmissionType = TransmissionType.MANUAL, Color = Colors.GREEN, LaunchYear = 1984, BasePrice = 500000, Number = "MH-08-VW-5678", OwnerName = "Rajesh Kulkarni", SellingDate = new DateTime(1985, 12, 1), Notes = "The Maruti Suzuki Omni is a popular van produced by Maruti Suzuki since 1984. It is known for its simplicity, practicality, and affordability.", Discount = 25000 });

              li.Add(new Vehicle { VehicleType = "Motorcycle", Brand = "Honda", Model = "CBR 1000RR", FuelType = FuelTypes.PETROL, TransmissionType = TransmissionType.MANUAL, Color = Colors.BLUE, LaunchYear = 2004, BasePrice = 1500000, Number = "MH-12-XY-9012", OwnerName = "Akash Patel", SellingDate = new DateTime(2005, 9, 15), Notes = "The Honda CBR 1000RR is a popular sports bike produced by Honda since 2004. It is known for its high performance, sleek design, and advanced features.", Discount = 75000 });

              li.Add(new Vehicle { VehicleType = "Truck", Brand = "Mahindra & Mahindra", Model = "Bolero Pickup", FuelType = FuelTypes.DIESEL, TransmissionType = TransmissionType.MANUAL, Color = Colors.SILVER, LaunchYear = 2001, BasePrice = 900000, Number = "MH-08-ZA-3456", OwnerName = "Ganesh Kadam", SellingDate = new DateTime(2002, 3, 10), Notes = "The Mahindra Bolero Pickup is a popular pickup truck produced by Mahindra & Mahindra since 2001. It is known for its rugged design, powerful engine, and durability.", Discount = 45000 });

              li.Add(new Vehicle { VehicleType = "Car", Brand = "Hyundai", Model = "Santro", FuelType = FuelTypes.CNG, TransmissionType = TransmissionType.MANUAL, Color = Colors.RED, LaunchYear = 1998, BasePrice = 600000, Number = "MH-12-BC-7890", OwnerName = "Rahul Singh", SellingDate = new DateTime(1999, 5, 5), Notes = "The Hyundai Santro is a popular hatchback produced by Hyundai since 1998. It is known for its compact size, fuel efficiency, and affordability.", Discount = 30000 });

              foreach(var vehicle in li)
              {
                  _vehicleContext.Add(vehicle);
                  _vehicleContext.SaveChanges();
              }
          }*/

    }
}
