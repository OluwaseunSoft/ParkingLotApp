using ParkingLotApp.Interfaces;

namespace ParkingLotApp.Services
{
    public class ParkingLotFees : IParkingLotFees
    {
        public int AirportParkingLot(int hour, string vehicle)
        {
            int fee = 0;
            try
            {
                switch (vehicle)
                {
                    case "Motorcycles_Scooters":
                        if (hour > 1 && hour <= 8)
                        {
                            fee = 40;
                        }
                        else if (hour > 8 && hour <= 24)
                        {
                            fee = 60;
                        }
                        else if (hour > 24)
                        {
                            float day = hour / 24;
                            fee = (int)day * 80;
                        }
                        else
                        {
                            fee = 0;
                        }
                        break;
                    case "Cars_SUV":
                        if (hour > 0 && hour <= 12)
                        {
                            fee = 60;
                        }
                        else if (hour > 12 && hour <= 24)
                        {
                            fee = 80;
                        }
                        else if (hour > 24)
                        {
                            float day = hour / 24;
                            fee = (int)day * 100;
                        }
                        break;
                    default:
                        fee = 0;
                        break;
                }
            }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex.Message);
            }
            return fee;
        }

        public int MallParkingLot(int hour, string vehicle)
        {
            int fee = 0;
            try
            {
                switch (vehicle)
                {
                    case "Motorcycles_Scooters":
                        fee = hour * 10;
                        break;
                    case "Cars_SUV":
                        fee = hour * 20;
                        break;
                    case "Buses_Trucks":
                        fee = hour * 50;
                        break;
                    default:
                        fee = 0;
                        break;
                }
            }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex.Message);
            }
            return fee;
        }

        public int StadiumParkingLot(int hour, string vehicle)
        {
            int fee = 0;
            try
            {
                switch (vehicle)
                {
                    case "Motorcycles_Scooters":
                        if (hour > 0 && hour <= 4)
                        {
                            fee = 30;
                        }
                        else if (hour > 4 && hour <= 12)
                        {
                            fee = 60 + 30;
                        }
                        else
                        {
                            fee = hour * 100;
                        }
                        break;
                    case "Cars_SUV":
                        if (hour > 0 && hour <= 4)
                        {
                            fee = 60;
                        }
                        else if (hour > 4 && hour <= 12)
                        {
                            fee = 120 + 60;
                        }
                        else
                        {
                            fee = hour * 200;
                        }
                        break;
                    default:
                        fee = 0;
                        break;
                }
            }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex.Message);
            }
            return fee;
        }
    }
}