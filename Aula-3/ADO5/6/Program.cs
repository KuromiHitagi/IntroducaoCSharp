namespace _6;
class Program
{
    static void Main()
    {
        Apresentacao();

        string curso = ReceberCurso();
        bool isento = ReceberIsencao();
        double desconto = ReceberDesconto();

        double mensalidade = CalcularMensalidade(curso, isento, desconto);

        ExibirResultado(mensalidade);
    }

    // --------------------------------------------------------------
    static void Apresentacao()
    {
        Console.WriteLine("\n---------------------------------------------");
        Console.WriteLine("------ Cálculo de Mensalidade da Faculdade ------");
        Console.WriteLine("---------------------------------------------\n");
    }

    // --------------------------------------------------------------
    static string ReceberCurso()
    {
        Console.Write("Digite a sigla do curso (SI, ADS, CS, EC, ES): ");
        return Console.ReadLine().Trim().ToUpper();
    }

    // --------------------------------------------------------------
    static bool ReceberIsencao()
    {
        Console.Write("O aluno é isento? (true/false): ");
        return Convert.ToBoolean(Console.ReadLine());
    }

    // --------------------------------------------------------------
    static double ReceberDesconto()
    {
        Console.Write("Digite o desconto (%) do aluno: ");
        return Convert.ToDouble(Console.ReadLine());
    }

    // --------------------------------------------------------------
    static double CalcularMensalidade(string curso, bool isento, double desconto)
    {
        if (isento)
            return 0.0;

        double valorBase;

        switch (curso)
        {
            case "SI":
                valorBase = 550.0;
                break;
            case "ADS":
                valorBase = 750.0;
                break;
            case "CS":
                valorBase = 1150.0;
                break;
            case "EC":
                valorBase = 1300.0;
                break;
            case "ES":
                valorBase = 950.0;
                break;
            default:
                throw new Exception("Curso inválido");
        }

        double valorComDesconto = valorBase * (1 - desconto / 100);
        return valorComDesconto;
    }

    // --------------------------------------------------------------
    static void ExibirResultado(double mensalidade)
    {
        Console.WriteLine($"\nValor da mensalidade: R$ {mensalidade:F2}");
    }
}