using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackClassLibrary
{
	public class Player
	{
		public Hand Hand { get; set; }
		public int PlayerType { get; set; }
		public int CurrentScore {  get; set; }
		public int TargetScore { get; set; }

		public enum PlayerTypeEnum
		{
			Dealer = 0,
			TablePlayer = 1,
		}

		public Player(Hand hand, PlayerTypeEnum playerTypeEnum)
		{
			this.Hand = hand;
			this.PlayerType = (int)playerTypeEnum;
		}
	}
}
