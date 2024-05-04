using System.ComponentModel.DataAnnotations;

namespace challange_Diabetes.DTO
{
    public class medicineDTO
    {
        public string Name { get; set; }
        [Required]
        public string Dosage { get; set; }
        [Required]
        public string times { get; set; }
        [Required]
        public DateTime Date { get; set; }
    }
}
