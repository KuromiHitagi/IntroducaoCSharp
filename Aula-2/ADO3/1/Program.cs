namespace _1;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite a temperatura:");
        double temperatura = Convert.ToDouble(Console.ReadLine());
        verificarTemp(temperatura);
    }

    public static void verificarTemp(double temperatura)
    {
        if (temperatura > 37.3)
        {
            Console.WriteLine("Febre");
        }
        else
        {
            Console.WriteLine("Normal");
        }
    }
}
