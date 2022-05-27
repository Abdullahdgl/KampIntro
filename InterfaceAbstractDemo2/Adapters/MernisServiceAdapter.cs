using InterfaceAbstractDemo2.Abstract;
using InterfaceAbstractDemo2.Entities;
using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Text;



namespace InterfaceAbstractDemo2.Adapters
{
	public class MernisServiceAdapter : ICustomerCheckService
	{
		public bool CheckIfRealPerson(Customer customer)
		{

			MernisServiceReference.KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap12);

			return client.TCKimlikNoDogrulaAsync((customer.NationalityId), customer.FirstName.ToUpper(),customer.LastName.ToUpper(),customer.DateOfBirth.Year);

		}
	}
}
