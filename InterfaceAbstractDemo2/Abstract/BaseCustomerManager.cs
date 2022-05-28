using InterfaceAbstractDemo2.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceAbstractDemo2.Abstract
{
	public abstract class BaseCustomerManager : ICustomerService
	{
		public virtual void Save(Customer customer)
		{
			Console.WriteLine("Save to db :" + customer.FirstName);
		}

		internal abstract void save(Customer customer);
	}
}
