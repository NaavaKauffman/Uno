using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uno
{
    //NOTE: This whole driver class is for testing purposes. Can be deleted once the different elements of the project are joined.
    class Program
    {
        static void Main(string[] args)
        {
            //test out discard pile
            Card tester = new Card(1, 8);
            Discard pile = new Discard(tester);
            DrawPile deck = new DrawPile();

            //test play card method
            Card tester2 = new Card(2);
            Card tester3 = new Card(3);
            Card tester4 = new Card(4);
            Card tester5 = new Card(5);
            Card tester6 = new Card(6);
            Card tester7 = new Card(7);
            Card tester8 = new Card(8);
            pile.PlayCard(tester2);
            pile.PlayCard(tester3);
            pile.PlayCard(tester4);
            pile.PlayCard(tester5);
            pile.PlayCard(tester6);
            pile.PlayCard(tester7);
            pile.PlayCard(tester8);

            //test shuffle
            pile.ClearDiscard();

            //test build deck
            foreach (Card c in deck.Pile)
            {
                Console.WriteLine(c);
            }

            Console.ReadLine();
        }
    }
}
