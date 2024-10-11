namespace ChocolateShopLib
{
    public class Chocolate
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }

        public Chocolate(string name)
        {
            Id = Guid.NewGuid().ToString();

            Name = name;

        }
    }
}
