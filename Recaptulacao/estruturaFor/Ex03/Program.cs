using System;
using System.Globalization;

namespace Ex03
{
    class Program
    {
        static void Main(string[] args)
        {
            // Lê o número de casos de teste
            int casosDeTeste = int.Parse(Console.ReadLine());
            
            // Cria um vetor para armazenar as médias
            double[] mediasFinais = new double[casosDeTeste];
            
            // Loop para processar cada caso de teste
            for (int i = 0; i < casosDeTeste; i++)
            {
                // Lê a entrada de valores separados por espaço e armazena em um vetor de strings
                string[] valores = Console.ReadLine().Split(' ');
                
                // Converte os valores do vetor para double
                double valor1 = double.Parse(valores[0], CultureInfo.InvariantCulture);
                double valor2 = double.Parse(valores[1], CultureInfo.InvariantCulture);
                double valor3 = double.Parse(valores[2], CultureInfo.InvariantCulture);
                
                // Calcula a média ponderada
                double media = ((valor1 * 2) + (valor2 * 3) + (valor3 * 5)) / 10;

                // Armazena a média calculada no vetor de médias finais
                mediasFinais[i] = media;
            }
            
            // Exibe as médias calculadas usando o laço `for`
            for (int i = 0; i < casosDeTeste; i++)
            {
                Console.WriteLine(mediasFinais[i].ToString("F1", CultureInfo.InvariantCulture));
            }
        }
    }
}
