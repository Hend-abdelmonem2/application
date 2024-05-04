using challenge_Diabetes.Model;
using Microsoft.Build.Framework;
using System.ComponentModel.DataAnnotations;
using RequiredAttribute = Microsoft.Build.Framework.RequiredAttribute;

namespace challange_Diabetes.Model
{
    public class Medicine
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Dosage { get; set; }
        [Required]
        public string times { get; set; }
        [Required]
        public DateTime Date { get; set; }
        public string User_Id { get; set; }
       public virtual ICollection<ApplicationUser> Users { get; set; } = new List<ApplicationUser>();
    }
}
