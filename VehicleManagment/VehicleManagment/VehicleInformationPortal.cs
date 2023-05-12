using System;
using VehicleManagment.Service;
using VehicleManagment.Factory;
using VehicleManagment.CustomException;
namespace VehicleManagment
{
    class VehicleInformationPortal
    {
        private static readonly VehicleInformationPortalService _vehicleInformationPortalService= VehicleInformationPortalFactory.GetVehicleInformationPortalService();
       static VehicleInformationPortal()
        {
            _vehicleInformationPortalService = VehicleInformationPortalFactory.GetVehicleInformationPortalService();
        }
        static void Main(string[] args)
        {
            int choice = 100;
            Console.WriteLine("\n\n------------WELCOME TO VEHICLE INFORMATION PORTAL---------------------------");
                     
            do
            {
                _vehicleInformationPortalService.DisplayMenu();
                try
                {
                    int.TryParse(Console.ReadLine(), out choice);
                    switch (choice)
                    {

                        case 1:
                            _vehicleInformationPortalService.AddVehicle();
                            break;
                        case 2:
                            _vehicleInformationPortalService.GetvehiclById();
                            break;
                        case 3:
                            _vehicleInformationPortalService.GetVehicleSrviceHistory();
                            break;
                        case 4:
                            _vehicleInformationPortalService.AddVehicleSevice();
                            break;
                        case 5:
                            _vehicleInformationPortalService.DisplayVehicle();
                            break;
                        case 100:
                            Console.WriteLine("--------------Thank you--------------------------------");
                            break;
                        default:
                            Console.WriteLine("Please enter valid option");
                            break;

                    }
                }
                catch (ColorNotfoundException cnfe)
                {
                    Console.WriteLine(cnfe.Message);
                }
                catch (DatabaseException de)
                {
                    Console.WriteLine(de.Message);
                }
                catch (DateException de)
                {
                    Console.WriteLine(de.Message);
                }
                catch (FuelTypeException fte)
                {
                    Console.WriteLine(fte.Message);
                }
                catch (RecordsNotFoundException rnf)
                {
                    Console.WriteLine(rnf.Message);
                }
                catch (TransmisionTypeNotFoundException ttnfe)
                {
                    Console.WriteLine(ttnfe.Message);
                }catch(VehicleNotFoundException vnfe)
                {
                    Console.WriteLine(vnfe.Message);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Internal server error try after some time");
                }
            } while (choice!=100);
            
            Console.ReadLine();
        }
    }
}
