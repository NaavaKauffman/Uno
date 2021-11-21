using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uno
{
    //build hand
    //use move method to move 7 cards from draw to hand
    //display
    public class Hand

        //method that moves from deck to hand
       
    {
       
        public List<PlayerPile> PersonalPile { get; set; }
        public Hand()
            : base()
        {
            DrawPile = PlayerPile;
            Random cards = new Random(7);
            for (int i = 0; i < 8; i++)
            {
                PlayerPile++;
                DrawPile--;
            }
        }




        //public void st()
        //{
        //    while (cardAmnt != 0)
        //    {
        //        if (cardPlay == numOnCard)
        //        {
        //            Display();

        //        }
        //        else if (cardOnPile == colorOnCard)
        //        {
        //            Display();
        //        }
        //        else
        //        {
        //            NextTurn();
        //            cardAmnt++;
        //            //next turn and pick card
        //        }
        //    }
        //}




        //public void NextTurn()
        //{
        //    Turn();
        //}
        //public int Display()
        //{
        //    int cardAmnt = 0;
        //    int discardPile = 0;
        //    int hand = cardAmnt - discardPile;
        //    return hand;
        //    //put card down
        //}
        //public void Turn()
        //{
        //    int turn = 0;
        //    if (turn % 2 == 0)
        //    {
        //        //player one  
        //    }
        //    else
        //    {
        //        //player two
        //    }
        //    turn++;
        //}

    }

}

