using System.ComponentModel.DataAnnotations;

namespace IdentityDotNet.Models
{
    public class OfferList
    {
        [Key]
        public int Id { get; set; }
        public int Number { get; set; }

        [Required(ErrorMessage = "กรุณากรอกข้อมูลวันที่")]
        public DateOnly DateOnly { get; set; }
        public string CheckList { get; set; } = string.Empty;
        [Required(ErrorMessage = "กรุณากรอกรายละเอียด")]
        [StringLength(500)]
        public string Description { get; set; } = string.Empty;

        [Required]
        public string Status { get; set; } = string.Empty;
        public string Finish { get; set; } = string.Empty;
        [Required]
        public string Recorder { get; set; } = string.Empty;
    }
}
