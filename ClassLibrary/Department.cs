
using System.ComponentModel.DataAnnotations;

namespace ClassLibrary
{
    public class Department
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Please Enter Department Name !")]
        public string DepartmentName { get; set; } = default!;
        public string? Description { get; set; }
        public DateTime? Created { get; set; } = DateTime.Now;
        public DateTime? Updated { get; set; } = DateTime.Now;

    }
}
