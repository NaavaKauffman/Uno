﻿using System;
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
            Card theCardPlayed = new Card(int.Parse(), );

            Card cardSelected; //find in hand and verify 
            foreach 

            if ((cardSelected.Color == TopCard.Color)||(cardSelected.CardNum == TopCard.Color))//last card on deck)
            {
                Move(cardSelected, Hhand, Discard);
                PlayCard(CardSelected);

            }
            else
            {
                Console.WriteLine("This card is not valid. Draw a card.");
                DrawCard(1);
            }

        }
        //Shira Laury
        public Card DrawCard()
        { 

            MoveCard(list.LastOrDefault(), Ha
                
                //card your moving, (check it's actully there-may be in move), orig decck, senconf deck .
            //Card card= list.LastOrDefault();
            //list.LastOrDefault() = 0;

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
