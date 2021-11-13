using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uno
{
    class DrawPile : Deck
    {
        public DrawPile() : base()
        {
            Pile = BuildDeck();
        }

        public List<Card> BuildDeck()
        {
            List<Card> deck = new List<Card>();
            int cardCounter = 0;
            for (int color = 0; color < NUMBEROFCOLORS; color++)
            {
                for (int cardNumber = 1; cardNumber <= 9; cardNumber++) //
                {
                    Card card1 = new Card(color, cardNumber); //creates cards with number and color

                    deck.Add(card1);

                    cardCounter++;
                }
            }

            return deck;
        }
    }
}
