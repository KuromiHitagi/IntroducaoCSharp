namespace _3;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite a área do primeiro retângulo:");
        double a1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Digite a área do segundo retângulo:");
        double a2 = Convert.ToDouble(Console.ReadLine());
        
        CompararArea(a1, a2);
    }

    public static void CompararArea(double a1, double a2)
    {
        bool tf = false;

        if (a1 == a2)
        {
            tf = true;
        }

        Console.WriteLine($"Os retângulos são iguais? {tf}");
    }
}
