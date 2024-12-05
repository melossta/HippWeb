namespace HippWeb.Models.DTO
{
    public class OrderDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public string Address { get; set; }
        public string DeliveryDestination { get; set; }
        public DateTime LastUpdated { get; set; }
        public int ClientId { get; set; }
        public int SalesPersonId { get; set; }
        public int EmployeeId { get; set; }
    }
}
