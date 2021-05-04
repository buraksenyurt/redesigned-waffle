using System.ComponentModel.DataAnnotations;

namespace LovelyWaffles.RazorPages.Data
{
    public class Waffle
    {
        [Display(Name ="No")]
        public int WaffleId { get; set; }
        public string Title { get; set; }
        [Display(Name ="On Sold")]
        public bool InStock { get; set; }
        public string Recipe { get; set; }
    }
}
