using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo7
{
	class ProductManager
	{
		public void Add(Product product)
		{
			Console.WriteLine("Eklendi " + product.id +product.Name);
		}
		public void Delete(Product product)
		{
			Console.WriteLine("Silindi " + product.id + product.Name);
		}

		public void List(Product[] products)
		{
			foreach (Product product in products)
			{
				Console.WriteLine("Listelendi . " + product.id  + product.Name);
			}
		}
	}
}
