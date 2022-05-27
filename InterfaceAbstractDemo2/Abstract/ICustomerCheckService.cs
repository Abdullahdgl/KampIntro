using InterfaceAbstractDemo2.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceAbstractDemo2.Abstract
{
	public interface ICustomerCheckService
	{
		bool CheckIfRealPerson(Customer customer);
	}
}
