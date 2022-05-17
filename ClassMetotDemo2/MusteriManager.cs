using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo2
{
	internal class MusteriManager
	{
		public void Add(Musteri musteri)
		{
			Console.WriteLine("Müşteri Eklendi : " + musteri.Ad + " " + musteri.SoyAd);
		}
		public void Delete(Musteri musteri)
		{
			Console.WriteLine("Müşteri Silindi : " + musteri.Ad + " " + musteri.SoyAd);
		}
		public void ListAll(params Musteri[] musteriler)
		{
			Console.WriteLine("Musteriler Listelendi.");
			foreach (Musteri musteri in musteriler)
			{
				Console.WriteLine(musteri.Id + " " + musteri.Ad+ " " + musteri.SoyAd);
			}
		}
	} 
}
