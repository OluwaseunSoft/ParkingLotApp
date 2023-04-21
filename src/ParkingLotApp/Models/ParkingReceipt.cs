namespace ParkingLotApp.Models
{
    public class ParkingReceipt
    {
        public int ReceiptNumber { get; set; }
        public DateTime EntryDateTime { get; set; }
        public DateTime ExitDateTime { get; set; }
        public double Fees { get; set; }
        
    }
}