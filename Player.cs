using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackService
{
    public class Player
    {
        public int Id { set; get; }
        public List<Card> Cards { set; get; }
        public string Name { set; get; }
        public bool isReady { set; get; }
        public bool isPass { set; get; }
        public int points = 0;

        public Player(string name)
        {
            this.Name = name;
            Cards = new List<Card>();
            this.isReady = false;
            this.isPass = false;
        }
    }
}
