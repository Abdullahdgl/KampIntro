using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo3
{
	public class CustomerManager
	{
		// Ekleme İşlemleri İçin Yazılması gereken method
		public void Add(Customer customer)
		{
			Console.WriteLine("Listeye Eklenmiştir. " + customer.id + " " + customer.CustomerName+ " " + customer.CustomerLastName);
		}

		//Silme işlemleri için yazılması gereken method
		public void Delete(Customer customer)
		{
			Console.WriteLine("Listeden Silinmiştir. " + customer.id + " " + customer.CustomerName + " " + customer.CustomerLastName);
		}


		// Listelemek için yazılırsa yapılması gereken Method;

		public void List(Customer[] customers)
		{

			foreach (Customer customer in customers)
			{
				Console.WriteLine("Listeleme işlemi başarılı bir şekilde yapılmıştır. " + customer.id + " " + customer.CustomerName + " " + customer.CustomerLastName);

			}
		}






	}
}
