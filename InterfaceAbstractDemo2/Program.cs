using InterfaceAbstractDemo2.Abstract;
using InterfaceAbstractDemo2.Concrete;
using InterfaceAbstractDemo2.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAbstractDemo2
{
	class Program
	{
		static void Main(string[] args)
		{
			BaseCustomerManager customerManager = new StarbuksCustomerManager();
			customerManager.Save(new Customer {DateOfBirth = new DateTime(1993,15,6), FirstName = "Abdullah", LastName = "DAĞLI", NationalityId = "10136788048" });

			Console.ReadLine();
		}
	}
}
