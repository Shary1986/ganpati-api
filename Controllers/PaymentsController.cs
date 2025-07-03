using Microsoft.AspNetCore.Mvc;
using GanpatiPaymentsAPI.Models;
using GanpatiPaymentsAPI.Data;
using Microsoft.EntityFrameworkCore;


namespace GanpatiPaymentsAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentsController : ControllerBase
    {
        private readonly PaymentsDbContext _context;

        public PaymentsController(PaymentsDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<IActionResult> SavePayments([FromBody] List<Payment> payments)
        {
            foreach (var p in payments)
            {
                await _context.Payments.AddAsync(p);
            }
            await _context.SaveChangesAsync();

            return Ok(new { message = "Saved to DB", count = payments.Count });
        }

        [HttpGet]
        public async Task<IActionResult> GetPayments()
        {
            var data = await _context.Payments.ToListAsync();
            return Ok(data);
        }
    }
}
