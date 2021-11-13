using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uno
{
    class Card
    {
        public int CardNum { get; set; } //Don't worry, whoever writes the real class will
                                         //do something more normal. This is just for testing purposes.

        public Card(int cardnum)
        {
            CardNum = cardnum;
        }

        //testing, testing, 123
        public override string ToString()
        {
            return $"{CardNum}";//practice comment
        }
    }
}
