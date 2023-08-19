using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExpenseTrackerInNETCore.Models
{
    public class User
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Name Cannot be Blank")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Email Cannot be Blank")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password Cannot be Blank")]
        public string Password { get; set; }

        [Required(ErrorMessage = "MobileNumber Cannot be Blank")]
        public long MobileNumber { get; set; }

        public bool IsAdmin { get; set; } = false;

        public bool IsEmailVerified { get; set; } = false;



    }
}
