using InterfaceAbstractDemo3.Abstract;
using InterfaceAbstractDemo3.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceAbstractDemo3.Concrete
{
	public abstract class CustomerCheckManager : ICustomerCheckService
	{
		public bool CheckIfRealPerson(Customer customer)
		{
			return true;

		}
	}
}
