using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace TwentyOne
{
    //To inherit from another class all you have to do is add a colon and the name
    //of the class you're  inheriting from
    public class TwentyOneGame : Game, IWalkAway
    {
        public override void Play() 
        {
            throw new NotImplementedException();
        }
        public override void ListPlayers()
        {
            Console.WriteLine("21 Players: ");
            base.ListPlayers();
        }
        public void WalkAway(Player player) 
        {
            throw new NotImplementedException();
        }
    }
}
