using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uno
{
    class Deck
    {
        public List<Card> Pile { get; set; }

        protected const int NUMBEROFCOLORS = 4;
        protected const int NUMBEROFCARDSINFULLDECK = 96;


        public Deck()
        {
            Pile = new List<Card>();
        }
    }
}
