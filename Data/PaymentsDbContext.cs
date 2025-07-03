using Microsoft.EntityFrameworkCore;
using GanpatiPaymentsAPI.Models;

namespace GanpatiPaymentsAPI.Data
{
    public class PaymentsDbContext : DbContext
    {
        public PaymentsDbContext(DbContextOptions<PaymentsDbContext> options) : base(options) { }

        public DbSet<Payment> Payments { get; set; }
    }
}
