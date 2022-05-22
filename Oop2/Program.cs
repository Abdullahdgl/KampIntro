using System;

namespace Oop2
{
	class Program
	{
		static void Main(string[] args)
		{
			//Abdullah Dağlı
			GercekMusteri musteri1 = new GercekMusteri();
			musteri1.Id = 1;
			musteri1.MusteriNo = "123456";
			musteri1.Adi = "Abdullah";
			musteri1.Soyadi = "Dağlı";
			musteri1.TcNo = "101795288048";


			//Kodlama.io

			TuzelMusteri musteri2 = new TuzelMusteri();
			musteri2.Id = 2;
			musteri2.MusteriNo = "54689";
			musteri2.SirketAdi = "Kodlama.io";
			musteri2.VergiNo = "56699456698";


			// Gerçek Müşteri - Tüzel Müşteri Birbirinin yerini asla kullanamazlar,
			// SOLİD

			Musteri muster3 = new GercekMusteri();
			Musteri musteri4 = new TuzelMusteri();

			MusteriManager musteriManager = new MusteriManager();
			musteriManager.Ekle(musteri1);
			musteriManager.Ekle(musteri2);



		}
	}
}
