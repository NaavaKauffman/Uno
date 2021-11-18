using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using Uno.Discard;



namespace Uno
{
    public class Play
    {
        //I think this method belongs in game
        public void TakeTurn()
        {
            GetNextStep();
            PlayCard1();
            //DrawCard();
            CheckWin();

        }
        public void PlayCard1()
        {
            //how are we defining and determining these?
            int cardNumWanted = 0;
             int  CardColorWanted = 0;

           if ( VerifyCardInHand(cardNumWanted,CardColorWanted,Hand))

            {
                //if card can go on pile
                if (VerifyCardBelongsOnPile(cardNumWanted, CardColorWanted))//last card on deck)
                {
                    Deck.MoveCard(cardSelected, Hand, Deck.Pile); //move from hand to pile
                                                                  //PlayCard(CardSelected); //become the new topcard- ?
                }
                else
                {
                    DisplayErrorMessage();
                    NextStep();
                }

            }
           else
            {
                DisplayErrorMessage();
                NextStep();
            }
          

        }
        //Shira Laury
        public Card DrawCard()
        { 

            MoveCard(list.LastOrDefault(), Ha
                
                //card your moving, (check it's actully there-may be in move), orig decck, senconf deck .
            //Card card= list.LastOrDefault();
            //list.LastOrDefault() = 0;

        
        //public Card DrawCard()
        //{
        //    //TopCard();
        //    return list.LastOrDefault();
        //}

        public void CheckWin()
        {
            if(HandList.Count ==0)
            {
                Console.WriteLine($"{player} won!");
            }
        }

        public bool VerifyCardInHand(int cardNum, int Index, List<Card> WhereItIs)
        {
            //sep. method to see which card taken
            //Card theCardPlayed = new Card(int.Parse(), );

            //Card cardSelected; //find in hand and verify 
            foreach (var card in WhereItIs)
            {
                if ((card.CardNumber == cardNum) & (card.CCOLLLOORR==Index))
                {
                    return true;
                }
            }
            return false;
        }

        public bool VerifyCardBelongsOnPile(int cardNum, int Index)
            //again, need to define card class
        {
          if  ((Index == TopCard.Color)||(cardNum == TopCard.CardNumber))
            {
             return true;
            }

            return false;

        }

        //public string GetNextStep(bool triedBefore)
        //{

        //    Console.WriteLine("This is not a valid card option. Select your next step. Write draw or play");
        //    string response = Console.ReadLine();
        //    while ((response != "draw")|(response !="play"))
        //    {
        //        Console.WriteLine("Not a valid resonse.Write draw or play.");
        //    }
        //    return response;

        //}
        public void DisplayErrorMessage()
        {
            Console.WriteLine("This is not a valid Card. Either it is not in your hand, or it is an invalid play \n it does not match the color or number of the top card.");
        }
        public string GetNextStep()
        {

            Console.WriteLine("Choose whether to draw or play. Write draw or play.");
            string response = Console.ReadLine();
            while ((response != "draw") | (response != "play"))
            {
                Console.WriteLine("Not a valid resonse.Write draw or play.");
            }
            return response;
           

        }
        public void NextStep( )
        {
            if (GetNextStep()=="draw")
            {
                DrawCard();
            }
            else
            {
                PlayCard1(??);
            }

        }
    }

}
