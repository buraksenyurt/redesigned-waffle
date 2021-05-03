using System.Collections.Generic;

namespace LovelyWaffles.MVC.Models
{
    public class Waffle
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public List<string> Ingradients { get; set; }
        public bool InStock { get; set; }
        public string Recipe { get; set; }
    }
}
