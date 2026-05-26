using System.ComponentModel.DataAnnotations;

namespace mvcdemoapp.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }
        [Required] 
        public string? FirstName { get; set; }
        public string LastName { get; set; } = string.Empty;
        public int PhoneNumber { get; set; }
        [Required] 
        public string? Email { get; set; }
        public DateOnly CreatedAt { get; set; }
        public bool IsActive { get; set; }

    }
}
