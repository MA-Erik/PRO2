using System;

namespace _Eindresultaat
{
    class Program
    {

        // ------------------ ROCK/PAPER/SCISSORS RPG ------------------
        static void Main(string[] args)
        {


            // ---------- WELCOME SCREEN, DO ONCE -------------
            
            Console.Clear();

            Console.WriteLine("########################################################################");
            Console.WriteLine("########################################################################");
            Console.WriteLine("###########                                                  ###########");
            Console.WriteLine("###########          WELCOME TO:  'SLAY THE DEMON'!          ###########");
            Console.WriteLine("###########                                                  ###########");
            Console.WriteLine("###########            PRESS ANY KEY TO CONTINUE.            ###########");
            Console.WriteLine("###########                                                  ###########");
            Console.WriteLine("########################################################################");
            Console.WriteLine("########################################################################");
            
            // -------------------------------------------------
            
            Console.ReadLine();



            // END GAME:
            Console.Clear();
            Console.WriteLine("Thank you for playing! Press any button to exit.");
            Console.ReadKey(true);


        }
    }
}
