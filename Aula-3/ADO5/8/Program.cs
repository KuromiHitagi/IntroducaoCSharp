namespace _8;
class Program
{
    static void Main()
    {
        Apresentacao();

        double ganhos = ReceberValor("Digite o total de ganhos: ");
        double gastos = ReceberValor("Digite o total de gastos: ");

        string situacao = AvaliarOrcamento(ganhos, gastos);

        ExibirResultado(situacao);
    }

    // --------------------------------------------------------------
    static void Apresentacao()
    {
        Console.WriteLine("\n-------------------------------------------");
        Console.WriteLine("------ Avaliador de Orçamento Familiar 💰 ------");
        Console.WriteLine("-------------------------------------------\n");
    }

    // --------------------------------------------------------------
    static double ReceberValor(string mensagem)
    {
        Console.Write(mensagem);
        return Convert.ToDouble(Console.ReadLine());
    }

    // --------------------------------------------------------------
    static string AvaliarOrcamento(double ganhos, double gastos)
    {
        if (gastos > ganhos)
            return "Orçamento comprometido! Hora de rever seus gastos!";

        double percentual = (gastos / ganhos) * 100;

        if (percentual >= 81)
            return "Cuidado, seu orçamento pode ficar comprometido!";
        else if (percentual >= 51)
            return "Atenção, melhor conter os gastos!";
        else if (percentual >= 21)
            return "Muito bem, seus gastos não ultrapassam metade dos ganhos!";
        else // 0 a 20%
            return "Parabéns, está gerenciando bem seu orçamento!";
    }

    // --------------------------------------------------------------
    static void ExibirResultado(string situacao)
    {
        Console.WriteLine($"\n{situacao}");
    }
}