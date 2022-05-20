using System;

namespace ClassMetotDemo7
{
	class Program
	{
		static void Main(string[] args)
		{
			Product product1 = new Product();
			product1.id = 7;
			product1.Name = "FATİH";

			Product product2 = new Product();
			product2.id = 1453;
			product2.Name = "MEHMMET";

			Product[] products = new Product[] { product1, product2 };

			ProductManager productManager = new ProductManager();
			productManager.Add(product1);
			productManager.Delete(product2);

			productManager.List(products);

		}
	}
}
