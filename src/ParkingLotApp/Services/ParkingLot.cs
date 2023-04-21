using ParkingLotApp.Interfaces;
using ParkingLotApp.Models;

namespace ParkingLotApp.Services
{
    public class ParkingLot : IParkingLot
    {
        private readonly IVehicleParking _vehicleParking;

        public ParkingLot(IVehicleParking vehicleParking)
        {
            _vehicleParking = vehicleParking;
        }
        public ParkingTicket AirportParking(string vehicles)
        {
            ParkingTicket parkingTicket = new ParkingTicket();
            try
            {
                List<int> spot = new List<int>();
                int ticketNumber = 1;
                if (vehicles == "Buses_Trucks")
                    return parkingTicket;
                if(vehicles == "Cars_SUV")
                    spot = _vehicleParking.Cars_SUV(500);
                if(vehicles == "Motorcycles_Scooters")
                    spot = _vehicleParking.Motorcycles_Scooters(200);
                
                var ticket = new ParkingTicket
                {
                    TicketNumber = ticketNumber,
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
            ParkingTicket parkingTicket = new ParkingTicket();
            try
            {
                List<int> spot = new List<int>();
                int ticketNumber = 1;
                if (vehicles == "Buses_Trucks")
                    spot = _vehicleParking.Buses_Trucks(10);
                if(vehicles == "Cars_SUV")
                    spot = _vehicleParking.Cars_SUV(80);
                if(vehicles == "Motorcycles_Scooters")
                    spot = _vehicleParking.Motorcycles_Scooters(100);
                
                var ticket = new ParkingTicket
                {
                    TicketNumber = ticketNumber,
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

        public ParkingTicket StadiumParking(string vehicles)
        {
           ParkingTicket parkingTicket = new ParkingTicket();
            try
            {
                List<int> spot = new List<int>();
                int ticketNumber = 1;
                if (vehicles == "Buses_Trucks")
                    return parkingTicket;
                if(vehicles == "Cars_SUV")
                    spot = _vehicleParking.Cars_SUV(1500);
                if(vehicles == "Motorcycles_Scooters")
                    spot = _vehicleParking.Motorcycles_Scooters(1000);
                
                var ticket = new ParkingTicket
                {
                    TicketNumber = ticketNumber,
                    EntryDateTime = DateTime.Now,
                    SpotNumber = spot.FirstOrDefault()
                };
                ticketNumber++;
                return ticket;

            }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex.Message);
            }

            return parkingTicket;
        }
    }
}