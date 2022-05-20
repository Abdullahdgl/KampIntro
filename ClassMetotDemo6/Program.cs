using System;

namespace ClassMetotDemo6
{
	class Program
	{
		static void Main(string[] args)
		{
			Customer customer1 = new Customer();
			customer1.id = 1;
			customer1.Name = "Sürdürülebilirlik";

			Customer customer2 = new Customer();
			customer2.id = 2;
			customer2.Name = "Her Zaman Motivasyonun ne olursa olsun düşmesin";

			Customer[] customers = new Customer[] { customer1, customer2 };
			CustomerManager customerManager = new CustomerManager();
			customerManager.Add(customer1);
			customerManager.Delete(customer2);

			customerManager.List(customers);

		}
	}
}
