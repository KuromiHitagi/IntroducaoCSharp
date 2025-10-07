namespace _4;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Informe a quantidade de dólares:");
        double US = Convert.ToDouble(Console.ReadLine());

        double RS = US * 5.16;

        Console.WriteLine($"{US.ToString("0.00")} dólares são {RS.ToString("0.00")} reais");
    }
}
