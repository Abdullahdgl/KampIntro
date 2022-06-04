using System;
using System.Collections.Generic;
using System.Text;
using GameProjectDemo.Abstract;
using GameProjectDemo.Concrete;
using GameProjectDemo.Entities;

namespace GameProjectDemo.Concrete
{
	public class VerificationManager : IVerificationService
	{
		public bool CheckIfRealPerson(Gamer gamer)
		{
			if (gamer.NationalityId.Length ==11)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
	}
}

