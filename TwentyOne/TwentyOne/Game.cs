using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace TwentyOne
{
    public abstract class Game
    {
        //spelling prop and hitting tab button twice will shorten this process
        public List<Player> Players { get; set; }
        public string Name { get; set; }
        public string Dealer { get; set; }
        //creating an abstract method
        public abstract void Play();

        public virtual void ListPlayers()
        {
            foreach (Player player in Players)
            {
                Console.WriteLine(player);
            }
        }
    }
}
