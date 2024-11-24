namespace Placeholders;

class Program
{
    static void Main(string[] args)
    {
        int idade = 32;
        double saldo = 10.35784;
        string nome = "Maria";

        System.Console.WriteLine("{0} tem {1} anos e tem saldo igual a {2:F2} reais.", nome, idade, saldo);
    }
}
