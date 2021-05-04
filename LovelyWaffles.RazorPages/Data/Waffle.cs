using System.Collections.Generic;

namespace LovelyWaffles.RazorPages.Data
{
    public class Waffle
    {
        public int WaffleId { get; set; }
        public string Title { get; set; }
        public bool InStock { get; set; }
        public string Recipe { get; set; }
    }
}
