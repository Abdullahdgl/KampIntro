using System;
using System.Collections.Generic;

namespace OOP3_Beta04
{
	class Program
	{
		static void Main(string[] args)
		{
			IKrediManager tasitKrediManager = new TasitKrediManager();
			IKrediManager konutKrediManager = new KonutKrediManager();

			BasvuruManager basvuruManager = new BasvuruManager();
			//basvuruManager.BasvuruYap(tasitKrediManager);

			List<IKrediManager> krediler = new List<IKrediManager>() { tasitKrediManager, konutKrediManager };
			basvuruManager.KrediOnBilgilendirmesiYap(krediler);

		}
	}
}
