namespace HippWeb.Models.DTO
{   
    public class OrderHistoryDTO
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public string OldStatus { get; set; }
        public string NewStatus { get; set; }
        public DateTime Timestamp { get; set; }
    }
}
