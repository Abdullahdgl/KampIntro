using System;
using System.Linq;

namespace GiysiClasses
{
	class Program
	{
		static void Main(string[] args)
		{
			Giysi giysi1 = new Giysi();
			giysi1.GiysiTuru = "Pantolon";
			giysi1.GiysiFiyati = 450;
			giysi1.Durumu = "Temiz";

			Giysi giysi2 = new Giysi();
			giysi2.GiysiTuru = "Gömlek";
			giysi2.GiysiFiyati = 310;
			giysi2.Durumu = "Lekeli";

			Giysi giysi3 = new Giysi();
			giysi3.GiysiTuru = "Ceket";
			giysi3.GiysiFiyati = 750;
			giysi3.Durumu = "Slim Fit";

			Giysi[] giysiler = new Giysi[] {giysi1,giysi2,giysi3 };
			foreach (var giysi in giysiler.OrderBy(p=>p.GiysiFiyati))
			{
				Console.WriteLine(giysi.GiysiTuru + " " + giysi.Durumu + " " + giysi.GiysiFiyati);
			}


		}
	}


	class Giysi
	{
		public string GiysiTuru { get; set; }
		public int GiysiFiyati { get; set; }
		public string Durumu { get; set; }
	}
}
