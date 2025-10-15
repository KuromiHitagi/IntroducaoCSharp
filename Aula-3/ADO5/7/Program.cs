namespace _7;
class Program
{
    static void Main()
    {
        Apresentacao();

        int inteiras = ReceberQuantidade("Digite a quantidade de ingressos inteiros: ");
        int meias = ReceberQuantidade("Digite a quantidade de ingressos meia-entrada: ");
        string diaSemana = ReceberDiaSemana();
        bool nacional = ReceberNacional();

        double total = CalcularTotal(inteiras, meias, diaSemana, nacional);

        ExibirResultado(total);
    }

    // --------------------------------------------------------------
    static void Apresentacao()
    {
        Console.WriteLine("\n-----------------------------------------");
        Console.WriteLine("------ Compra de Ingressos de Cinema 🎬 ------");
        Console.WriteLine("-----------------------------------------\n");
    }

    // --------------------------------------------------------------
    static int ReceberQuantidade(string mensagem)
    {
        Console.Write(mensagem);
        return Convert.ToInt32(Console.ReadLine());
    }

    // --------------------------------------------------------------
    static string ReceberDiaSemana()
    {
        Console.Write("Digite o dia da semana do filme: ");
        return Console.ReadLine().Trim().ToLower();
    }

    // --------------------------------------------------------------
    static bool ReceberNacional()
    {
        Console.Write("O filme é nacional? (true/false): ");
        return Convert.ToBoolean(Console.ReadLine());
    }

    // --------------------------------------------------------------
    static double CalcularTotal(int inteiras, int meias, string dia, bool nacional)
    {
        double preco = 28.50;

        if (nacional)
            preco = 5.00;
        else if (dia == "quarta-feira")
            preco = 14.25;

        double total = (inteiras + meias) * preco;

        return total;
    }

    // --------------------------------------------------------------
    static void ExibirResultado(double total)
    {
        Console.WriteLine($"\nO total a se pagar pelos ingressos é R$ {total:F2}");
    }
}