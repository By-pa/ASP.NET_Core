﻿using OnlineShopWebApp.Models;

namespace OnlineShopWebApp
{
	public class OrdersInMemoryRepository : IOrdersRepository
	{
		private List<Order> orders = new List<Order>();

		public void Add(Order order)
		{
			orders.Add(order);
		}

		public List<Order> GetAll()
		{
			return orders;
		}

		public Order TryGetById(Guid id)
		{
			return orders.FirstOrDefault(x => x.Id == id);
		}

		public void UpdateStatus(Guid orderId, OrderStatus newStatus)
		{
			var order = TryGetById(orderId);
			if (order != null)
			{
				order.Status = newStatus;
			}

		}
	}

}
