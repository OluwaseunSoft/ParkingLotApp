namespace ParkingLotApp.Models
{
    public class VehiclesParkingSpots
    {
        public int Id { get; set; }
        public List<int> Motorcycles_Scooters { get; set; } = new List<int>();
        public List<int> Cars_SUV { get; set; } = new List<int>();
        public List<int> Buses_Trucks { get; set; } = new List<int>();
    }
}