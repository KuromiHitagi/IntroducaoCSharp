namespace _1;

class Program
{
    static void Main(string[] args)
    {
        Apresentacao();

        Console.WriteLine("Digite quantos ingressos você deseja comprar de cada tipo: Inteira e depois Meia");
        int Inteira = Convert.ToInt32(Console.ReadLine());
        int Meia = Convert.ToInt32(Console.ReadLine());

        double Resultado = Calculo(Inteira, Meia);

        Console.WriteLine($"O valor total a ser pago é de: R$ {Resultado.ToString("F2")}");
    }

    public static void Apresentacao()
    {
        Console.WriteLine("\n-----------------------------------------------------------");
        Console.WriteLine("------------------Programa do Ingresso---------------------");
        Console.WriteLine("-----------------------------------------------------------\n");
    }

    public static double Calculo(int Inteira, int Meia)
    {
        return (Inteira * 28.5) + (Meia * 14.25);
    }
}
