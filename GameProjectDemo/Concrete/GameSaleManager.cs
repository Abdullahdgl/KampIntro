using GameProjectDemo.Abstract;
using GameProjectDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectDemo.Concrete
{
	public class GameSaleManager : IGameSaleService
	{
		public void Sale(Gamer gamer, Game game, Campaign campaign)
		{
			double newPrice = game.GamePrice -  (game.GamePrice * (campaign.CampaingnDiscount/100));
			Console.WriteLine(game.GameName + " Oyunu" + gamer.FirstName + gamer.LastName + " Kişisine satıldı.");
			Console.WriteLine("Oyunun indirimli fiyatı : " + newPrice + " TL");
			Console.WriteLine("Uygulanan indirim fiyatı : " + game.GamePrice * (campaign.CampaingnDiscount / 100) + " TL ");
		}
	}
}
