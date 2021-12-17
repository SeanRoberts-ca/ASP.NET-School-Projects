using System;

namespace ExploringNumericTypesPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //Start Logic
            const string separator = "|";
            const string columnsFormat = "{0,1} {1,30} {2,1} {3,30} {4,1} {5,30} {6,1} {7,30} {8,1}";
            string[] types =
            {
                        typeof(sbyte).ToString(),
                        typeof(byte).ToString(),
                        typeof(short).ToString(),
                        typeof(int).ToString(),
                        typeof(ushort).ToString(),
                        typeof(uint).ToString(),
                        typeof(long).ToString(),
                        typeof(ulong).ToString(),
                        typeof(float).ToString(),
                        typeof(double).ToString(),
                        typeof(decimal).ToString()
                    };

            string[] sizes =
            {
                        sizeof(sbyte).ToString(),
                        sizeof(byte).ToString(),
                        sizeof(short).ToString(),
                        sizeof(int).ToString(),
                        sizeof(ushort).ToString(),
                        sizeof(uint).ToString(),
                        sizeof(long).ToString(),
                        sizeof(ulong).ToString(),
                        sizeof(float).ToString(),
                        sizeof(double).ToString(),
                        sizeof(decimal).ToString()
                    };

            string[] minValues =
            {
                        sbyte.MinValue.ToString(),
                        byte.MinValue.ToString(),
                        short.MinValue.ToString(),
                        int.MinValue.ToString(),
                        ushort.MinValue.ToString(),
                        uint.MinValue.ToString(),
                        long.MinValue.ToString(),
                        ulong.MinValue.ToString(),
                        float.MinValue.ToString(),
                        double.MinValue.ToString(),
                        decimal.MinValue.ToString()
                    };

            string[] maxValues =
            {
                        sbyte.MaxValue.ToString(),
                        byte.MaxValue.ToString(),
                        short.MaxValue.ToString(),
                        int.MaxValue.ToString(),
                        ushort.MaxValue.ToString(),
                        uint.MaxValue.ToString(),
                        long.MaxValue.ToString(),
                        ulong.MaxValue.ToString(),
                        float.MaxValue.ToString(),
                        double.MaxValue.ToString(),
                        decimal.MaxValue.ToString()
                    };

            //Write Header
            Console.WriteLine(columnsFormat, separator, "Type", separator, "Bytes of Memory", separator, "Min", separator, "Max", separator);

            //Write Header Divider
            for (var i = 0; i < 133; i++)
            {
                Console.Write("=");
            }

            Console.WriteLine();

            //Write Data Values
            for (var i = 0; i < types.Length; i++)
            {
                Console.WriteLine(columnsFormat, separator, types[i], separator, sizes[i], separator, minValues[i], separator, maxValues[i], separator);
            }

            //End Logic
        }//End Main
    }//End Program
}//End Namespace
