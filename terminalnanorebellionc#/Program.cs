using System;
using System.Collections.Generic;
//this is made by markus au
namespace c__nanorebellion
{
    class Program
    {
        static void Main(string[] args)
        {
            //
            // 1 is barbarian
            // 2 is sorcerer
            // 3 is archer
            // 4 is bard
            Console.Title = "Nanorebellion";
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("what class are you? (type help for help)");

            string action = Console.ReadLine();
            //ingeneral
            bool askAgain = false;

            //setting out the class
            int classint = 0;
            Console.WriteLine("what class do you want to be? (type help for help)");
            void defineclass() {
                string playerclass = Console.ReadLine();
                if (playerclass == "help")
                {
                  Console.WriteLine("do you want to be a fierce barbarian?");
                  Console.WriteLine("or a wise sorcerer?");
                  Console.WriteLine("or a speedy archer?");
                  Console.WriteLine("or a charismatic bard?");
                  Console.WriteLine("what do you want to be?");
                }
                else if(playerclass == "barbarian"){
                  classint = 1;
                }
                else if (playerclass == "sorcerer"){
                  classint = 2;
                }
                else if (playerclass == "archer"){
                  classint = 3;
                }
                else if(playerclass == "bard"){
                  classint = 4;
                }
                else{
                  askAgain = true;
                }
            }
            if(askAgain == true){
              Console.WriteLine("no seriously what do you want to be?");
              defineclass();
            }
        }
    }
}
