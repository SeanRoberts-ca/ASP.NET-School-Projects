using System;
using System.Text.RegularExpressions;

namespace TestingRegExes
{
    internal class RegExChecker
    {
        public static string StringRegExChecker(string strUserExpression, string strUserString)
        {
            //Assign the regex to patternChecker
            var patternChecker = new Regex(@strUserExpression);

            //thest if a match is found
            if (patternChecker.IsMatch(strUserString))
            {
                return "True";
            }
            else
            {
                return "False";
            }
        }
    }

    class Program : RegExChecker
    {
        static void Main(string[] args)
        {
            //Used for determine console exit
            ConsoleKeyInfo cki;
            do
            {
                    Console.WriteLine("The default regular expression checks for at least one digit.");
                    Console.Write("Enter a regular expression (or press ENTER to use the default): ");
                    string userExpression = Console.ReadLine();
                    if (userExpression == "") {
                        //default regex
                        userExpression = "^[a-z]+$";
                    }
                    Console.Write("Enter some input: ");
                    string userString = Console.ReadLine();
                    Console.WriteLine(userString + " matches " + userExpression + "?" + " " + StringRegExChecker(userExpression, userString));
                    Console.WriteLine("Press ESC to end or any key to try again.");
                //capture keypress in console mode    
                cki = Console.ReadKey();
                //if not escape key loop again
            } while (cki.Key != ConsoleKey.Escape);
        }//End Main
    }//End Program
}//End NameSpace