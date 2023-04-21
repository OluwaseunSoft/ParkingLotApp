using ParkingLotApp.Interfaces;
using ParkingLotApp.Models;

namespace ParkingLotApp.Services
{
    public class ParkingReceipt : IParkingReceipt
    {
        private readonly IParkingLotFees _parkingLotFee;

        public ParkingReceipt(IParkingLotFees parkingLotFees)
        {
            _parkingLotFee = parkingLotFees;
        }
        public Models.ParkingReceipt AirportParking(string parkTime, string unparkTime, string vehicle)
        {
            Models.ParkingReceipt parkingReceipt = new Models.ParkingReceipt();
            try
            {
                DateTime startTime = Convert.ToDateTime(parkTime);
                DateTime endTime = Convert.ToDateTime(unparkTime);
                TimeSpan span = endTime.Subtract(startTime);
                var time = (endTime - startTime).TotalHours;
                var receipt = new Models.ParkingReceipt
                {
                        ReceiptNumber = 1,
                        Fees = _parkingLotFee.AirportParkingLot(time, vehicle),
                        EntryDateTime = startTime,
                        ExitDateTime = endTime
                };
                return receipt;
            }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex.Message);
            }
            return parkingReceipt;
        }

        public Models.ParkingReceipt MallParking(string parkTime, string unparkTime, string vehicle)
        {
            Models.ParkingReceipt parkingReceipt = new Models.ParkingReceipt();
            try
            {
                DateTime startTime = Convert.ToDateTime(parkTime);
                DateTime endTime = Convert.ToDateTime(unparkTime);
                TimeSpan span = endTime.Subtract(startTime);
                var time = span.Hours;
                var receipt = new Models.ParkingReceipt
                {
                        ReceiptNumber = 1,
                        Fees = _parkingLotFee.MallParkingLot(time, vehicle),
                        EntryDateTime = startTime,
                        ExitDateTime = endTime
                };
                return receipt;
            }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex.Message);
            }
            return parkingReceipt;
        }

        public Models.ParkingReceipt StadiumParking(string parkTime, string unparkTime, string vehicle)
        {
            Models.ParkingReceipt parkingReceipt = new Models.ParkingReceipt();
            try
            {
                DateTime startTime = Convert.ToDateTime(parkTime);
                DateTime endTime = Convert.ToDateTime(unparkTime);
                TimeSpan span = endTime.Subtract(startTime);
                var time = span.Hours;
                var receipt = new Models.ParkingReceipt
                {
                        ReceiptNumber = 1,
                        Fees = _parkingLotFee.StadiumParkingLot(time, vehicle),
                        EntryDateTime = startTime,
                        ExitDateTime = endTime
                };
                return receipt;
            }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex.Message);
            }
            return parkingReceipt;
        }
    }
}