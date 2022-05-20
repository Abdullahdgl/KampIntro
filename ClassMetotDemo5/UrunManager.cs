using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo5
{
	class UrunManager
	{
		public void Add(Urun urun)
		{
			Console.WriteLine("Ürün Eklendi" + urun.UrunAdi + " " + urun.UrunID);

		}
		public void Delete(Urun urun)
		{
			Console.WriteLine("Ürün Silindi" + urun.UrunAdi + " " + urun.UrunID);

		}

		public void List(Urun[] uruns)
		{
			foreach (Urun urun in uruns)
			{
				Console.WriteLine("Ürünler Listelendi " + urun.UrunAdi + " " + urun.UrunID);
			}
		}

	}
}
