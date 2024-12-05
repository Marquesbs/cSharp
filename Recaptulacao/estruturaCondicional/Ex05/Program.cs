namespace Ex05;

class Program
{
    static void Main(string[] args)
    {
        string[] vetor = Console.ReadLine().Split(' ');
        int codigoItem = int.Parse(vetor[0]);
        int quantidade = int.Parse(vetor[1]);
        double valorTotal = 0.0;

        if (codigoItem == 1)
        {
            valorTotal = 4.00 * quantidade; 
        }
        else if (codigoItem == 2)
        {
            valorTotal = 4.50 * quantidade;
        }
        else if(codigoItem == 3)
        {
            valorTotal = 5.00 * quantidade;
        }
        else if(codigoItem == 4)
        {
            valorTotal = 2.00 * quantidade;
        }
        else if(codigoItem == 5)
        {
            valorTotal = 1.50 * quantidade;
        }
        System.Console.WriteLine($"Total: R$ {valorTotal:F2}");
    }
}
