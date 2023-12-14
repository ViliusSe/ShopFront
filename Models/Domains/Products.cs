namespace ShopFront.Models.Domains
{
    public class Products
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Picture { get; set; }
        public double Price { get; set;}
        public int Ammount { get; set; }

        //public List<Orders> Orders {get; set;}
    }
}
