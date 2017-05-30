using System.Data.Entity;
using Decore.Models;

namespace Decore.Data
{
    public class DecoreDbContext : DbContext
    {
        public DecoreDbContext() : base(
            "Data Source=WIN-OHORU1AP6CB; Initial Catalog=decore.data.DecoreDbContext; Persist Security Info=True;User ID=sa; Password=TSB100sql")
        {
        }

        public DbSet<Event> Events { get; set; }
        public DbSet<EventType> EventTypes { get; set; }
        
        public DbSet<Ticket> Tickets { get; set; }

        public DbSet<Beverage> Beverages { get; set; }

        public DbSet<CountBeverage> CountBeverages { get; set; }

    }
}