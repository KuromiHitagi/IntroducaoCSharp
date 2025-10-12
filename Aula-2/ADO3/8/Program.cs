namespace _8;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite quantas páginas o livro tem:");
        int qtdPg = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Digite quantas páginas você lê por minuto:");
        double pgM = Convert.ToDouble(Console.ReadLine());

        double LivroCompleto = CalcularTempo(qtdPg, pgM);

        Console.WriteLine($"Você levará {LivroCompleto} horas para ler o livro.");
    }

    public static double CalcularTempo(int qtdPg, double pgM)
    {
        double pgH = pgM * 60;
        double LivroCompleto = qtdPg / pgH;
        return LivroCompleto;
    }
}
