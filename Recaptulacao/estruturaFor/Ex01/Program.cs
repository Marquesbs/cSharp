namespace Ex01;

class Program
{
    static void Main(string[] args)
    {
        int valor = int.Parse(Console.ReadLine());

        for (
            int i = 0;//inicializa
            i <= valor;//condicional
            i++)//interage (incrementa ou decrementa)
        {
            if (i % 2 != 0)
            {
                System.Console.WriteLine(i);
            }
        }
    }
}
