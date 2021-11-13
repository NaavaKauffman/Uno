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
            UpdateCardClass();
            CheckWin();

        }
        public void PlayCard()
        {

            Card cardSelcted;
            if (cardSelected.Color == //last card on deck)
            {
                AddCard(Discard);
                //subtract from hand
            }
            else
            {
                Console.WriteLine("This card is not valid. Draw a card.");
            }

        }
    }
}
