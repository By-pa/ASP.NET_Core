﻿using OnlineShopWebApp.Models;
using System.Collections.Generic;

namespace OnlineShopWebApp
{
	public interface IOrdersRepository
	{
		void Add(Order order);
		List<Order> GetAll();
		Order TryGetById(Guid id);
		void UpdateStatus(Guid orderId, OrderStatus newStatus);
	}
}