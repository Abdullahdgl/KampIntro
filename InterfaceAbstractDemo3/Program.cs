using System;
using InterfaceAbstractDemo3.Abstract;
using InterfaceAbstractDemo3.Concrete;
using InterfaceAbstractDemo3.Entities;


namespace InterfaceAbstractDemo3.Abstract
{
	class Program
	{
		static void Main(string[] args)
		{

			BaseCustomerManager customerManager = new StarbuksCustomerManager();
			customerManager.save(new Customer { DateOfBirth = new DateTime(1993, 6, 15), FirstName = "Abrdullah", LastName = "DAĞLI", NationalityId = "10146788048" });

			Console.ReadLine();


		}
	}
}
