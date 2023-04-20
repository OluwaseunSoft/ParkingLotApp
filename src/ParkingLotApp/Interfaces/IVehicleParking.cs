namespace ParkingLotApp.Interfaces
{
    public interface IVehicleParking
    {
        List<int> Buses_Trucks(int parkingLotSpots);
        List<int> Motorcycles_Scooters(int parkingLotSpots);
        List<int> Cars_SUV(int parkingLotSpots);
    }
}