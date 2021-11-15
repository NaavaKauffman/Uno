using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Uno
{
    class Play
    {
        public void TakeTurn()
        {

            PlayCard();
            DrawCard();
            CheckWin();

        }
        public void PlayCard()
        {

            Card cardSelcted;

            if (cardSelected.Color == TopCard.Color)||//last card on deck)
            {
                PlayCard (CardSelected);
                //subtract from hand
            }
            else
            {
                Console.WriteLine("This card is not valid. Draw a card.");
                DrawCard(1);
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
    }
}
