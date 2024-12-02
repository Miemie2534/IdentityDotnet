using System.ComponentModel.DataAnnotations;

namespace IdentityDotNet.Models
{
    public class Emergency
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "กรุณากรอกข้อมูลวันที่")]
        public DateOnly Date { get; set; }
        [Required(ErrorMessage = "กรุณากรอกข้อมูลเวลา")]
        public TimeOnly Time { get; set; }
        [Required(ErrorMessage = "กรุณากรอกข้อมูล")]
        [StringLength(100)]
        public string Description { get; set; } = string.Empty;
        [Required(ErrorMessage = "กรุณากรอกข้อมูล")]
        [StringLength(500)]
        public string Edit { get; set; } = string.Empty;
        [Required(ErrorMessage = "กรุณากรอกข้อมูล")]
        public string Recorder { get; set; } = string.Empty;
    }
}
