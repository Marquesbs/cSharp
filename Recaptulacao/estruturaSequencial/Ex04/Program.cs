using System;
using System.Globalization;

namespace Ex04;

class Program
{
    static void Main(string[] args)
    {
        int funcionario = int.Parse(Console.ReadLine());
        int horasTrabalhadas = int.Parse(Console.ReadLine());
        double valorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        double salario = horasTrabalhadas * valorHora;

        System.Console.WriteLine("NUMBER = " + funcionario);
        System.Console.WriteLine("SALARY = U$ " + salario.ToString("F2"), CultureInfo.InvariantCulture);
    }
}
