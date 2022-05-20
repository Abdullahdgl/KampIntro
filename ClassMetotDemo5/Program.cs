using System;

namespace ClassMetotDemo5
{
	class Program
	{
		static void Main(string[] args)
		{
			Urun urun1 = new Urun();
			urun1.UrunID = 557974;
			urun1.UrunAdi = "BM Capital & Nagants Trade Sistemleri";

			Urun urun2 = new Urun();
			urun2.UrunID = 987563;
			urun2.UrunAdi = "Egzotik Sistemler";

			Urun urun3 = new Urun();
			urun3.UrunID = 789258;
			urun3.UrunAdi = "Hisse Analiz Paneli";

			Urun urun4 = new Urun();
			urun4.UrunID = 888769;
			urun4.UrunAdi = "User DLL";

			Urun urun5 = new Urun();
			urun5.UrunID = 332597;
			urun5.UrunAdi = "IDealGO Tarama Robotu & Algoritmik Trade Sistemleri";

			Urun[] uruns = new Urun[] { urun1, urun2, urun3, urun4, urun5 };
			UrunManager urunManager = new UrunManager();
			urunManager.Add(urun1);
			urunManager.Add(urun5);
			urunManager.Add(urun3);
			urunManager.Delete(urun4);
			urunManager.Delete(urun2);




		}
	}
}
