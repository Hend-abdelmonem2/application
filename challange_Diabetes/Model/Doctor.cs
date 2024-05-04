using System.ComponentModel.DataAnnotations;

namespace challenge_Diabetes.Model
{
    public class Doctor
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string userName { get; set; }
        [Phone]
        public string phone { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        public string Password { get; set; }
        public string address { get; set; }
        public string appointment { get; set; }
        public virtual ICollection<ApplicationUser> Users { get; set; } = new List<ApplicationUser>();
    }
}
