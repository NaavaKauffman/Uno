using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uno
{
    public class Game
    {
        string player;
        int counter = 1;
        public Game()
        {
            counter++;
            if (counter % 2 == 0)
            {
                player = "You";
            }
            else
            {
                player = "Computer";
            }
        }

            
        
        
    }
}
