using System.ComponentModel.DataAnnotations;

namespace OnlineShopWebApp.Models
{
    public class Product
    {
        private static int instatceCounter = 1;
        public int Id { get; set; }
        [Required(ErrorMessage = "Не указано имя")]
        [StringLength(25, MinimumLength = 2, ErrorMessage = "Имя должно содержать от 2 до 25 символов")]
        public string Name { get; set; }
		[Required(ErrorMessage = "Не указана цена")]
        [DataType(DataType.Currency, ErrorMessage = "Только число")]
		public decimal Cost { get; set; }
		[Required(ErrorMessage = "Не указано описание")]
		public string Description { get; set; }

        public string ImagePath { get; set; }
        public Product()
        {
			Id = instatceCounter;
			instatceCounter++;
		}
        public Product(string name, decimal cost, string description, string imagePath) : this()
        {
            
            Name = name;
            Cost = cost;
            Description = description;
            ImagePath = imagePath;
            
        }


    }
}
