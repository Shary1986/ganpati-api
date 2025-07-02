using Microsoft.AspNetCore.Mvc;
using GanpatiPaymentsAPI.Models;

namespace GanpatiPaymentsAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentsController : ControllerBase
    {
        private static List<Payment> _payments = new(); // In-memory storage

        [HttpPost]
        public IActionResult SavePayments([FromBody] List<Payment> payments)
        {
            foreach (var payment in payments)
            {
                _payments.Add(payment);
            }
            return Ok(new { message = "Payments saved successfully", count = payments.Count });
        }

        [HttpGet]
        public IActionResult GetPayments()
        {
            return Ok(_payments);
        }
    }
}
