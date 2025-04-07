namespace Ex06;

class Program
{
    static void Main(string[] args)
    {
        int numero = int.Parse(Console.ReadLine());

        for (int divisor = 1; divisor <= numero; divisor++)
        {
            if (numero % divisor == 0)
            {
                System.Console.WriteLine(divisor);
            }
        }
    }
}
