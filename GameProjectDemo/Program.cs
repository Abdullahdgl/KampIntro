using GameProjectDemo.Concrete;
using GameProjectDemo.Entities;
using System;

namespace GameProjectDemo
{
	class Program
	{
		static void Main(string[] args)
		{
			// Game'lerin Oluşturulduğu kısım 

			Game game1= new Game
			{
				GameName = "FIFA 2007",
				Category = "Spor",
				GamePrice = 350,
			};

			Game game2 = new Game
			{
				GameName = "ETS",
				Category = "Macera",
				GamePrice = 127
			};

			Game game3 = new Game
			{
				GameName = "LOL",
				Category = "AKSİYON",
				GamePrice = 225
			};


			//Kampayanların oluşturulduğu kısım

			Campaign campaign1 = new Campaign();
			campaign1.CampaingnName = "Yaz indirimi";
			campaign1.CampaingnDiscount = 10;

			Campaign campaign2 = new Campaign();
			campaign2.CampaingnName = "Hafta sonu indirimi";
			campaign2.CampaingnDiscount = 20;

			//Gamer'ların oluşturulduğu kısım

			Gamer gamer1 = new Gamer
			{
				FirstName = "Engin",
				LastName = "Demiroğ",
				NationalityId = "12345678912",
				DateOfBirth = new DateTime(1985,1,6)

			};

			Gamer gamer2 = new Gamer
			{
				FirstName = "Abdullah",
				LastName = "Dağlı",
				NationalityId = "10136788048",
				DateOfBirth = new DateTime(1993,6,15)
			};

			//Gamer'ların yönetildiği kısım(Add,Update ve Delete)

			GamerManager gamerManager = new GamerManager(new VerificationManager());
			gamerManager.Add(gamer1);
			gamerManager.Add(gamer2);
			gamerManager.Update(gamer1);


			Console.WriteLine("***********************************************************");

			//Game'ların yönetildiği ksıım

			GameManager gameManager = new GameManager();
			
			gameManager.Add(game1);

			Console.WriteLine("----------------------------------------");

			gameManager.Add(game2);

			Console.WriteLine("***************************");

			//Kampanyaların Yönetildiği Kısım

			CampaignManager campaignManager = new CampaignManager();
			campaignManager.Add(campaign1);
			campaignManager.Add(campaign2);

			Console.WriteLine("***************************");

			//Oyun satışlarının Yönetildiği kısım

			GameSaleManager gameSaleManager = new GameSaleManager();
			gameSaleManager.Sale(gamer1, game2, campaign1);

			Console.WriteLine("********************************");

			gameSaleManager.Sale(gamer1, game2, campaign2);





		}
	}
}
