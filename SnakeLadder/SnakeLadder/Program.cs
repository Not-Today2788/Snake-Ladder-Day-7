using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeLadder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int player = 1, dice, snake, ladder;
            bool play;
            play = wannaplay();
            Random rnd = new Random();
            int count = 0;

            do
            {

                if (play)
                {

                    dice = rnd.Next(1, 7);
                    Console.WriteLine("\nNumber obtained on dice is: " + dice + "\n");
                    count++;


                    snake = RandPosition(player, rnd);
                    ladder = RandPosition(player, rnd);

                    Console.WriteLine("\nSnake Postion is: " + snake + "\n");
                    Console.WriteLine("\nladder Postion is: " + ladder + "\n");

                    player += dice;

                    if (snake == player && player != 100)
                    {
                        player -= dice; // Subtract the value obtained from the dice roll
                    }

                    else if (ladder == player && player != 100)
                    {
                        player += dice; // Add the value obtained from the dice roll
                    }

                    else if (ladder == player && snake == player)
                    {
                        Console.WriteLine("\nOpps!! Snake and Ladder conincided, please play again\n");

                    }

                    else if (player > 100)
                    {
                        player -= dice;
                    }

                    else if (player == 100)
                    {
                        break;
                    }
                    /*else
                    {
                        player += dice;
                    }*/

                    Console.WriteLine("\nYour new Position is: " + player + "\n");
                    play = wannaplay();

                }
                else
                {
                    break;
                }
            } while (play);

            Console.WriteLine("\n\nYour Final Position is: 100\n\nThe number of dice rolls: " + count + "\n\nCongratulation!! You Won!!");
            Console.ReadLine();


        }
        static bool wannaplay()
        {
            Console.WriteLine("\n\nYou wanna play?? (Yes/No) : \n");
            string userinput = Console.ReadLine().ToLower();
            return userinput == "";
        }

        static int RandPosition(int position, Random ran)
        {
            //int Min = ((position-1) / 10) * 10 + 1;
            int Min = position;
            //int Max = Math.Max(position+1, Min+10);
            int Max;
            if (position < 94)
            {
                Max = position + 6;
            }
            else
            {
                Max = 99;
            }


            if (Min <= position && position <= Max && Max < 100 && Min < 100)
            {
                return ran.Next(Min, Max);
            }
            else
            {
                return 0;
            }
        }

        

    }
}