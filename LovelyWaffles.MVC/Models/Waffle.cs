using System.Collections.Generic;

namespace LovelyWaffles.MVC.Models
{
    public class Waffle
    {
        public int WaffleId { get; set; }
        public string Title { get; set; }
        public List<Ingradient> Ingradients { get; set; }
        public bool InStock { get; set; }
        public string Recipe { get; set; }
    }
}
