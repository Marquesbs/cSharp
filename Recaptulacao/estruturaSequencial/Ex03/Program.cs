using System;
using System.Globalization;

namespace Ex03;

class Program
{
    static void Main(string[] args)
    {
        int num1 = int.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
        int num2 = int.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
        int num3 = int.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
        int num4 = int.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
        int diferenca = ((num1 * num2) - (num3 * num4));

        System.Console.WriteLine("DIFERENCA = " + diferenca.ToString(CultureInfo.InvariantCulture));
    }
}
