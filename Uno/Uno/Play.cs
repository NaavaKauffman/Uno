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
            //UpdateCardClass();
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
        //Shira Laury
        public Card DrawCard(Card[] list)
        {

            Move(list.LastOrDefault(),
                
                //card your moving, (check it's actully there-may be in move), orig decck, senconf deck .
            Card card= list.LastOrDefault();
            list.LastOrDefault() = 0;
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
