using HippWeb.Models.Domain;

namespace HippWeb.Domain.Models
{
    public class Client
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public ICollection<Order> Orders { get; set; }
    }
}
