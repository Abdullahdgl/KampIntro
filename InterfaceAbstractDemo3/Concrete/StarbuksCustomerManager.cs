using InterfaceAbstractDemo3.Abstract;
using InterfaceAbstractDemo3.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceAbstractDemo3.Concrete
{
	public class StarbuksCustomerManager:BaseCustomerManager
	{
		private ICustomerCheckService _customerCheckService;

		public StarbuksCustomerManager()
		{
		}

		public StarbuksCustomerManager(ICustomerCheckService customerCheckService)
		{
			_customerCheckService = customerCheckService;

		}

		public override void save(Customer customer)
		{
			if (_customerCheckService.CheckIfRealPerson(customer))
			{
				base.save(customer);
			}
			else
			{
				throw new Exception("not a valid person ");
			
			}
				
		}


	}
}
