using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo6
{
	class CustomerManager
	{
		public void Add(Customer customer)
		{
			Console.WriteLine("Eklendi  " + customer.id + " " + customer.Name);

		}
		public void Delete(Customer customer)
		{
			Console.WriteLine("Silindi  " + customer.id + " " + customer.Name);

		}

		public void List(Customer[] customers)
		{
			foreach (Customer customer in customers)
			{
				Console.WriteLine("Listelendi. " + customer.id + " " + customer.Name);
			}
		}
	}
}
