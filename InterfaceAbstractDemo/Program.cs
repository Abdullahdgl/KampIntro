using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Entities;
using System;

namespace InterfaceAbstractDemo
{
	class Program
	{
		static void Main(string[] args)
		{
			BaseCustomerManager baseCustomerManager = new BaseCustomerManager();
			baseCustomerManager.save(new Customer{DateOfBirth = new DateTime(1993, 6, 15), FirstName = "Abdullah", LastName = "Dağlı",NationalityId ="12345678912"});
		}
	}
}
