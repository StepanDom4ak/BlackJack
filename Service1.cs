using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace BlackJackService
{
    public class MyGame : IMyGame
    {
        public List<Card> Deck;
        public List<Player> Players;
        public int MaxCount;
        public int currentIdPlayer;
        public int roomCount = 1;
        public MyGame()
        {
            Deck = Card.CreateDeck();
            Players = new List<Player>();
            MaxCount = 3;
            currentIdPlayer = 0;
        }
        public void EnterGame(string name)
        {

        }
    }
}
