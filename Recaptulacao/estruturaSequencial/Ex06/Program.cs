using System.Globalization;

namespace Ex06;

class Program
{
    static void Main(string[] args)
    {
        //lendo valores
        string[] vetor = Console.ReadLine().Split(' ');
        //atribuindo os valores do vetor para cada variável
        double valorA = double.Parse((vetor[0]), CultureInfo.InvariantCulture);
        double valorB = double.Parse((vetor[1]), CultureInfo.InvariantCulture);
        double valorC = double.Parse((vetor[2]), CultureInfo.InvariantCulture);

        //calculando a área do triângulo retângulo que tem A por base e C por altura.
        // Area = (base * altura) / 2
        double triangulo = (valorA * valorC) / 2;
        System.Console.WriteLine("TRIANGULO: " + triangulo.ToString("F3"), CultureInfo.InvariantCulture);

        //calculando a área do círculo de raio C. (pi = 3.14159)
        //Area = πr²
        double circulo = 3.14159 * (Math.Pow(valorC, 2)); //Math.Pow é potenciação.
        System.Console.WriteLine("CIRCULO: " + circulo.ToString("F3"), CultureInfo.InvariantCulture);

        //calculando a área do trapézio que tem A e B por bases e C por altura.
        //Area = (1 / 2) * altura (a + b)
        double trapezio = (valorC * (valorA + valorB)) / 2;
        System.Console.WriteLine("TRAPEZIO: " + trapezio.ToString("F3"), CultureInfo.InvariantCulture);

        //calculando a área do quadrado que tem lado B.
        //Area = lado ao quadrado * lado do quadrado.
        double quadrado = Math.Pow(valorB, 2);
        System.Console.WriteLine("QUADRADO: " + quadrado.ToString("F3"), CultureInfo.InvariantCulture);

        //calculando a área do retângulo que tem lados A e B.
        //Area = b . h
        double retangulo = valorA * valorB;
        System.Console.WriteLine("RETANGULO: " + retangulo.ToString("F3"), CultureInfo.InvariantCulture);
    }
}
