using System.ComponentModel.DataAnnotations;

namespace challenge_Diabetes.DTO
{
    public class TokenRequestModelDTO
    {
        [Required]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }
    }
}
