using System;
using System.Collections.Generic;

namespace OOP3_Beta03
{
	class Program
	{
		static void Main(string[] args)
		{
			IKrediManager konutKrediManager = new KonutKrediManager();
			IKrediManager tasitKrediManager = new TasitKrediManager();
			IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();


			BasvuruManager basvuruManager = new BasvuruManager();
			basvuruManager.BasvuruYap(konutKrediManager);


			// listeleme yapmak için kullanacağımız method;

			List<IKrediManager> krediler = new List<IKrediManager>() {konutKrediManager, tasitKrediManager };
			basvuruManager.KrediOnBilgilendirmesiYap(krediler);



		}
	}
}
