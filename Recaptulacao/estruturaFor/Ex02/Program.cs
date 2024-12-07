namespace Ex02;

class Program
{
    static void Main(string[] args)
    {
        int quantidadeDeValores = int.Parse(Console.ReadLine());
        int auxiliar = 0;
        int dentro = 0;
        int fora = 0;

        for (int i = 0;i < quantidadeDeValores; i++)
        {
            auxiliar = int.Parse(Console.ReadLine());
            if (auxiliar >= 10 && auxiliar <= 20)
            {
                dentro++;
            }
            else
            {
                fora++;
            }
        }
        System.Console.WriteLine($"{dentro} in\n{fora} out");
    }
}
