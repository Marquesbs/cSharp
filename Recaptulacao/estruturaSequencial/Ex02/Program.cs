using System;
using System.Globalization;

namespace Ex02
{
    class Program
    {
        static void Main(string[] args)
        {
            // Definindo o valor de pi conforme solicitado
            double pi = 3.14159;
            
            // Lendo o valor do raio e convertendo para double com cultura invariante
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            // Calculando a área utilizando a fórmula
            double area = pi * Math.Pow(raio, 2);

            // Exibindo o resultado com 4 casas decimais
            Console.WriteLine("A=" + area.ToString("F4", CultureInfo.InvariantCulture));
        }
    }
}
