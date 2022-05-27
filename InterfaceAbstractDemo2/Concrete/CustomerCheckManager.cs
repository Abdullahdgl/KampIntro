using InterfaceAbstractDemo2.Abstract;
using InterfaceAbstractDemo2.Entities;
using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceAbstractDemo2.Concrete
{
	public class CustomerCheckManager : ICustomerCheckService
	{
		public bool CheckIfRealPerson(Customer customer)
		{
			return true;
		}
	}
}
