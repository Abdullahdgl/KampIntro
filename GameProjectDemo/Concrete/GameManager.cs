using GameProjectDemo.Abstract;
using GameProjectDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace GameProjectDemo.Concrete
{
	public class GameManager : IGameService
	{
		public void Add(Game game)
		{
			Console.WriteLine(game.GameName + " Adlı oyun eklendi. \n" + " Fiyati " + game.GamePrice + " \n Kategori" + game.Category);

		}

		public void Delet(Game game)
		{
			Console.WriteLine(game.GameName + " Oyun Kaldırıldı.");
		}

		public void Update(Game game)
		{
			Console.WriteLine(game.GameName + " Oyun Güncellendi.");
		}
	}
}
