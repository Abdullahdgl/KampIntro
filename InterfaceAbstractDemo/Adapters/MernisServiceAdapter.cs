using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Entities;
using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Text;


namespace InterfaceAbstractDemo.Adapters
{
	public class MernisServiceAdapter : ICustomerCheckService
	{
		public bool CheckIfRealPerson(Customer customer)
		{
			KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap12);
			var result = client.TCKimlikNoDogrulaAsync(38563261576, "Hasan Ertuğ", "Keçeci", 1994).Result.Body.TCKimlikNoDogrulaResult;
			return result;
		}
	}
}
