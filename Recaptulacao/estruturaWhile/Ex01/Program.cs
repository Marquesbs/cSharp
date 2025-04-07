using System.Globalization;

namespace Ex01;

class Program
{
    static void Main(string[] args)
    {
        int senha;
        do
        {
            senha = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            if (senha != 2002)
            {
                System.Console.WriteLine("Senha Invalida");
            }
        }
        while (senha != 2002);
        System.Console.WriteLine("Acesso Permitido");
    }
}
