using InterfaceAbstractDemo3.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceAbstractDemo3.Abstract
{
	public class BaseCustomerManager : ICustomerService
	{
		public virtual void save(Customer customer)
		{
			Console.WriteLine("Save to db :" + customer.FirstName);
			
		}
	}
}
