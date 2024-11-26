namespace Ex02;

class Program
{
    static void Main(string[] args)
    {
        int numero = int.Parse(Console.ReadLine());
        int calcular = numero % 2;

        if (calcular == 0)
        {
            System.Console.WriteLine("PAR");
        }
        else
        {
            System.Console.WriteLine("IMPAR");
        }
        
    }
}
