using Microsoft.AspNetCore.Mvc;

namespace OnlineShopWebApp.Controllers
{
	public class OrderController : Controller
	{
		private readonly ICartsRepository cartsRepository;
		private readonly IOrdersRepository ordersRepository;

		public OrderController(ICartsRepository cartsRepository, IOrdersRepository ordersRepository)
		{
			this.cartsRepository = cartsRepository;
			this.ordersRepository = ordersRepository;
		}
		public IActionResult index()
		{
			return View();
		}
		public IActionResult Buy()
		{
			var existingCart = cartsRepository.TryGetByUserId(Constants.UserId);
			ordersRepository.Add(existingCart);
			cartsRepository.Clear(Constants.UserId);
			return View();
		}
	}
}
