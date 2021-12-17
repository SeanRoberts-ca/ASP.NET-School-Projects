using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace BigIntegerExtended
{
    static class StringExtention
    {
        public static string ToWords(this string myOriginalString)
        {
            //int count = myOriginalString.Count(f => f == ',');
            //string commaCount = count.ToString();

        string[] ones =
        {
            "zero",
            "one",
            "two",
            "three",
            "four",
            "five",
            "six",
            "seven",
            "eight",
            "nine"
        };

        string[] teens =
        {
            "ten",
            "eleven",
            "twelve",
            "thirteen",
            "fourteen",
            "fifteen",
            "sixteen",
            "seventeen",
            "eighteen",
            "nineteen"
        };

        string[] tens =
        {
            "",
            "ten",
            "twenty",
            "thirty",
            "forty",
            "fifty",
            "sixty",
            "seventy",
            "eighty",
            "ninety"
        };


        string[] thousands =
        {
            "",
            "thousand",
            "million",
            "billion",
            "trillion",
            "quadrillion",
            "quintillion",
            "sextillion",
            "septillion",
            "octillion",
            "nonillion",
            "cecillion",
            "undecillion",
            "duodecillion",
            "tredecillion",
            "quattuordecillion",
            "quindecillion",
            "Sexdecillion",
            "septendecillion",
            "octodecillion",
            "novemdecillion",
            "vigintillion",
            "centillion"
        };

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            string numbers, temp;
            bool showThousands;
            bool isZeros = true;


            StringBuilder builder = new StringBuilder();

            numbers = myOriginalString.ToString().Trim();

            // Traverse characters in reverse order
            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                int ndigit = (int)(numbers[i] - '0');
                int column = (numbers.Length - (i + 1));

                // Determine if ones, tens, or hundreds column
                switch (column % 3)
                {
                    case 0:        // Ones position
                        showThousands = true;
                        if (i == 0)
                        {
                            // First digit - last in loop
                            temp = String.Format("{0} ", ones[ndigit]);
                        }
                        else if (numbers[i - 1] == '1')
                        {
                            // This digit is part of "teen" value
                            temp = String.Format("{0} ", teens[ndigit]);
                            // Skip tens position
                            i--;
                        }
                        else if (ndigit != 0)
                        {
                            // Any non-zero digit
                            temp = String.Format("{0} ", ones[ndigit]);
                        }
                        else
                        {
                            // This digit is zero. If digit in tens and hundreds
                            // column are also zero, don't show "thousands"
                            temp = String.Empty;
                            // Test for non-zero digit in this grouping
                            if (numbers[i - 1] != '0' || (i > 1 && numbers[i - 2] != '0'))
                                showThousands = true;
                            else
                                showThousands = false;
                        }

                        // Show "thousands" if non-zero in grouping
                        if (showThousands)
                        {
                            if (column > 0)
                            {
                                temp = String.Format("{0}{1}{2}",
                                    temp,
                                    thousands[column / 3],
                                    isZeros ? " " : ", ");
                            }
                            // Indicate non-zero digit encountered
                            isZeros = false;
                        }
                        builder.Insert(0, temp);
                        break;

                    case 1:        // Tens column
                        if (ndigit > 0)
                        {
                            temp = String.Format("{0}{1}",
                                tens[ndigit],
                                (numbers[i + 1] != '0') ? "-" : " ");
                            builder.Insert(0, temp);
                        }
                        break;

                    case 2:        // Hundreds column
                        if (ndigit > 0)
                        {
                            temp = String.Format("{0} hundred ", ones[ndigit]);
                            builder.Insert(0, temp);
                        }
                        break;
                }
            }

            try
            {
                return String.Format("{0}{1}",
                    Char.ToUpper(builder[0]),
                    builder.ToString(1, builder.Length - 1));
            }
            catch {
                return "An unexpected value was passed to the program. Please try again.";
            }

            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////    

        }

    }
}
