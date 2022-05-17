using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
	public interface CustomerManager
	{
		public void AddCustomer(Customer customer)
		{
			Console.WriteLine("New Customer Added : Name : " + customer.CustomerName+ " ID :" + customer.CustomerID + "Lastname" + customer.CustomerLastName);


		}
		public void DeleteCustomer(Customer customer)
		{
			Console.WriteLine("New Customer Delete : Name : " + customer.CustomerName + " ID :" + customer.CustomerID + "Lastname" + customer.CustomerLastName);


		}

		public void ListCustomer(Customer[] customers)
		{
			foreach (var customer in customers)
			{
				Console.WriteLine("Listing Customer Name : " + customer.CustomerName + " ID :" + customer.CustomerID + " LastName : " + customer.CustomerLastName);
			}
			
		}


	}
}
