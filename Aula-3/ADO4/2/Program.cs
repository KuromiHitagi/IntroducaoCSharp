namespace _2;

class Program
{
    static void Main(string[] args)
    {
        Apresentacao();

        Console.WriteLine("Digite qual a cor do farol: ");
        string Cor = Console.ReadLine();

        string Resultado = Verificar(Cor);

        Console.WriteLine($"{Resultado}");
    }

    public static void Apresentacao()
    {
        Console.WriteLine("\n-----------------------------------------------------------");
        Console.WriteLine("--------------------Programa do Farol-----------------------");
        Console.WriteLine("-----------------------------------------------------------\n");
    }

    public static string Verificar(string Cor)
    {
        if (Cor == "Verde")
        {
            return "Pode Atravessar";
        }
        else if (Cor != "Verde" && Cor != "Vermelho")
        {
            return "Farol Inoperante";
        }
        else
        {
            return "Não Pode Atravessar";
        }
    }
}
