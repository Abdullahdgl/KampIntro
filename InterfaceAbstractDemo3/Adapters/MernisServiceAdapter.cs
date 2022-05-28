using InterfaceAbstractDemo3.Abstract;
using InterfaceAbstractDemo3.Entities;
using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceAbstractDemo3.Adapters
{
	class MernisServiceAdapter : ICustomerCheckService
	{
		public bool CheckIfRealPerson(Customer customer)
		{
			KPSPublicSoapClient client = new KPSPublicSoapClient();
			return client.TCKimlikNoDogrulaAsync(customer.NationalityId, customer.FirstName.ToUpper(), customer.LastName.ToUpper(), customer.DateOfBirth.Year); 		}
	}
}
