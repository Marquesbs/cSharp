using System.Globalization;

namespace Ex05;

class Program
{
    static void Main(string[] args)
    {
        string[] vetor1 = Console.ReadLine().Split(' ');
        int codigoPeca1 = int.Parse(vetor1[0]);
        int quantidadePeca1 = int.Parse(vetor1[1]);
        double valorPeca1 = double.Parse(vetor1[2], CultureInfo.InvariantCulture);

        string[] vetor2 = Console.ReadLine().Split(' ');
        int codigoPeca2 = int.Parse(vetor2[0]);
        int quantidadePeca2 = int.Parse(vetor2[1]);
        double valorPeca2 = double.Parse(vetor2[2], CultureInfo.InvariantCulture);

        double valorTotal = (quantidadePeca1 * valorPeca1) + (quantidadePeca2 * valorPeca2);

        System.Console.WriteLine("VALOR A PAGAR: R$ " + valorTotal.ToString("F2"), CultureInfo.InvariantCulture);
    }
}
