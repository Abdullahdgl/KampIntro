using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
	class SepetManager
	{
		//Naming Convention
		//Syntax

		public void Ekle(Urun urun)
		{
			Console.WriteLine("Tebrikler Sepete Eklendi.! : " + urun.Adi);
		}
		public void Ekle2(string urunadi, string aciklama, double fiyat, int stokAdeti)
		{
			Console.WriteLine("Tebrikler Sepete Eklendi.! : " + urunadi);
		}
	}
}
