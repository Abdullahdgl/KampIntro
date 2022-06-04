using GameProjectDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectDemo.Abstract
{
	public interface IGameSaleService
	{
		void Sale(Gamer gamer, Game game, Campaign campaign);
	}
}
