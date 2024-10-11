namespace ChocolateShopLib.Components
{
    public class Chocolate
    {
        private string Id { get; set; }
        private string Name { get; set; }
        private double Price { get; set; }

        public Chocolate(string name)
        {
            Id = Guid.NewGuid().ToString();

            Name = name;

        }
    }
}
