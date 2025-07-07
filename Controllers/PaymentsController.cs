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
        //public async Task<IActionResult> SavePayments([FromBody] List<Payment> payments)
        public async Task<IActionResult> SavePayments([FromBody] Payment payments)
        {
            if (payments == null)
                return BadRequest("Payment is null");

            try
            {
                payments.Id = Guid.NewGuid().ToString();      // Required
                payments.Status = "Paid";

                _context.Payments.Add(payments);
                await _context.SaveChangesAsync();
                return Ok();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Payment save failed: " + ex.Message);
                return StatusCode(500, $"Server error: {ex.Message}");
            }

            /*
            foreach (var p in payments)
            {
                await _context.Payments.AddAsync(p);
            }
            await _context.SaveChangesAsync();

            return Ok(new { message = "Saved to DB", count = payments.Count });
            **/
        }

        [HttpGet]
        public async Task<IActionResult> GetPayments()
        {
            var data = await _context.Payments.ToListAsync();
            return Ok(data);
        }
    }
}
