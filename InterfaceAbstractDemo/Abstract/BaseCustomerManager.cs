using InterfaceAbstractDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceAbstractDemo.Abstract
{
	public class BaseCustomerManager : ICustomerService
	{
		public virtual void save(Customer customer)
		{
			Console.WriteLine("Saved to db" + customer.FirstName);
		}
	}
}
