using System.ComponentModel.DataAnnotations;

namespace challenge_Diabetes.Model
{
    public class Observer
    {
        [Key]
        public int Id { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        [Phone]
        public string phone { get; set; }
        [Range(10, 100)]
        public string relvant_relation { get; set; }
        public string User_Id { get; set; }


        public virtual ICollection<ApplicationUser> Users { get; set; } = new List<ApplicationUser>();
    }
}
