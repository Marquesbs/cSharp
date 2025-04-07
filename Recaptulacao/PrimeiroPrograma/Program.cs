using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace primeiroPrograma;

class Program
{
    static void Main(string[] args)
    {
        /* 
        Console.WriteLine("Olá mundo!"); //imprime um valor na tela

        Console.ForegroundColor = ConsoleColor.Blue; //Altera a cor da fonte
        Console.WriteLine("Meu primeiro projeto.");

        Console.ReadKey(); //Aguarda o pressionamento de alguma tecla para continuar
        */

        int NumeroDigitado;

        Console.Write("Insira um número: "); //Exibe a mensagem

        NumeroDigitado = Convert.ToInt32(Console.ReadLine()); //Lê e converte para int o número informado pelo usuário

        if (NumeroDigitado % 2 == 0)
        {
            //Número Par
            Console.WriteLine("Par");
        }
        else
        {
            //Número Impar
            Console.WriteLine("Impar");
        }

        Console.ReadKey();
    }
}

