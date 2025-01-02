namespace Exercicio_01;

class Pessoa
{
    public string Nome;
    public int Idade;
}

class Program
{
    static void Main(string[] args)
    {
        Pessoa p1 = new Pessoa();
        Pessoa p2 = new Pessoa();

        System.Console.WriteLine("Dados primeira pessoa:");
        System.Console.Write("Nome: ");
        p1.Nome = Console.ReadLine();
        System.Console.Write("Idade: ");
        p1.Idade = int.Parse(Console.ReadLine());
        
        System.Console.WriteLine("\nDados primeira pessoa:");
        System.Console.Write("Nome: ");
        p2.Nome = Console.ReadLine();
        System.Console.Write("Idade: ");
        p2.Idade = int.Parse(Console.ReadLine());
        
        if (p1.Idade > p2.Idade)
        {
            System.Console.WriteLine("\nPessoa mais velha: " + p1.Nome);
        }
        else
        {
            System.Console.WriteLine("\nPessoa mais velha: " + p2.Nome);
        }
        Console.ReadKey();
    }
}
