using System;

namespace OOP3_Beta01
{
	class Program
	{
		static void Main(string[] args)
		{
			KonutKrediManager konutKrediManager = new KonutKrediManager();

			BasvuruManager basvuruManager = new BasvuruManager();
			basvuruManager.BasvuruYap(konutKrediManager);

		}
	}
}
