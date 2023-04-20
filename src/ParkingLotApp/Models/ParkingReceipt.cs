namespace ParkingLotApp.Models
{
    public class ParkingReceipt
    {
        public int Id { get; set; }
        public DateTime EntryDateTime { get; set; }
        public DateTime ExitDateTime { get; set; }
        public int Fees { get; set; }
        
    }
}