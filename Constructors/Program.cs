using System;

namespace Constructors
{
	class Program
	{
		static void Main(string[] args)
		{
			Customer customer1 = new Customer { Id = 1, FirstName= "Abdullah",LastName = "Daglı",City = "Malatya"};
			
			Customer customer3 = new Customer();
			customer3.Id = 3;

			Customer customer2 = new Customer(2, "Derin", "Demirog", "Ankara");
			Console.WriteLine(customer2.FirstName);
	}
	

	}
	class Customer
	{
		public Customer()
		{

		}
		//Default Constructors
		public Customer(int id , string firstName,  string lastName, string city)
		{
			Id = id;
			FirstName = firstName;
			LastName = lastName;
			City = city;

		}
		public int Id { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string City { get; set; }

	}
}
