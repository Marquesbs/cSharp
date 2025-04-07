using System;
using System.Globalization;

namespace Ex06;

class Program
{
    static void Main(string[] args)
    {
        double valorQualquer = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); //leitura de valor


        //System.Console.WriteLine("Você Digitou: " + valorQualquer, CultureInfo.InvariantCulture);

        if (valorQualquer >= 0.0 && valorQualquer <= 25.0)
        {
            System.Console.WriteLine("Intervalo [0, 25]");
        }
        else if (valorQualquer > 25.0 && valorQualquer <= 50.0)
        {
            System.Console.WriteLine("Intervalo [25, 50]");
        }
        else if (valorQualquer > 50.0 && valorQualquer <= 75.0)
        {
            System.Console.WriteLine("Intervalo [50, 75]");
        }
        else if (valorQualquer > 75.0 && valorQualquer <= 100.0)
        {
            System.Console.WriteLine("Intervalo [75, 100]");
        }
        else
        {
            System.Console.WriteLine("Fora de intervalo");
        }
    }
}
