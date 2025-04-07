namespace Ex04;

class Program
{
    static void Main(string[] args)
    {
        string[] vetor = Console.ReadLine().Split(' ');
        int horaInicial = int.Parse(vetor[0]);
        int horaFinal = int.Parse(vetor[1]);
        int calcularHorasDeJogo = 0;

        if (horaInicial > horaFinal)
        {
            calcularHorasDeJogo = (24 - horaInicial) + horaFinal;
            System.Console.WriteLine($"O JOGO DUROU {calcularHorasDeJogo} HORA(S)");
        }
        else if (horaInicial < horaFinal)
        {
            calcularHorasDeJogo = horaFinal - horaInicial;
            System.Console.WriteLine($"O JOGO DUROU {calcularHorasDeJogo} HORA(S)");
        }
        else
        {
            calcularHorasDeJogo = 24;
            System.Console.WriteLine($"O JOGO DUROU {calcularHorasDeJogo} HORA(S)");
        }
        
    }
}
