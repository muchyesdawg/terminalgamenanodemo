using System;
//this is made by markus au
namespace c__nanorebellion
{
    class Program
    {
        static void Main(string[] args)
        {
          // 1 is barbarian
          // 2 is sorcerer
          // 3 is archer
          // 4 is bard
          Console.Title = "Nanorebellion";
          Console.ForegroundColor = ConsoleColor.Green;
          Console.WriteLine("what class are you? (type help for help)");
            
            string action = Console.ReadLine();
            Console.WriteLine("___________________________________________________");
            Console.WriteLine(" \     _     _     _______     _     _   _______   \ ");
            Console.WriteLine("  \    \\   / \    \ | \ \     \\   / \  \ \  \ \   \ ");
            Console.WriteLine("   \    \\ // \\    \ \_\ \     \\ // \\  \ \  \ \   \ ");
            Console.WriteLine("    \    \_/   \\    \ \ \ \     \_/   \\  \_\__\_\   \ ");
            Console.WriteLine("     \    _                                            \ ");
            Console.WriteLine("      \   \\                                            \ ");
            Console.WriteLine("       \                                                 \ ");
            Console.WriteLine("        \_________________________________________________\ ");
            Console.WriteLine("what class do you want to be? (type help for help)");
            void defineclass(){
              String class = Console.ReadLine();
              if (class == "help")
              {
                Console.WriteLine("do you want to be a fierce barbarian?")
                Console.WriteLine("or a wise sorcerer?")
                Console.WriteLine("or a speedy archer?")
                console.WriteLine("or a charismatic bard?")
                Console.WriteLine("So, what do you want to be?")
              }
              else if (class=="barbarian") {
                public float playerclass = 1;
              }
              else if (class=="sorcerer") {
                public float playerclass = 2;
              }
              else if (class=="archer") {
                public float playerclass = 3;
              }
              else if (class=="bard") {
                public float playerclass = 4;
              }
              else {
                Console.WriteLine("bruh no seriously what do you want to be?");
              }
            }
        }
    }
}
