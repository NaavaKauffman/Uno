using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uno
{
    public class Card
    {
        


        public const int BLUE = 1;
        public const int GREEN = 2;
        public const int RED = 3;
        public const int YELLOW = 4;

        int[] CardColor = { 1, 2, 3, 4 };
        

        public int CardNumber { get; set; }
       //public int CardColor { get; set; }


        public Card(int number, int color)
        {
            CardNumber = number;
            CardColor = color;//may want to make this the index of CardColor array equal color. Like indexOfColor = color. Or make set array as CardColor[color] somehow.
        }


        //this is a bug - define color using index

        
       
        }
       
        //public override string ToString()
        //{
        //    return $"{CardNumber}, {CardColor}";//practice comment
        //}




    }
}
