using System;
using InterfaceAbstractDemo3.Abstract;
using InterfaceAbstractDemo3.Entities;

namespace InterfaceAbstractDemo3.Entities
{
	public class Customer : IEntity
	{
		public int Id { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public DateTime DateOfBirth { get; set; }
		public string NationalityId { get; set; }

	}
}
