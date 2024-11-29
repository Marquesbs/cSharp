namespace Ex03;

class Program
{
    static void Main(string[] args)
    {
        string[] vetor = Console.ReadLine().Split(' ');
        int valorA = int.Parse(vetor[0]);
        int valorB = int.Parse(vetor[1]);

        if (valorA > valorB)
        {
            int resultado = valorA % valorB;
            if (resultado == 0)
            {
                System.Console.WriteLine("SAO MULTIPLOS");
            }
            else
            {
                System.Console.WriteLine("NAO SAO MULTIPLOS");
            }
        }
        else
        {
            int resultado = valorB % valorA;
            if (resultado == 0)
            {
                System.Console.WriteLine("SAO MULTIPLOS");
            }
            else
            {
                System.Console.WriteLine("NAO SAO MULTIPLOS");
            }
        }
    }
}
