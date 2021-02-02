using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using OrderApi.Database.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderApi.Database
{
    public class OrdersDataContext : DbContext
    {
        public OrdersDataContext(DbContextOptions<OrdersDataContext> options) : base(options)
        {
            
        }

        public DbSet<Order> Orders { get; set; }
    }
}
