using ChocolateShopLib.Components;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace ChocolateShopAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CustomerController : ControllerBase
    {
        private readonly ChocolateShopDbContext _context;
        public CustomerController(ChocolateShopDbContext context)
        {
            _context  = context;

        }
        [HttpGet]
        public ActionResult<List<Customer>> GetAll()
        {
            return Ok(_context.Customers.ToList());
        }
    }
}
