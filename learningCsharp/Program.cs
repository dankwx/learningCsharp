internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        string valorInput = Console.ReadLine() ?? string.Empty;
        Console.WriteLine($"Valor Informado: {(!String.IsNullOrEmpty(valorInput) ? valorInput : "No data")}");
        Console.ReadKey();
    }
}
