using ParkingLotApp.Models;

namespace ParkingLotApp.Interfaces
{
    public interface IParkingLot
    {
        ParkingTicket MallParking(string vehicles);
        ParkingTicket StadiumParking(string vehicles);
        ParkingTicket AirportParking(string vehicles);
    }
}