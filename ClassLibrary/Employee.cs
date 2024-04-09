using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClassLibrary
{
    public class Employee
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public string? FirstName { get; set; } = null!;
        [Required]
        public string? LastName { get; set; } = null!;
        public string? JobTitle { get; set; }
        public string?  Gender { get; set; }
    }
}
