using System;
using System.Globalization;

namespace Ex07;

class Program
{
    static void Main(string[] args)
    {
        string[] vetor = Console.ReadLine().Split(' ');
        float valorX = float.Parse(vetor[0], CultureInfo.InvariantCulture);
        float valorY = float.Parse(vetor[1], CultureInfo.InvariantCulture);

        if(valorX == 0.0 && valorY == 0.0)
        {
            System.Console.WriteLine("Origem");
        }
        
        else if (valorX > 0.0)
        {
            if (valorY > 0.0)
            {
                System.Console.WriteLine("Q1");
            }
            else
            {
                System.Console.WriteLine("Q4");
            }
        }
        
        else if (valorX < 0.0)
        {
            if (valorY > 0.0)
            {
                System.Console.WriteLine("Q2");
            }
            else
            {
                System.Console.WriteLine("Q3");
            }
        }
    }
}
