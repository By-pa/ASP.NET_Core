using System.ComponentModel.DataAnnotations;

namespace OnlineShopWebApp.Models
{
	public class UserDeliveryInfo
	{
		[Required(ErrorMessage = "Не указано ФИО")]
		[StringLength(150, MinimumLength = 10, ErrorMessage = "ФИО должно содержать от 10 до 150 символов")]
		public string Name { get; set; }
		[Required(ErrorMessage = "Поле Телефон должно быть заполнено")]
		[StringLength(20, MinimumLength = 5, ErrorMessage = "Поле Телефон должно содержать от 5 до 20 символов")]
		public string Phone { get; set; }
		[Required(ErrorMessage = "Поле Адрес должно быть заполнено")]
		[StringLength(200, MinimumLength = 5, ErrorMessage = "Поле Адрес должно содержать от 5 до 200 символов")]
		public string Address { get; set; }
	}
}
