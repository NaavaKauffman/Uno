using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uno
{
    public class Deck
    {
        public List<Card> Pile { get; set; }

        protected const int NUMBEROFCOLORS = 4;
        protected const int NUMBEROFCARDSINFULLDECK = 96;


        public Deck()
        {
            Pile = new List<Card>();
        }

        //i think instead of having separate remove and add methods for all the different piles,
        //we should have one moveCard method to avoid accidentally deleting any cards, which will
        //simultaneously add and delete a card from the correct places
        public void MoveCard(Card cardToMove, List<Card> removeFromHere, List<Card> addToHere)
        {
            removeFromHere.Remove(cardToMove);
            addToHere.Add(cardToMove);
        }
    }
}
