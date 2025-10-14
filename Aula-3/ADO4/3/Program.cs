namespace _3;

class Program
{
    static void Main(string[] args)
    {
        Apresentacao();

        Console.WriteLine("Digite quantos reais você recebe por mês:");
        double Salario = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Digite quantos reais você gasta por mês: ");
        double Gasto = Convert.ToDouble(Console.ReadLine());

        double Resultado = Calculo(Salario, Gasto);
        string Situacao = Verificar(Resultado);

        Console.WriteLine($"{Situacao}");
    }

    public static void Apresentacao()
    {
        Console.WriteLine("\n-----------------------------------------------------------");
        Console.WriteLine("------------------Programa do Orçamento---------------------");
        Console.WriteLine("-----------------------------------------------------------\n");
    }

    public static double Calculo(double Salario, double Gasto)
    {
        return Salario - Gasto;
    }

    public static string Verificar(double Resultado)
    {
        if (Resultado > 0)
        {
            return "Você está com o orçamento positivo!";
        }
        else
        {
            return "Você está com o orçamento negativo!";
        }
    }
}
