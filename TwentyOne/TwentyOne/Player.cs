using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace TwentyOne
{
    public class Player
    {
        //Creating a constructor for player. Constructors go at the top of the class
        public Player(string name, int beginningBalance) 
        {
            Hand = new List<Card>();
            Balance = beginningBalance;
            Name = name;
        }
        private List<Card> _hand = new List<Card>();
        //properties usually have get and set 
        public List<Card> Hand { get { return _hand; }  set { _hand = value; } }
        public int Balance { get; set; }
        public string Name { get; set; }
        public bool isActivelyPlaying { get; set; }
        public bool Stay { get; set; }

        public bool Bet (int amount) 
        {
            if (Balance - amount < 0) 
            {
                Console.WriteLine("You do not have enough to place a bet that size");
                return false;
            }
            else 
            {
                Balance -= amount;
                return true;
            }
        }

        //overloading an operator
        public static Game operator+ (Game game, Player player)
        {
            game.Players.Add(player);
            return game;
        }
        public static Game operator- (Game game, Player player)
        {
            game.Players.Remove(player);
            return game;
        }
    }
}
