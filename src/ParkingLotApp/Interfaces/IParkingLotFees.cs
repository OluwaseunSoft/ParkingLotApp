namespace ParkingLotApp.Interfaces
{
    public interface IParkingLotFees
    {
        int StadiumParkingLot(int hour, string vehicle);
        int MallParkingLot(int hour, string vehicle);
        int AirportParkingLot(int hour, string vehicle);

    }
}