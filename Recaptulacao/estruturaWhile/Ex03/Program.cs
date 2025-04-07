namespace Ex03;

class Program
{
    static void Main(string[] args)
    {
        int auxiliar = 0;
        int alcool = 0;
        int gasolina = 0;
        int diesel = 0;

        do
        {
            auxiliar = int.Parse(Console.ReadLine());
            if (auxiliar == 1)
            {
                alcool++;
            }
            else if (auxiliar == 2)
            {
                gasolina++;
            }
            else if (auxiliar == 3)
            {
                diesel++;
            }
        }
        while (auxiliar != 4);

        System.Console.WriteLine("MUITO OBRIGADO");
        System.Console.WriteLine($"Alcool: {alcool}");
        System.Console.WriteLine($"Gasolina: {gasolina}");
        System.Console.WriteLine($"Diesel: {diesel}");
    }
}
