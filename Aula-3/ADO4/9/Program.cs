namespace _9;

class Program
{
    static void Main(string[] args)
    {
        Apresentacao();

        Console.WriteLine("Digite quantos você pesa:");
        int Peso = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Digite qual a sua altura:");
        double Altura = Convert.ToDouble(Console.ReadLine());

        double Resultado = Calculo(Peso, Altura);

        Console.WriteLine($"Seu IMC é de: {Resultado.ToString("F2")}");
    }

    public static void Apresentacao()
    {
        Console.WriteLine("\n-----------------------------------------------------------");
        Console.WriteLine("------------------Programa do IMC---------------------");
        Console.WriteLine("-----------------------------------------------------------\n");
    }

    public static double Calculo(int Peso, double Altura)
    {
        return Peso / (Altura * Altura);
    }
}
