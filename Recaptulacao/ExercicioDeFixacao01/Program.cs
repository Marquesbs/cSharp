using System;
using System.Globalization;

namespace ExercicioDeFixacao01;

class Program
{
    static void Main(string[] args)
    {
        string produto1 = "Computador";
        string produto2 = "Mesa de escritório";

        byte idade = 30;
        int codigo = 5290;
        char genero = 'M';

        double preco1 = 2100.0;
        double preco2 = 650.50;
        double medida = 53.234567;

        System.Console.WriteLine("Produtos:");
        System.Console.WriteLine($"{produto1}, cujo preço é R${preco1:F2}");
        System.Console.WriteLine("{0}, cujo preço é R$ {1:F2}", produto2, preco2);
        System.Console.WriteLine("Registro: " + idade + " anos de idade, código " + codigo + " e genero: " + genero);

        System.Console.WriteLine("Medida com oito casas decimais: {0:F8}", medida);
        System.Console.WriteLine($"Arredondado (três casas decimais): {medida:F3}");
        System.Console.WriteLine("Separador decimal invariant culture: " + medida.ToString("F3", CultureInfo.InvariantCulture));
    }
}
