using ParkingLotApp.Models;

namespace ParkingLotApp.Interfaces
{
    public interface IParkingReceipt
    {
        ParkingReceipt MallParking(string parkTime, string unparkTime, string vehicle);
        ParkingReceipt StadiumParking(string parkTime, string unparkTime, string vehicle);
        ParkingReceipt AirportParking(string parkTime, string unparkTime, string vehicle);
    }
}