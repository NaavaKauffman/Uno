using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uno
{
    public class Discard : Deck
    {
        public Card TopCard { get; set; } //top card on the pile (visible to players)

        //ctor to initilize the discard pile
        public Discard(Card topcard)
            : base()
        {
            //move from draw pile
            TopCard = topcard; //set which card is at the top
            DisplayTopCard(); //show player so they know what they can put down
        }

        //Display top card to players
        public void DisplayTopCard()
        {
            Console.WriteLine($"The top card is {TopCard}");
        }

        //Play a card by adding it to the discard pile
        /*public void PlayCard(Card playedCard)
        {
            Pile.Add(TopCard);
            TopCard = playedCard;
            DisplayTopCard();
        }*/

        //Shuffle the discard pile and return to draw pile (excluding the top card)
        public List<Card> ClearDiscard()
        {
            Shuffle();

            //create a copy of the list to return to draw pile before emptying the discard
            List<Card> newDrawPile = Pile.GetRange(0, Pile.Count);

            Pile.Clear();

            return newDrawPile;
        }

        //generate random numbers to be used in shuffling the pile- Chani: i need a shuffle for the initial deck... can we move this to the deck class?
        private static Random rand = new Random();

        //Shuffle pile
        public void Shuffle()
        {
            int n = Pile.Count;
            while (n > 1)
            {
                n--;
                int k = rand.Next(n + 1);
                Card temp = Pile[k];
                Pile[k] = Pile[n];
                Pile[n] = temp;
            }
        }

        //display method for testing purposes
        //delete this method in later copies
        public void DisplayDiscardPile(List<Card> newDrawPile)
        {
            foreach(Card card in newDrawPile)
            {
                Console.WriteLine($"{card.CardNum}");
            }
        }
    }
}
