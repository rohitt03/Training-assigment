using System;
using System.Collections.Generic;
using System.Text;
using VehicleManagment.Factory;
using VehicleManagment.Model;
using VehicleManagment.CustomException;

namespace VehicleManagment.Service
{
    class VehicleInformationPortalService
    {
        private readonly VehicleService _vehicleService;
        public VehicleInformationPortalService()
        {
            _vehicleService = VehicleServiceFactory.GetVehicleService();
        }
        public void DisplayMenu()
        {
            Console.WriteLine("\n\n------------MENU---------------------------");
            Console.WriteLine("\n1: Add a vehicle");
            Console.WriteLine("2: Get information about a particular vehicle");    
            Console.WriteLine("3: Display servicing history");
            Console.WriteLine("4: Add a vehicle to servicing");
            Console.WriteLine("5: Display all vehicles");
            Console.WriteLine("Press any from above option");
            Console.WriteLine("100: Exit");
        }
        public void AddVehicle()
        {
            Vehicle vehicle = new Vehicle();
            Console.WriteLine("Please enter the following information:");
            Console.WriteLine("-Enter VehicleType (Car,Truck,Van,Motorcycle)");
            vehicle.VehicleType=  Console.ReadLine();
            Console.WriteLine("-Enter Brand");
            vehicle.Brand = Console.ReadLine();                     
            Console.WriteLine("-Enter Model");
            vehicle.Model = Console.ReadLine();
            Console.WriteLine("-Enter FuelType choose ");
            Console.WriteLine("\n1: Petrol");
            Console.WriteLine("2:  Diesel");
            Console.WriteLine("3: Electric");
            Console.WriteLine("4: CNG");
            int fuelchoice;
            int.TryParse(Console.ReadLine(),out fuelchoice);

            switch (fuelchoice)
            {
                case 1:
                    vehicle.FuelType = FuelTypes.PETROL;
                    break;
                case 2:
                    vehicle.FuelType = FuelTypes.DIESEL;
                    break;
                case 3:
                    vehicle.FuelType = FuelTypes.ELECTRIC;
                    break;
                case 4:
                    vehicle.FuelType = FuelTypes.CNG;
                    break;
                default:
                    throw new FuelTypeException("Fuel type not exist enter valid fuel type");

            }

            Console.WriteLine("Choose color from below option");
            Console.WriteLine("\n1: BLACK");
            Console.WriteLine("2: GRAY");
            Console.WriteLine("3: GREEN");
            Console.WriteLine("4: RED");
            Console.WriteLine("5: SILVER");
            Console.WriteLine("6: WHITE");
            Console.WriteLine("7: YELLOW");
            Console.WriteLine("8: Blue");
            int colorchoice;
            int.TryParse(Console.ReadLine(), out colorchoice);

            switch (colorchoice)
            {
                case 1:
                    vehicle.Color = Colors.BLACK;
                    break;  
                case 2:
                    vehicle.Color = Colors.GRAY;
                    break;  
                case 3:
                    vehicle.Color = Colors.GREEN;
                    break; 
                case 4:
                    vehicle.Color = Colors.RED;
                    break;
                case 5:
                    vehicle.Color = Colors.SILVER;
                    break;
                case 6:
                    vehicle.Color = Colors.WHITE;
                    break;
                case 7:
                    vehicle.Color = Colors.YELLOW;
                    break;
                case 8:
                    vehicle.Color = Colors.BLUE;
                    break;
                default:
                    throw new ColorNotfoundException("Color not exist choose color from otion only");

            }

            Console.WriteLine("-Enter TransmissionType (choose from: Manual, Automatic)");
            Console.WriteLine("\n1: Manual");
            Console.WriteLine("2:  Automatic");
            int transmissionchoice;
            int.TryParse(Console.ReadLine(), out transmissionchoice);

            switch (transmissionchoice)
            {
                case 1:
                    vehicle.TransmissionType = TransmissionType.MANUAL;
                    break;
                case 2:
                    vehicle.TransmissionType= TransmissionType.AUTOMATIC;
                    break;
                default:
                    throw new TransmisionTypeNotFoundException("Transmission type not exist choose from option");
            }
            Console.WriteLine("-Enter LaunchYear");
            int tempLanchyear;
            int.TryParse(Console.ReadLine(),out tempLanchyear);
            if (tempLanchyear > 1995 && tempLanchyear > DateTime.Now.Year)
                throw new DateException("Year should be betwenn 1995 and" + DateTime.Now.Year);
            vehicle.LaunchYear = tempLanchyear;
            Console.WriteLine("-Enter BasePrice");
            double tempBasePrice;
            double.TryParse(Console.ReadLine(), out tempBasePrice);
            if (tempBasePrice < 100000)
                throw new FormatException("Base price should be number and should greater than one lakh");
            vehicle.BasePrice = tempBasePrice;
            Console.WriteLine("-Enter Number");
            vehicle.Number = Console.ReadLine();
            Console.WriteLine("-Enter OwnerName");
            vehicle.OwnerName = Console.ReadLine();
            vehicle.SellingDate = DateTime.Now;
            Console.WriteLine("-Enter Notes");
            vehicle.Notes = Console.ReadLine();
            Console.WriteLine("-Enter Discount (in decimal format)");
            double tempDiscountPrice;
            double.TryParse(Console.ReadLine(), out tempDiscountPrice);
            if (tempDiscountPrice == 0)
                throw new FormatException("discount price should be number and should greater than zero");
            vehicle.BasePrice = tempBasePrice;
            _vehicleService.AddVehicle(vehicle);
            Console.WriteLine("Vehicle added successfully");
            
        }
        public void GetVehicleSrviceHistory()
        {
            Console.WriteLine("Enter vehicle id");
            int vehicleId;
            int.TryParse(Console.ReadLine(), out vehicleId);
            if (vehicleId == 0)
                throw new VehicleNotFoundException("Invalid format of Id please enter whole non fractional number");

            Console.WriteLine(_vehicleService.GetVehicleById(vehicleId));     
            foreach (var vserviceHistory in  _vehicleService.GetServiceDetailById(vehicleId))
            {
                Console.WriteLine(vserviceHistory.ToString());
            }

        }
        public void AddVehicleSevice()
        {
            Console.WriteLine("Enter vehicle id");
            int vehicleId;
            int.TryParse(Console.ReadLine(), out vehicleId);
            if (vehicleId == 0)
                throw new VehicleNotFoundException("Invalid format of Id please enter whole non fractional number");
            ServiceHistory serviceHistory = new ServiceHistory();
            serviceHistory.Vehicles = _vehicleService.GetVehicleById(vehicleId);
            serviceHistory.Vehicles.IsInSrvice = true;

            serviceHistory.ServiceDate = DateTime.Now;

            Console.WriteLine("Enter Services : Oil/oil filter changed Wiper blades replacement Replace air filter Scheduled maintenance New tires Battery replacement Brake work");
            serviceHistory.ServiceType = Console.ReadLine();

            Console.WriteLine("Enter Service Cost:");
            decimal tempServiceCost;
            decimal.TryParse(Console.ReadLine(), out tempServiceCost);
            if (tempServiceCost == 0)
                throw new FormatException("Service cost should be in number and should greater than zero");
           serviceHistory.ServiceCost=tempServiceCost;
            _vehicleService.AddvehicleToServicing(serviceHistory);
            Console.WriteLine("Vehicle added in servicing successfully");

        }
        public void DisplayVehicle()
        {
            Console.WriteLine("Press any from above option from below");
            Console.WriteLine("\n1: Display all vehicle");
            Console.WriteLine("2: Filter vehicle by by Color");
            Console.WriteLine("3: Filter vehicle by by Transmission Type");
            Console.WriteLine("4: Filter vehicle by Brand");
            Console.WriteLine("5: Display all accidental vehicle");
            Console.WriteLine("6: Display all non accidental vehicle");
            int choice;
            int.TryParse(Console.ReadLine(),out choice);
            switch (choice)
            {
                case 1:
                    foreach(var vehicle in _vehicleService.GetallVehicle())
                    {
                        Console.WriteLine(vehicle.ToString());
                    }
                    
                    break;
                case 2: 
                    Console.WriteLine("Choose color from below option");
                    Console.WriteLine("\n1: BLACK");
                    Console.WriteLine("2: GRAY");
                    Console.WriteLine("3: GREEN"); 
                    Console.WriteLine("4: RED");
                    Console.WriteLine("5: SILVER");
                    Console.WriteLine("6: WHITE");
                    Console.WriteLine("7: YELLOW");
                    Console.WriteLine("8: Blue");
                    int colorchoice;
                    Colors? color=null;
                    Boolean status =true;
                    int.TryParse(Console.ReadLine(), out colorchoice);
                    switch (colorchoice)
                    {
                        case 1:
                            color=Colors.BLACK;
                            break;
                        case 2:
                            color = Colors.GRAY;
                            break;
                        case 3:
                            color = Colors.GREEN;
                            break;
                        case 4:
                            color = Colors.RED;
                            break;
                        case 5:
                            color = Colors.SILVER;
                            break;
                        case 6:
                            color = Colors.WHITE;
                            break;
                        case 7:
                            color = Colors.SILVER;
                            break;
                        case 8:
                            color = Colors.BLUE;
                            break;
                        default:
                            throw new ColorNotfoundException("You have chosen wrong color");
                    }
                    if (status)
                    {
                        foreach (var vehicle in _vehicleService.GetallVehicleByColor(color))
                        {
                            Console.WriteLine(vehicle.ToString());
                        }
                    }
                    break;
                case 3:
                    Console.WriteLine("Choose Transmission type from below option");
                    Console.WriteLine("\n1: Manual");
                    Console.WriteLine("2:Automatic");
                    int transmissionchoice;
                    TransmissionType? transmissionType = null;
                    Boolean trasmissionstatus = true;
                    int.TryParse(Console.ReadLine(), out colorchoice);
                    switch (colorchoice)
                    {
                        case 1:
                            transmissionType = TransmissionType.MANUAL;
                            break;
                        case 2:
                            transmissionType = TransmissionType.AUTOMATIC;
                            break;
                        default:
                            throw new ColorNotfoundException("You have chosen wrong color");
                            break;
                    }                  
                        foreach (var vehicle in _vehicleService.GetallVehicleByTransmissionType(transmissionType))
                        {
                            Console.WriteLine(vehicle.ToString());
                        }
                    

                    break;
                case 4:
                    Console.WriteLine("Enter Brand name");
                    string brand = Console.ReadLine();
                    foreach (var vehicle in _vehicleService.GetallVehicleByBrand(brand) )
                    {
                        Console.WriteLine(vehicle.ToString());
                    }
                    break;
                case 5:
                    foreach (var vehicle in _vehicleService.GetallVehicleByAccidentalStatus(true))
                    {
                        Console.WriteLine(vehicle.ToString());
                    }
                    break;
                case 6:
                    foreach (var vehicle in _vehicleService.GetallVehicleByAccidentalStatus(false))
                    {
                        Console.WriteLine(vehicle.ToString());
                    }
                    break;
                default:
                    Console.WriteLine("Invalid option chosen try again");
                    break;
            }
        }
        public void GetvehiclById()
        {
            Console.WriteLine("Enter vehicle id");
            int vehicleId;
            int.TryParse(Console.ReadLine(), out vehicleId);
            if (vehicleId == 0)
                throw new VehicleNotFoundException("Invalid format of Id please enter whole non fractional number");           
                Console.WriteLine(_vehicleService.GetRecordById<Vehicle>(vehicleId).ToString());
        }
       
    }
}
