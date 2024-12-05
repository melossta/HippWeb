using HippWeb.Domain.Models;
using HippWeb.Models.Domain;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace HippWeb.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Client> Clients { get; set; }
        public DbSet<Driver> Drivers { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Manager> Managers { get; set; }
        public DbSet<Order> Orders { get; set; }
       // public DbSet<OrderStatus> orderStatuses {  get; set; }
        public DbSet<OrderHistory> orderHistories { get; set; }
        public DbSet<SalesPerson> salesPeople { get; set; }
        public DbSet<Product> Products { get; set; }
       
    }
}
