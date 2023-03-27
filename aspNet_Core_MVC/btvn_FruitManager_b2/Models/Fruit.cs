namespace btvn_FruitManager_b2.Models
{
    public class Fruit
    {
        public int Id { get; set; } 
        public string Name { get; set; }    
        public string Img { get; set; } 
        public int NewPrice { get; set; }
        public int OldPrice { get; set; }    
        public int Discount { get; set; }   
        public int Rate { get; set; }

        public Fruit(int id, string name, string img, int newPrice, int oldPrice, int discount, int rate)
        {
            Id = id;
            Name = name;
            Img = img;
            NewPrice = newPrice;
            OldPrice = oldPrice;
            Discount = discount;
            Rate = rate;
        }
    }
}
