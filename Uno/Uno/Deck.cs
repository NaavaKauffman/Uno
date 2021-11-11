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

        public Deck()
        {
            Pile = new List<Card>();
        }
    }
}
