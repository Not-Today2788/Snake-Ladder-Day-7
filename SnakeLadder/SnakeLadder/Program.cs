using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeLadder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool play;
            play = wannaplay();
            if (play)
            do
            {
                if(play)
                {
                    
                   
                        if (play)
                        {
                            Random rnd = new Random();
                            int ran = rnd.Next(1, 6);
                            Console.WriteLine("\n"+ran+"\n");
                            play = wannaplay();
                        }
                        else
                        {
                            break;
                        }
                }
            } while (play);
            Console.ReadLine();




        }
        static bool wannaplay()
        {
            Console.WriteLine("You wanna play?? (Yes/No) : \n");
            string userinput = Console.ReadLine().ToLower();
            return userinput == "yes";
        }
    }
}
