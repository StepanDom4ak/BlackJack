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
            if (Players.Count < MaxCount)
            {
                Console.WriteLine("Waiting for empty place");
                return;
            }

            Player player = new Player(name);
            Players.Add(player);
            Players[Players.Count - 1].Id = Players.Count;
        }

        public void ExitGame(int playerId)
        {
            for (int i = 0; i < Players.Count; i++)
            {
                if (Players[i].Id == playerId)
                {
                    Players.RemoveAt(playerId);
                    break;
                }
            }
        }

        public void Ready(int playerId)
        {
            for (int i = 0; i < Players.Count; i++)
            {
                if (Players[i].Id == playerId)
                {
                    if(Players[i].isReady == true)
                        Players[i].isReady = false;
                    else
                        Players[i].isReady = false;

                    break;
                }
            }
        }

        public void Pass(int playerId)
        {
            for (int i = 0; i < Players.Count; i++)
            {
                if (Players[i].Id == playerId)
                {
                    Players[i].isPass = true;
                    break;
                }
            }
        }

        public Card GiveCard(int playerId)
        {
            Card card = Deck[Deck.Count - 1];
            Deck.RemoveAt(Deck.Count - 1);
            return card;
        }

    }
}
