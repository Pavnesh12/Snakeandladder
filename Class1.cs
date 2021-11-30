using System;
using System.Collections.Generic;
using System.Text;

namespace snakeandladder
{
    internal class Snakegame
    {
        int person1 = 0;
        public void diceroll()
        {
            Random random = new Random();
         
            for (int i = 0; person1 != 100; i++)
            {
                int dice = random.Next(1, 7);
                int check = random.Next(0, 3);
                if(check == 2)
                {
                    person1 -= dice;
                }
                else if(check == 1)
                {
                  person1 += dice;

                }
                else
                {
                    person1 = 0 + person1;
                }
             
                if( person1 > 101)
                {
                    person1 -= dice;
                }
                if(person1 == 100)
                {
                    Console.WriteLine("game is end in " + i + " steps");
                }

            }
        }
    }
}
