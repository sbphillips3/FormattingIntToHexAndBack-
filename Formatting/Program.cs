/* Sean Phillips
 * 06/18/2019
 */
using System;
using static System.Console;

namespace Formatting
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 7654321;
            WriteLine($"This is the number as an formatted int:       {num:n}");// Formated number with the :n --with two decimal places
            WriteLine($"This is the number formated as a hexadecimal: {num:x}");// Same number formated as hexadecimal

            string hexiValue = num.ToString("X");

            int numConverted = int.Parse(hexiValue, System.Globalization.NumberStyles.HexNumber);

            WriteLine($"And the number converted back using Parse:    {numConverted:n}"); // Same number converted back and formated with :n

            ReadLine();
        }
    }
}
