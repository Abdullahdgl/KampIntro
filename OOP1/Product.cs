using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
	//Snippet
	class Product 
	{

		public int Id { get; set; }

		public int CategoryId { get; set; } //referans Anahtarı

		public string ProductName { get; set; }
		public double UnitPrice { get; set; }
		public int UnitInStock { get; set; }


	}
}
