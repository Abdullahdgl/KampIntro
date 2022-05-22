using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3_Beta02
{
	class BasvuruManager
	{
		public void BasvuruYap(IKrediManager krediManager)
		{
			krediManager.Hesapla();
		}
	}
}
