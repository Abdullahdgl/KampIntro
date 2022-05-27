using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using InterfaceAbstractDemo2.Entities;

namespace InterfaceAbstractDemo2.Abstract
{
	public interface ICustomerService
	{
		void Save(Customer customer);

	}
}
