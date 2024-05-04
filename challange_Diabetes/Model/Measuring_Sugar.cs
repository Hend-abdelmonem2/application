using Microsoft.Build.Framework;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.Metrics;
using RequiredAttribute = Microsoft.Build.Framework.RequiredAttribute;

namespace challenge_Diabetes.Model
{
    public class Measuring_Sugar
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int sugar_reading { get; set; }
        [Required]
        public  string measurement_date { get; set; }
        public DateTime DateTime { get; set; }= DateTime.Now;
        public ApplicationUser user { get; set; }
        [ForeignKey(nameof(user))]
        public string User_Id { get; set; }
    }
}
