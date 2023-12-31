﻿using Microsoft.AspNetCore.Mvc;
using OnlineShopWebApp.Models;

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

		[HttpPost]
		public IActionResult Buy(UserDeliveryInfo user)
		{
			if (!user.Name.All(c => char.IsLetter(c) || c == ' '))
			{
				ModelState.AddModelError("", "ФИО должны содержать только буквы");
			}
			if (!user.Phone.All(c => char.IsDigit(c) || "+()- ".Contains(c)))
			{
				ModelState.AddModelError("", "Номер телефона может содержать только цифры и символы '+()-'");
			}

			if (!ModelState.IsValid)
			{
				return RedirectToAction("Index", user);
			}
			var existingCart = cartsRepository.TryGetByUserId(Constants.UserId);

			var order = new Order
			{
				User = user,
				Items = existingCart.Items,
			};
			ordersRepository.Add(order);

			cartsRepository.Clear(Constants.UserId);
			return View();
			

		}
	}
}
