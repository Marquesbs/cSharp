using System;
using System.Globalization;

namespace Concatenacao;

class Program
{
    static void Main(string[] args)
    {
        int idade = 32;
        double saldo = 10.35784;
        string nome = "Maria";

        Console.WriteLine(nome + " tem " + idade + " anos e tem saldo igual a "+ saldo.ToString("F2", CultureInfo.InvariantCulture) + " reais");
    }
}
