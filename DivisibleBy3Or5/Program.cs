using System;
using System.Collections.Generic;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            //List is used for row breaks
            var rowList = new List<int>() { 15, 30, 45, 60, 75, 90 };
            //Used to determine write state
            Boolean writeI;
            Boolean isDivisibleByThree;
            Boolean isDivisibleByFive;
            Console.WriteLine();
            for (int i = 1; i <= 100; i++)
            {
                isDivisibleByThree = false;
                isDivisibleByFive = false;
                //check for remainder after division
                if (i % 3 == 0)
                {
                    isDivisibleByThree = true;
                    writeI = false;
                }
                else {
                    writeI = true;
                    isDivisibleByThree = false;
                }
                //check for remainder after division
                if (i % 5 == 0)
                {
                    writeI = false;
                    isDivisibleByFive = true;
                    
                }
                else {
                    if (isDivisibleByThree == false) {
                        writeI = true;
                    }
                    
                    isDivisibleByFive = false;
                }
                //format console write and populated with determined values
                if (writeI == true) {
                    if(i < 10){
                        //two spaces for numeric alignment
                        Console.Write("  " + i + ", ");
                    }else
                    {
                        Console.Write(" " + i + ", ");
                    }
                } else if (isDivisibleByThree && isDivisibleByFive) {
                    Console.Write(" fizzbuzz, ");
                } else if (isDivisibleByThree) {
                    Console.Write(" fizz, ");
                } else if (isDivisibleByFive) {
                    if (i < 100)
                    {
                        Console.Write(" buzz, ");
                    }
                    else
                    {
                        //Last output; remove comma
                        Console.Write(" buzz");
                        Console.WriteLine();
                        Console.WriteLine();
                    }
                }
                //Determine if ths is a new line
                if (rowList.Contains(i)) {
                    Console.WriteLine();
                }
            }//End For loop
        }//End Main
    }//End Class Program
}//End Namespace
