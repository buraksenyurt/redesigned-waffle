using System.ComponentModel.DataAnnotations;

namespace LovelyWaffles.RazorPages.Data
{
    public class Waffle
    {
        [Display(Name ="No")]
        public int WaffleId { get; set; }
        [Required]
        [MinLength(10)]
        [MaxLength(50)]
        public string Title { get; set; }
        [Display(Name ="On Sold")]
        public bool InStock { get; set; }
        [Required]
        [MinLength(50)]
        [MaxLength(1000)]
        public string Recipe { get; set; }
    }
}
