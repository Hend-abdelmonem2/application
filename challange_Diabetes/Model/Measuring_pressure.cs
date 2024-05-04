using MessagePack;
using Microsoft.Build.Framework;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using KeyAttribute = System.ComponentModel.DataAnnotations.KeyAttribute;
using RequiredAttribute = Microsoft.Build.Framework.RequiredAttribute;

namespace challenge_Diabetes.Model
{
    public class Measuring_pressure
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int Diastolic_pressure { get; set; }
        [Required]
        public int Systolic_pressure { get; set; }
        public int Heart_rate { get; set; }


        public DateTime DateTime { get; set; }= DateTime.Now;
        public ApplicationUser user { get; set; }
        [ForeignKey(nameof(user))]
        public string User_Id { get; set; }

    }
}
