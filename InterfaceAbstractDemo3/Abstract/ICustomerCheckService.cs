using InterfaceAbstractDemo3.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceAbstractDemo3.Abstract
{
	public interface ICustomerCheckService
	{
		bool CheckIfRealPerson(Customer customer);
	}
}
