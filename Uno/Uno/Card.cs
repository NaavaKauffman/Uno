using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uno
{ //Sara Hersh
   public enum Colors { Blue = 1, Green, Red, Yellow} //this is the enum for the colors. after Blue =1, it automatically sets each color to a number. hover over it to see.
    
    public class Card
    {
        public int CardNumber { get; set; }//property CardNumber
        public Colors CardColor { get; set; }//property CardColor

        /// <summary>
        /// Card constructor
        /// </summary>
        /// <CardNumber="number"></param>
        /// <CardColor="color"></param>
        public Card(int number = 0, Colors color = Colors.Blue) 
        {
            CardNumber = number;
            CardColor = color;
        }


        //this is a bug - define color using index

        
       
        }
       
        //public override string ToString()
        //{
        //    return $"{CardNumber}, {CardColor}";//practice comment
        //}




    }
}
