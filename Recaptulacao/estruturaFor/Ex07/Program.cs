namespace Ex07
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = int.Parse(Console.ReadLine());

            for (int linha = 1; linha <= numero; linha++)
            {
                int quadrado = linha * linha;
                int cubo = linha * linha * linha;

                Console.WriteLine($"{linha} {quadrado} {cubo}");
            }
        }
    }
}

