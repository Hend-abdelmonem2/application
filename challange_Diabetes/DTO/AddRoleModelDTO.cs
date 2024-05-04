using System.ComponentModel.DataAnnotations;

namespace challenge_Diabetes.DTO
{
    public class AddRoleModelDTO
    {
        [Required]
        public string UserId { get; set; }

        [Required]
        public string Role { get; set; }
    }
}
