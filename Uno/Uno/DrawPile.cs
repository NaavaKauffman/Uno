using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uno
{
    public class DrawPile : Deck
    {
        public DrawPile() : base()
        {
            Pile = BuildDeck();
        }

        public List<Card> BuildDeck()
        {
            List<Card> deck = new List<Card>();
            int cardCounter = 0;
            for (int color = 0; color < NUMBEROFCOLORS; color++) //I'm not sure exactly how enumerations work but this is if we do it index style.
            {
                for (int cardNumber = 0; cardNumber<= 10; cardNumber++) //
                {
                    Card card1 = new Card(cardNumber, (Colors)color); //creates cards with number and color

                    deck.Add(card1); //two of each number 1-9
                    deck.Add(card1);
                    cardCounter++;
                }
                //Card card0 = new Card(0, color); //adds one zero per color
               // deck.Add(card0);
            }

            return deck;
        }
    }
}
