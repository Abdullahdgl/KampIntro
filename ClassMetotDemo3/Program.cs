using System;

namespace ClassMetotDemo3
{
	class Program
	{
		static void Main(string[] args)
		{
			Customer customer1 = new Customer();
			customer1.id = 5;
			customer1.CustomerName = "Abdullah";
			customer1.CustomerLastName = "Dağlı";

			Customer customer2 = new Customer();
			customer2.id = 7;
			customer2.CustomerName = "Mehmet";
			customer2.CustomerLastName = "Dağlı";

			Customer customer3 = new Customer();
			customer3.id = 9;
			customer3.CustomerName = "Arif";
			customer3.CustomerLastName = "Dağlı";

			Customer[] customers = new Customer[] { customer1, customer2, customer3 };
			CustomerManager customerManager = new CustomerManager();

			//Methodları çağırmamız için

			customerManager.Add(customer1);
			customerManager.Delete(customer2);

			customerManager.List(customers);





		}
	}
}
