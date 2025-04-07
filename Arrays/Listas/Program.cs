namespace Listas;

class Program
{
    static void Main(string[] args)
    {
        var names = new List<string>{"Bruno", "Tainara", "Maria"};

        /*
        for (int i = 0; i < names.Count; i++)
        {
            System.Console.WriteLine($"Olá, {names[i].ToUpper()}!");
        }
        */

        names.Add("David");
        names.Add("Cleiton");
        
        foreach (var name in names)
        {
            System.Console.WriteLine($"Olá, {name.ToUpper()}!");;
        }
    }
}
