using System.Globalization;

namespace Ex04;

class Program
{
    static void Main(string[] args)
    {
        int numero = int.Parse(Console.ReadLine());



        for (int i = 0; i < numero; i++)
        {
            string[] valores = Console.ReadLine().Split(' ');
            int valor1 = int.Parse(valores[0]);
            int valor2 = int.Parse(valores[1]);

            if (valor2 == 0)
            {
                System.Console.WriteLine("Divisao impossivel");
            }
            else
            {
                double divisao = (double)valor1 / valor2;
                System.Console.WriteLine(divisao.ToString("F1", CultureInfo.InvariantCulture));
            }
        }
    }
}
