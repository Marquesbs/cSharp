namespace Ex02;

class Program
{
    static void Main(string[] args)
    {
        int coordenadaX;
        int coordenadaY;

        do
        {
            string[] vetor = Console.ReadLine().Split(' ');
            coordenadaX = int.Parse(vetor[0]);
            coordenadaY = int.Parse(vetor[1]);

            if (coordenadaX > 0.0)
            {
                if (coordenadaY > 0.0)
                {
                    System.Console.WriteLine("primeiro");
                }
                else
                {
                    System.Console.WriteLine("quarto");
                }
            }

            else if (coordenadaX < 0.0)
            {
                if (coordenadaY > 0.0)
                {
                    System.Console.WriteLine("segundo");
                }
                else
                {
                    System.Console.WriteLine("terceiro");
                }
            }
            else if (coordenadaX == 0 || coordenadaY == 0)
            {
                break;
            }

        }
        while (coordenadaX != 0 || coordenadaY != 0);
    }
}
