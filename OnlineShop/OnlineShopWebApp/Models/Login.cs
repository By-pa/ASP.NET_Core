using System.ComponentModel.DataAnnotations;

namespace OnlineShopWebApp.Models
{
	public class Login
	{
		[Required(ErrorMessage = "Не указано имя")]
		[StringLength(25, MinimumLength = 2, ErrorMessage = "Логин должно содержать от 2 до 25 символов")]
		public string UserName { get; set; }

		[Required(ErrorMessage = "Не указан пароль")]
		[StringLength(25, MinimumLength = 8, ErrorMessage = "Пароль должен содержать от 8 до 25 символов")]
		public string Password { get; set; }

		public bool RememberMe { get; set; }
	}
}
