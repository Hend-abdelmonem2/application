using System.ComponentModel.DataAnnotations;

namespace challenge_Diabetes.DTO
{
    public class RegisterModelDTO 
    {
        [Required]
       public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }

        [Required, StringLength(50)]
        public string Username { get; set; }

        [Required, StringLength(128)]
        public string Email { get; set; }
        [Required, StringLength(100)]
        public string Phone { get; set; }
        [Required]
        public int age { get; set; }
        [Required]
        public string address { get; set; }
       
        [Required]
        public string sex { get; set; }

        

        [Required, StringLength(256)]
        public string Password { get; set; }
        [Required]
        [Compare("Password")]
        public string confirmpassword { get; set; }
    }
}


