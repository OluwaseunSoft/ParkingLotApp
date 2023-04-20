using ParkingLotApp.Interfaces;
using ParkingLotApp.Models;

namespace ParkingLotApp.Services
{
    public class ParkingLot : IParkingLot
    {
        private readonly VehicleParking _vehicleParking;

        public ParkingLot(VehicleParking vehicleParking)
        {
            _vehicleParking = vehicleParking;
        }
        public ParkingTicket AirportParking(string vehicles)
        {
            ParkingTicket parkingTicket = new ParkingTicket();
            try
            {
                int ticketNumber = 1;
                if (vehicles == "Buses/Trucks")
                    return parkingTicket;
                var spot = _vehicleParking.Cars_SUV(500);
                var ticket = new ParkingTicket
                {
                    Id = ticketNumber,
                    EntryDateTime = DateTime.Now,
                    SpotNumber = spot.FirstOrDefault()
                };
                return ticket;

            }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex.Message);
            }

            return parkingTicket;
        }

        public ParkingTicket MallParking(string vehicles)
        {
            throw new NotImplementedException();
        }

        public ParkingTicket StadiumParking(string vehicles)
        {
            throw new NotImplementedException();
        }
    }
}