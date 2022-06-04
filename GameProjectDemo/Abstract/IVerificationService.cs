using GameProjectDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectDemo.Abstract
{
	public interface IVerificationService
	{
		bool CheckIfRealPerson(Gamer gamer);
	}
}
