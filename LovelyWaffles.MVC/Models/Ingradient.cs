namespace LovelyWaffles.MVC.Models
{
    public class Ingradient
    {
        public int IngradientId { get; set; }
        public string Description { get; set; }
        public int WaffleId { get; set; }
        public Waffle Waffle { get; set; }
    }
}
