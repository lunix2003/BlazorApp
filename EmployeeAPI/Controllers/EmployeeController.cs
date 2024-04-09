using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EmployeeAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly AppDbContext context;

        public EmployeeController(AppDbContext context)
        {
            this.context = context;
        }

        // GET: EmployeeController
        [HttpGet]
        public ActionResult GetAll()
        {
            return Ok(context.Employees.ToList());
        }
        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetById(int id)
        {
            var emp = await context.Employees.FindAsync(id);
            if (emp is null) return NotFound("No Employee");
            return Ok(emp);
        }

    }
}
