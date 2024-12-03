namespace Strings;

class Program
{
    static void Main(string[] args)
    {
        var names = new[] { "Bruno", "Felipe", "Emillia" };

        foreach (var name in names)
        {
            Console.WriteLine($"Hello {name.ToUpper()}!");
        }
    }
}
