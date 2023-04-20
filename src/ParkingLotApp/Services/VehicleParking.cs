using ParkingLotApp.Interfaces;
using ParkingLotApp.Models;

namespace ParkingLotApp.Services
{
    public class VehicleParking : IVehicleParking
    {
        VehiclesParkingSpots vehiclesParkingSpots = new VehiclesParkingSpots();
        public List<int> Buses_Trucks(int parkingLotSpots)
        {

            for (int i = 1; i <= parkingLotSpots; i++)
            {
                vehiclesParkingSpots.Buses_Trucks.Add(i);
            }
            return vehiclesParkingSpots.Buses_Trucks;
        }

        public List<int> Cars_SUV(int parkingLotSpots)
        {
            for (int i = 1; i <= parkingLotSpots; i++)
            {
                vehiclesParkingSpots.Cars_SUV.Add(i);
            }
            return vehiclesParkingSpots.Cars_SUV;
        }

        public List<int> Motorcycles_Scooters(int parkingLotSpots)
        {
            for (int i = 1; i <= parkingLotSpots; i++)
            {
                vehiclesParkingSpots.Motorcycles_Scooters.Add(i);
            }
            return vehiclesParkingSpots.Motorcycles_Scooters;
        }
    }
}