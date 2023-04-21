namespace ParkingLotApp.Interfaces
{
    public interface IParkingLotFees
    {
        double StadiumParkingLot(double hour, string vehicle);
        double MallParkingLot(double hour, string vehicle);
        double AirportParkingLot(double hour, string vehicle);

    }
}