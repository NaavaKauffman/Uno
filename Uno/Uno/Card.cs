using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uno
{
    public class Card
    {

        string[] CardColor = { "Red", "Yellow", "Green", "Blue" };

        public int CardNumber { get; set; } 
        //public string CardColor { get; set; }
        
        /*public enum Color
        {
            Red, Blue, Green, Yellow
        }
*/
        //this is a bug - define color using index
        public Card(int number, string color)
        {
            CardNumber = number;
            CardColor= color;
           
        }
       
        //public override string ToString()
        //{
        //    return $"{CardNumber}, {CardColor}";//practice comment
        //}




    }
}
