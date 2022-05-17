using System;
using System.Linq;

namespace ClassIntro
{
	class Program
	{
		static void Main(string[] args)
		{
			string Adi = "Abdullah";
			int yas = 29;
			Kurs kurs1 = new Kurs();
			kurs1.KursAdi = "C#";
			kurs1.Egitmen = "Engin Demiroğ";
			kurs1.IzlenmeOrani = 68;
			
			
			Kurs kurs2 = new Kurs();
			kurs2.KursAdi = "Java";
			kurs2.Egitmen = "Kerem Variş";
			kurs2.IzlenmeOrani = 64;

			Kurs kurs3 = new Kurs();
			kurs3.KursAdi = "Python";
			kurs3.Egitmen = "Berkay Bilgin";
			kurs3.IzlenmeOrani = 80;

			Kurs kurs4 = new Kurs();
			kurs4.KursAdi = "C++";
			kurs4.Egitmen = "Murat Kurtboğan";
			kurs4.IzlenmeOrani = 100;


			film film1 = new film();
			film1.filmAdi = "Buz Devri";
			film1.imbd = 7.7;

			film film2 = new film();
			film2.filmAdi = "Hababam Sınıfı";
			film2.imbd = 9.7;

			film film3 = new film();
			film3.filmAdi = "Yenilmezler";
			film3.imbd = 7.9;

			film film4 = new film();
			film4.filmAdi = "Kutupta Macera";
			film4.imbd = 8.7;

			film film5 = new film();
			film5.filmAdi = "Maske";
			film5.imbd = 9.7;
			film[] filmler = new film[] { film1, film2, film3, film4, film5 };


			foreach (var film in filmler.OrderBy(f => f.imbd))
			{
				Console.WriteLine(film.filmAdi + " " + film.imbd);
			}



0
			Kurs[] kurslar = new Kurs[] {kurs1,kurs2,kurs3 , kurs4};
			foreach (var kurs in kurslar)
			{
				Console.WriteLine(kurs.KursAdi + " : " + kurs.Egitmen);
			}
			
			

			//Console.WriteLine(kurs1.KursAdi  + " : " + kurs1.Egitmen);

			Console.WriteLine("Hello World!");
		}
	}


	class film
	{
		public string filmAdi { get; set; }
		public double imbd { get; set; }
	}
	class Kurs
	{
		public string KursAdi { get; set; }
		public string Egitmen { get; set; }
		public int IzlenmeOrani { get; set; }
	}
}
