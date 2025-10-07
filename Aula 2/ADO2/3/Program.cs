namespace _3;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Informe a quantidade de Quilos:");
        double kg = Convert.ToDouble(Console.ReadLine());

        double g = kg * 1000;

        Console.WriteLine($"{kg} quilos são {g} gramas");
    }
}
