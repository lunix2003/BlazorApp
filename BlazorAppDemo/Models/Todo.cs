using System.ComponentModel.DataAnnotations;

namespace BlazorAppDemo.Models
{
    public record Todo
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; } = string.Empty;
        public bool Status { get; set; }
    }
}
