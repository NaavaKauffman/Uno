using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uno
{
    public class Card
    {
        public int CardNum { get; set; } //Don't worry, whoever writes the real class will
                                         //do something more normal. This is just for testing purposes.
        public int Color { get; set; }
        public int CardIndex { get; set; } // Needed in order to find the correct card
        public Card(int cardnum, int color)
        {
            CardNum = cardnum;
            Color = color; //this really should be an enum but I need something to test
        }

        //testing, testing, 123
        public override string ToString()
        {
            return $"{CardNum} {Color}";//practice comment
        }
    }
}
