namespace Ex05
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = int.Parse(Console.ReadLine());

            // O fatorial de 0 é 1 por definição
            long fatorial = 1;

            // Calcula o fatorial
            for (int i = 1; i <= numero; i++)
            {
                fatorial *= i;
            }

            Console.WriteLine($"{fatorial}");
        }
    }
}
