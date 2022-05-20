using System;

namespace ClassMetotDemo4
{
	class Program
	{
		static void Main(string[] args)
		{
			Product product1 = new Product();
			product1.ProductId = 8458567;
			product1.ProductName = "Terlik";

			Product product2 = new Product();
			product2.ProductId = 959759;
			product2.ProductName = "Telefon";

			Product product3 = new Product();
			product3.ProductId = 975928;
			product3.ProductName = "Asansör Kayışı";

			Product product4 = new Product();
			product4.ProductId = 7662689;
			product4.ProductName = "Çakmak Taşı";

			Product[] products = new Product[] { product1, product2, product3, product4};

			ProductManager productManager = new ProductManager();
			productManager.Add(product1);
			productManager.Add(product2);
			productManager.Delete(product3);
			productManager.Delete(product4);
			productManager.ProductList(products);



		}
	}
}
