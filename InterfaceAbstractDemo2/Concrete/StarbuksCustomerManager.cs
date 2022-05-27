using InterfaceAbstractDemo2.Abstract;
using InterfaceAbstractDemo2.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceAbstractDemo2.Concrete
{
	public class StarbuksCustomerManager: BaseCustomerManager
	{
		private ICustomerCheckService _customerCheckService;

		public StarbuksCustomerManager()
		{
		}

		public StarbuksCustomerManager(ICustomerCheckService customerCheckService)
		{
			_customerCheckService = customerCheckService;
		}

		public override void Save(Customer customer)
		{
			if (_customerCheckService.CheckIfRealPerson(customer))
			{
				base.Save(customer);

			}
			else
			{
				throw new Exception("Not a valid Person");
			}
		}

		
	}
}
