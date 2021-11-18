using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uno.Discard;


namespace Uno
{
    public class Play
    {
        public void TakeTurn()
        {

            PlayCard1();
            DrawCard();
            CheckWin();

        }
        public void PlayCard1(string cardWanted)
        {
            VerifyCardInHand();           


                    //if card can go on pile
            if (VerifyCardBelongsOnPile())//last card on deck)
            {
                Move(cardSelected, Hhand, Discard); //move from hand to pile
                PlayCard(CardSelected); //become the new topcard- ?

            }
            else
            {
                Console.WriteLine("This card is not valid. Draw a card."); //will be separate method, will also offer trying a different card
                DrawCard(1);  //Draw 1 card
            }

        }

        public Card DrawCard(Card[] list)
        {
            return list.LastOrDefault();
        }

        public void CheckWin()
        {
            if(HandList.Count ==0)
            {
                Console.WriteLine($"{player} won!");
            }
        }

        public bool VerifyCardInHand()
        {
            //sep. method to see which card taken
            Card theCardPlayed = new Card(int.Parse(), );

            Card cardSelected; //find in hand and verify 
            foreach
        }

        public bool VerifyCardBelongsOnPile()
        {
            (cardSelected.Color == TopCard.Color)||(cardSelected.CardNum == TopCard.Color)

        }
    }

}
