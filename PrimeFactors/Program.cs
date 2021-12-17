using System;

namespace PrimeFactors
{
    public class Program
    {
        static void Main(string[] args)
        {

        string input;
        bool doRunProgram = true;
        

        Console.WriteLine("Type 'x' to end console read.");

        while (doRunProgram)
        {
            
            Console.Write("Enter a positive integer: ");
            input = Console.ReadLine();

            //check for exit 
            if (input.Equals("x", StringComparison.OrdinalIgnoreCase))
            {
                //Exit Program
                doRunProgram = false; 
            }
            else {
                    //Calc prime numbers
                    GetPrimeFactors(input);
            }//End check for exit

        }//End While loop
        }//End Main

        public static string GetPrimeFactors(string number)
        {
            int myResult = 1;
            long unchangedNumber;
            string myCalculatedString = "";

            if (number != "")
            {
                try
                {

                    var myNumber = Int64.Parse(number);
                    unchangedNumber = myNumber;

                    Console.Write($"Prime Factors of {myNumber} are: ");

                    for (int count = 2; myNumber > 1; count++)
                    {

                        while (myNumber % count == 0)
                        {
                            //Current number
                            Console.Write(count);

                            myNumber /= count;

                            //Used for Debugging
                            myCalculatedString += count;

                            //Check to see if an 'x' is needed
                            myResult *= count;
                            if (myResult < unchangedNumber)
                            {
                                myCalculatedString += " x ";
                                Console.Write(" x ");
                            }

                        }//End While Loop

                    }//End For Loop
                     //Console.WriteLine(myCalculatedString);
                }
                catch (OverflowException)
                {
                    Console.WriteLine("{0} is outside the range of the Int64 type.", number);
                }
                catch (FormatException)
                {
                    Console.WriteLine("The {0} value '{1}' is not in a recognizable format.", number.GetType().Name, number);
                }
            }//End check for empty string.

            Console.WriteLine();

            return myCalculatedString;

    }//End CalcPrimeFactors
}//End Program
}//End Namespace