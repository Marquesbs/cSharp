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
        System.Console.WriteLine("soma integer = " + d);
        //System.Console.WriteLine(c);

        float flutuante1 = 42.1F;
        double  flutuante2 = 4.33; //natural type
        double result = flutuante1 + flutuante2;
        System.Console.WriteLine("float + double = " + result);


        decimal numero1 = 42.1M; //explicit type
        decimal numero2 = 4.33M;
        decimal resultDecimal = numero1 + numero2;
        System.Console.WriteLine("Resultado soma decimal = " + resultDecimal);
    }
}
