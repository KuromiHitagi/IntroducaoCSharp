namespace _5;
class Program
{
    static void Main()
    {
        Apresentacao();

        double nota = ReceberNota("Digite a nota do candidato: ");
        double notaCorte = ReceberNota("Digite a nota de corte: ");
        double notaMinima = ReceberNota("Digite a nota mínima para aprovação: ");

        string situacao = VerificarSituacao(nota, notaCorte, notaMinima);

        ExibirResultado(situacao);
    }

    // --------------------------------------------------------------
    static void Apresentacao()
    {
        Console.WriteLine("\n------------------------------------------");
        Console.WriteLine("------ Resultado do Vestibular 🎓 ------");
        Console.WriteLine("------------------------------------------\n");
    }

    // --------------------------------------------------------------
    static double ReceberNota(string mensagem)
    {
        Console.Write(mensagem);
        return Convert.ToDouble(Console.ReadLine());
    }

    // --------------------------------------------------------------
    static string VerificarSituacao(double nota, double notaCorte, double notaMinima)
    {
        if (nota < notaMinima)
            return "Reprovado";
        else if (nota >= notaCorte)
            return "Aprovado";
        else
            return "Em Espera";
    }

    // --------------------------------------------------------------
    static void ExibirResultado(string situacao)
    {
        Console.WriteLine($"\nSituação do candidato: {situacao}");
    }
}