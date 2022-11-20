using Microsoft.EntityFrameworkCore;
using WebApiClassone.Models;

namespace WebApiClassone.Data
{
    public class BookingContext : DbContext
    {
        public BookingContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Booking> Bookings { get; set; }
    }
}
