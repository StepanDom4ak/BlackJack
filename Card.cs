using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BlackJackService
{
    public enum Suit
    {
        [XmlEnum(Name = "Spades")]
        SPADES,
        [XmlEnum(Name = "Clubs")]
        CLUBS,
        [XmlEnum(Name = "Diamonds")]
        DIAMONDS,
        [XmlEnum(Name = "Hearts")]
        HEARTS
    };
    public class Card
    {
        public string Title { set; get; }
        public Suit Suit { set; get; }
        public int Value { set; get; }

        public Card()
        {
            Title = "123";
            Suit = Suit.CLUBS;
            Value = 0;
        }
        public Card(Card card)
        {
            Title = card.Title;
            Suit = card.Suit;
            Value = card.Value;
        }
        private Card(string title, Suit suit)
        {
            this.Title = title;
            this.Suit = suit;
            switch (this.Title)
            {
                case "a":
                    this.Value = 11;
                    break;
                case "k":
                    this.Value = 4;
                    break;
                case "q":
                    this.Value = 3;
                    break;
                case "j":
                    this.Value = 2;
                    break;
                default:
                    this.Value = Convert.ToInt32(this.Title);
                    break;
            }
            string letter = "";
            switch (this.Suit)
            {
                case Suit.SPADES:
                    letter = "s";
                    break;
                case Suit.CLUBS:
                    letter = "c";
                    break;
                case Suit.DIAMONDS:
                    letter = "d";
                    break;
                case Suit.HEARTS:
                    letter = "h";
                    break;
            }
        }

        public static List<Card> CreateDeck()
        {
            string[] Names = {"sa","sk","sq","sj","s10","s9","s8","s7","s6",
                             "ca","ck","cq","cj","c10","c9","c8","c7","c6",
                             "da","dk","dq","dj","d10","d9","d8","d7","d6",
                             "ha","hk","hq","hj","h10","h9","h8","h7","h6"};
            Random rnd = new Random();
            string[] MyRandomArray = Names.OrderBy(x => rnd.Next()).ToArray();
            List<Card> Deck = new List<Card>();
            for (int i = 0; i < 36; i++)
            {
                String title = MyRandomArray[i].Substring(1);
                Suit suit = Suit.HEARTS;
                switch (MyRandomArray[i].Substring(0, 1))
                {
                    case "s":
                        suit = Suit.SPADES;
                        break;
                    case "c":
                        suit = Suit.CLUBS;
                        break;
                    case "d":
                        suit = Suit.DIAMONDS;
                        break;
                    case "h":
                        suit = Suit.HEARTS;
                        break;
                }
                Deck.Add(new Card(title, suit));
            }
            return Deck;
        }
    }
}
