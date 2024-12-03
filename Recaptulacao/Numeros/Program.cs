namespace Numeros;

class Program
{
    static void Main(string[] args)
    {
        int a = 2100000000;
        int b = 2100000000;
        //funcao checked verifica o erro e retorna o valor.
        //long c = checked(a + b);
        long d = (long)a + (long)b;
        System.Console.WriteLine(d);
        //System.Console.WriteLine(c);
    }
}
