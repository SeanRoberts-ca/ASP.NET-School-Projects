using System;
using System.Linq;
using System.Numerics;

namespace BigIntegerExtended
{
    class Program
    {
        static void Main(string[] args)
        {
            //Used for determine console exit
            ConsoleKeyInfo cki;
            do
            {
                Console.Write("Enter a number with or without commas and no decimals: ");
                string userInput = Console.ReadLine();
                if (userInput == "")
                {
                    Console.WriteLine("Enter a number with or without commas and no decimals: ");
                    userInput = Console.ReadLine();
                }
                userInput = RemoveChar(userInput);
                Console.WriteLine(userInput.ToWords());
                Console.WriteLine(FormatString(userInput));
                Console.WriteLine();
                Console.WriteLine("Press ESC to end or any key to try again.");
                //capture keypress in console mode    
                cki = Console.ReadKey();
                //if not escape key loop again
            } while (cki.Key != ConsoleKey.Escape);

            // Keep console window open in debug mode  
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();

        }//End Main

        public static string RemoveChar(string myOriginalString)
        {
            string myOriginalString2 = myOriginalString.Replace(",", "");
            return myOriginalString2;
        }
        public static string FormatString(string myOriginalString)
        {
            var myOriginalString2 = BigInteger.Parse(myOriginalString);
            var myOriginalString3 = $"{myOriginalString2,40:N0}";
            return myOriginalString3.ToString(); ;
        }


    }//End Program
}//End Namespace
