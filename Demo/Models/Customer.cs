using System.ComponentModel.DataAnnotations;

namespace Demo.Models
{
    public class Customer
    {
        public int Id { get; set; }

        [Required]
        [StringLength(64)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(64)]
        public string LastName { get; set; }

        [StringLength(64)]
        public string PhoneNumber { get; set; }

        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        [StringLength(64)]
        public string Email { get; set; }
    }
}