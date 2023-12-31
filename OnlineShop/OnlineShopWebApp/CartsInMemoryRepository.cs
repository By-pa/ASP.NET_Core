﻿using OnlineShopWebApp.Models;

namespace OnlineShopWebApp
{
	public class CartsInMemoryRepository : ICartsRepository
	{
		private List<Cart> carts = new List<Cart>();

		public Cart TryGetByUserId(string userId)
		{
			return carts.FirstOrDefault(cart => cart.UserId == userId);
		}

		public void Add(Product product, string userId)
		{
			var existingCart = TryGetByUserId(userId);
			if (existingCart == null)
			{
				var newCart = new Cart()
				{
					Id = Guid.NewGuid(),
					UserId = userId,
					Items = new List<CartItem>
					{
						new CartItem()
						{
							Id = Guid.NewGuid(),
							Amount = 1,
							Product = product,
						}
					}

				};
				carts.Add(newCart);
			}
			else
			{
				var existingCartItem = existingCart.Items.FirstOrDefault(item => item.Product.Id == product.Id);
				if (existingCartItem != null)
				{
					existingCartItem.Amount++;
				}
				else
				{
					existingCart.Items.Add(new CartItem
					{
						Id = Guid.NewGuid(),
						Amount = 1,
						Product = product,
					});
				}
			}
		}

		public void DecreaseAmount(int productId, string userId)
		{
			var existingCart = TryGetByUserId(userId);
			var existingCartItem = existingCart?.Items?.FirstOrDefault(item => item.Product.Id == productId);
			if (existingCartItem == null)
			{
				return;
			}

			existingCartItem.Amount -= 1;
			if (existingCartItem.Amount == 0)
			{
				existingCart.Items.Remove(existingCartItem);
			}	

		}

		public void Clear(string userId)
		{
			var existingCart = TryGetByUserId(userId);
			carts.Remove(existingCart);

		}
	}
}
