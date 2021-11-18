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
        //
    {//variables are just to make the program work the person who is in charge of creating that part hopefully will
     //make it clearer it just for testing purposes
        int cardAmnt = 7;
        int numOnCard = 0;
        int colorOnCard = 0;
        int cardPlay = 0;
        int cardOnPile = 0;

        public void st()
        {
            while (cardAmnt != 0)
            {
                if (cardPlay == numOnCard)
                {
                    Display();

                }
                else if (cardOnPile == colorOnCard)
                {
                    Display();
                }
                else
                {
                    NextTurn();
                    cardAmnt++;
                    //next turn and pick card
                }
            }
        }
        public void NextTurn()
        {
            Turn();
        }
        public int Display()
        {
            int cardAmnt = 0;
            int discardPile = 0;
            int hand = cardAmnt - discardPile;
            return hand;
            //put card down
        }
        public void Turn()
        {
            int turn = 0;
            if (turn % 2 == 0)
            {
                //player one  
            }
            else
            {
                //player two
            }
            turn++;
        }

    }

}

