namespace OnlineShopWebApp.Models
{
    public class Product
    {
        private static int instatceCounter = 1;
        public int Id { get; }
        public string Name { get; }
        public decimal Cost { get; }
        public string Description { get; }

        public string ImagePath { get; }

        public Product(string name, decimal cost, string description, string imagePath)
        {
            Id = instatceCounter;
            Name = name;
            Cost = cost;
            Description = description;
            ImagePath = imagePath;
            instatceCounter++;
        }


    }
}
