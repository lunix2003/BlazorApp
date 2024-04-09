using ClassLibrary;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        private readonly AppDbContext context;

        public DepartmentController(AppDbContext context)
        {
            this.context = context;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(context.Departments.ToList());
        }
        [HttpGet("{id:int}")]
        public async Task<ActionResult> GetById(int id)
        {
            var dep = await context.Departments.FindAsync(id);
            if (dep == null) return NotFound("No Employee");
            return Ok(dep);
        }
        [HttpPost]
        public async Task <ActionResult> PostAsync(Department department)
        {
            var dep = context.Departments.Add(department);
            await context.SaveChangesAsync();
            return Ok(dep);
        }
        [HttpPut("{id:int}")]
        public async Task <ActionResult> PutAsync(int id ,Department department)
        {
            if (id != department.Id) return NotFound("No Department");
            var dep = context.Departments.Update(department).Entity;
            await context.SaveChangesAsync();
            return Ok(dep);
        }
        [HttpDelete("{id:int}")]
        public async Task <ActionResult> DeleteAsync(int id)
        {
            var dep =await context.Departments.FindAsync(id);
            if (dep != null) context.Departments.Remove(dep);
            await context.SaveChangesAsync();
            return NoContent();
        }
    }
}
