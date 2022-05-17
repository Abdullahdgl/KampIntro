using System;

namespace ClassMetotDemo2
{
	class Program
	{
		static void Main(string[] args)
		{
			Musteri musteri1 = new Musteri();
			musteri1.Id = 1;
			musteri1.Ad = "Ayça";
			musteri1.SoyAd = "Demir";

			Musteri musteri2 = new Musteri();
			musteri2.Id = 3;
			musteri2.Ad = "Ahmet";
			musteri2.SoyAd = "Kılıç";

			Musteri musteri3 = new Musteri();
			musteri3.Id = 5;
			musteri3.Ad = "Dursun";
			musteri3.SoyAd = "Şahin";

			MusteriManager musteriManager = new MusteriManager();
			musteriManager.Add(musteri1);
			musteriManager.Delete(musteri2);
			musteriManager.ListAll(musteri1, musteri2, musteri3);
		}
	}
}
