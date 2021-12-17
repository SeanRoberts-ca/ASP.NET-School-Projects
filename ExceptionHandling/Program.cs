using System;
using System.Collections.Generic;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            //Used to get user input
            var stringList = new List<string>() { "", "" };
            Console.WriteLine("Type 'exit' to close console window.");

            var input = "";
            int counter = 0;
            string concatenation = "a";

            while (true)
            {

                if (counter == 0)
                {
                    concatenation = "a";
                }
                else {
                    concatenation = "another";
                }

                Console.Write("Enter "+ concatenation + " number between 0 and 255: ");

                input = Console.ReadLine();
                if (input.Equals("exit", StringComparison.OrdinalIgnoreCase))
                {
                    Environment.Exit(0);
                    break;
                }//End check for exit
                else {
                    //Save input to list @position 0 or 1
                    stringList[counter] = input;
                }
                
                Console.WriteLine();

                //START ERROR CHECKING///////////////////////////////////////////////////////////////////

                int result;
                int counterfor = 0;
                var intList = new List<int>() { 0, 0 };
                Boolean doSkipCalculation = false;
                foreach (string value in stringList)
                {
                if (value != "") {
                    try
                    {
                        result = Convert.ToInt32(stringList[counterfor]);
                        //Console.WriteLine("Converted the {0} value '{1}' to the {2} value {3}.",value.GetType().Name, value, result.GetType().Name, result);
                        intList[counterfor] = result;
                    }
                    catch (OverflowException)
                    {
                        Console.WriteLine("{0} is outside the range of the Int32 type.", value);
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("The {0} value '{1}' is not in a recognizable format.", value.GetType().Name, value);
                    }
                }//End check for empty string.
                counterfor++;
                }//End foreach stringList
                if (counter == 1 && doSkipCalculation == false)
                {
                    int calcResult = 0;
                    try
                    {
                       //Added this check post submission...
                        if (intList[0] < 256 && intList[1] < 256) {
                            calcResult = intList[0] / intList[1];
                            Console.WriteLine(intList[0] + " divided by " + intList[1] + " is " + calcResult);
                        }
                        else
                        {
                            Console.WriteLine("Number must be between 0 and 255.");
                        }
                    }
                    catch(DivideByZeroException)
                    {
                        Console.WriteLine("Cannot divide by zero. Try a positive number.");
                    }
                    Console.WriteLine();
                    Console.WriteLine();
                }
                
                // The example displays the following output:
                //    The String value 'One' is not in a recognizable format.
                //    The String value '1.34e28' is not in a recognizable format.
                //    The String value '-26.87' is not in a recognizable format.
                //    Converted the String value '-18' to the Int32 value -18.
                //    The String value '-6.00' is not in a recognizable format.
                //    Converted the String value ' 0' to the Int32 value 0.
                //    Converted the String value '137' to the Int32 value 137.
                //    The String value '1601.9' is not in a recognizable format.
                //    Converted the String value '2147483647' to the Int32 value 2147483647.

                //END ERROR CHECKING///////////////////////////////////////////////////////////////////

                counter++;

                if (counter > 1)
                {
                    counter = 0;
                }

            }//End While loop
        }//End Main
    }//End Program
}//End Namespace