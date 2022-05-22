using System;

namespace OOP3_Beta02
{
	class Program
	{
		static void Main(string[] args)
		{
			TarimKredisiManager tarimKredisiManager = new TarimKredisiManager();
			KonutKredisiManager konutKredisiManager = new KonutKredisiManager();

			BasvuruManager basvuruManager = new BasvuruManager();
			basvuruManager.BasvuruYap(tarimKredisiManager);
		}
	}
}
