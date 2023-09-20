using OnlineShopWebApp.Models;
using System.Linq;

namespace OnlineShopWebApp
{
    public class ProductsInMemoryRepository : IProductsRepository
    {
        private List<Product> products = new List<Product>()
        {
            new Product("Espresso", 50,
                "Эспре́ссо (от итал. espresso) — горячее ароматное питье на основе молотого кофе. Для его приготовления почти кипящую воду пропускают под давлением через фильтр с измельченными кофейными зернами.",
                "/images/espresso.jpg"),
            new Product("Cappuccino", 160,
                "Капучино – итальянский напиток, состоящий из Эспрессо, слоя взбитого молока и слоя молочной пенки. Чашка Капучино быстро придает заряд бодрости, благодаря содержанию кофеина, который не слишком сильно влияет на вкусовые качества напитка.",
                "/images/capuccino.jpg"),

            new Product("Latte", 180,
                "Ла́тте (caffè latte — «кофе с молоком») — кофейный напиток на основе молока, представляющий собой трёхслойную смесь из молочной пены, молока (итал. latte) и кофе эспрессо. Несмотря на итальянское название, был изобретён, по всей видимости, в Америке.",
                "/images/latte.jpg"),

            new Product("Americano", 110,
                "Америка́но (итал. Caffè Americano — кофе по-американски) — способ приготовления кофе, заключающийся в соединении определённого количества горячей воды и эспрессо.",
                "/images/americano.jpg"),
            new Product("Flat white", 210,
                "Флэт уайт — самый насыщенный по вкусу молочный напиток на основе эспрессо. Его особенно любят ценители вкуса эспрессо в чашке. Флэт уайт готовят такого же объёма, как и стандартный капучино — 150–180 мл, но используют две порции эспрессо. Остальной объем занимают молоко и совсем немного молочной пены.",
                "/images/flatwhite.jpg"),

        };

        public List<Product> GetAll()
        {
            return products;
        }

        public Product TryGetById(int id)
        {
            return products.FirstOrDefault(product => product.Id == id);

        }
    }
}
