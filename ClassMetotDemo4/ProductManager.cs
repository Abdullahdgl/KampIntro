using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo4
{
	public class ProductManager
	{
		//Method kullanarak ürünleri eklemeyi silmeyi vede Listelemeyi gösteren methodun yazılımı;
		
		//Ekleme Methodu
		public void Add(Product product)
		{
			Console.WriteLine("Ürününüz Eklenmiştir. " + product.ProductName+ " " + product.ProductId);

		}

		//Silme Methodu
		public void Delete(Product product)
		{
			Console.WriteLine("Ürününüz Silinmiştir. " + product.ProductName + " " + product.ProductId);

		}

		//Listeleme Methodu
		public void ProductList(Product[] products)
		{
			foreach (Product product in products)
			{
				Console.WriteLine("Ürünleriniz Amazon Marketing Üzerinden Listelenmiştir. " + product.ProductId + " " + product.ProductName);

			}
		} 
	}
}
