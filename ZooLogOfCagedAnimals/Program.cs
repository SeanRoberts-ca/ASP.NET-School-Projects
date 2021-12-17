using System;
using System.Collections.Generic;
using System.Linq;

namespace Zoo
{
    class Program
    {
        static void Main(string[] args)
        {

            List<IAnimal> CageList = new();
            
            Wolf CagedWolf = new Wolf(9, "Wolf", 20);
            Lion CagedLion = new Lion(6, "Lion", "Red");
            Bear CagedBear = new Bear(12, "Bear", true);

            for (int i = 1; i <= 3; i++) { 
                string species;
                Console.WriteLine();
                Console.WriteLine("Cage "+i);
                Console.Write("What is the animal’s species? ");
                species = Console.ReadLine();
                if (species.Equals("Wolf", StringComparison.CurrentCultureIgnoreCase)) {
                    //Wolf
                    string value;
                    int numericInt = 0;
                    string strAge;
                    int intAge = 0;
                    
                    Console.Write("How old is it ? ");
                    strAge = Console.ReadLine();
                    try {
                        intAge = Int32.Parse(strAge);
                    }
                    catch (OverflowException)
                    {
                        Console.WriteLine("{0} is not a numeric value, use digits.", intAge);
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("The {0} value '{1}' is not a numeric value, use digits.", intAge.GetType().Name, intAge);
                    }
                    value = CagedWolf.RequestUniqueCharacteristic();
                    try
                    {
                        numericInt = Int32.Parse(value);
                    }
                    catch (OverflowException)
                    {
                        Console.WriteLine("{0} is not a numeric value, use digits.", numericInt);
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("The {0} value '{1}' is not a numeric value, use digits.", numericInt.GetType().Name, numericInt);
                    }
                    CagedWolf.Speed = numericInt;
                    CagedWolf.Age = intAge;
                    CageList.Add(CagedWolf);
                }
                else if(species.Equals("Lion", StringComparison.CurrentCultureIgnoreCase))
                {
                    //Lion
                    string value;
                    string strAge;
                    int intAge = 0;
                    
                    Console.Write("How old is it ? ");
                    strAge = Console.ReadLine();
                    try
                    {
                        intAge = Int32.Parse(strAge);
                    }
                    catch (OverflowException)
                    {
                        Console.WriteLine("{0} is not a numeric value, use digits.", intAge);
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("The {0} value '{1}' is not a numeric value, use digits.", intAge.GetType().Name, intAge);
                    }
                    value = CagedLion.RequestUniqueCharacteristic();
                    CagedLion.ManeColour = value;
                    CagedLion.Age = intAge;
                    CageList.Add(CagedLion);
                }
                else if(species.Equals("Bear", StringComparison.CurrentCultureIgnoreCase))
                {
                    //Bear
                    bool value;
                    string strAge;
                    int intAge = 0;
                    
                    Console.Write("How old is it ? ");
                    strAge = Console.ReadLine();
                    try
                    {
                        intAge = Int32.Parse(strAge);
                    }
                    catch (OverflowException)
                    {
                        Console.WriteLine("{0} is not a numeric value, use digits.", intAge);
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("The {0} value '{1}' is not a numeric value, use digits.", intAge.GetType().Name, intAge);
                    }
                    value = bool.Parse(CagedBear.RequestUniqueCharacteristic());
                    CagedBear.IsGrizzly = value;
                    CagedBear.Age = intAge;
                    CageList.Add(CagedBear);
                }
                else
                {
                    //Other
                    Console.Write("You have enter an unhandled animal species. ");
                }
            }//End For loop

            Console.WriteLine();
            Console.WriteLine("=====");
            Console.WriteLine();

            for (int i = 1; i <= 3; i++)
            {
                try
                {
                    int myInt = i;
                    string myString = myInt.ToString();
                    Console.WriteLine("{0}", CageList.ElementAt(i - 1).GetDescription(myString));
                }
                catch (ArgumentOutOfRangeException)
                {
                    Console.WriteLine("An unhandled error occured.");
                }
                catch (FormatException)
                {
                    Console.WriteLine("An unhandled error occured.");
                }
            }

            Console.WriteLine();
            Console.WriteLine();

        }//End Main
    }//End Program
}//End Namespace