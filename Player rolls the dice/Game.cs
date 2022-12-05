using System;
using System.Collections.Generic;
using System.Text;

namespace Player_rolls_the_dice
{
    internal class Game
    {
       static int player1, position = 0;
       static Random random= new Random();
       public static void Turn()
        { 
         int player1=random.Next(1,7);
            Console.WriteLine(player1);
        }

    }
}
