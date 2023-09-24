using System.ComponentModel.DataAnnotations;

namespace OnlineShopWebApp.Models
{
    public class Product
    {
        private static int instatceCounter = 1;
        public int Id { get; }
        [Required(ErrorMessage = "Не указано имя")]
        [StringLength(25, MinimumLength = 2, ErrorMessage = "Имя должно содержать от 2 до 25 символов")]
        public string Name { get; }
		[Required(ErrorMessage = "Не указана цена")]
		public decimal Cost { get; }
		[Required(ErrorMessage = "Не указано описание")]
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
