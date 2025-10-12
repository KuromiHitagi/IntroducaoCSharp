namespace _2;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite a primeira nota:");
        double nota1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Digite a segunda nota:");
        double nota2 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Digite a terceira nota:");
        double nota3 = Convert.ToDouble(Console.ReadLine());
        definirMedia(nota1, nota2, nota3);
    }

    public static void definirMedia(double nota1, double nota2, double nota3)
    {
        double media = (nota1 + nota2 + nota3) / 3;
        verificarNota(media);
    }

    public static void verificarNota(double media)
    {
        if (media >= 6)
        {
            Console.WriteLine($"Aprovado com nota {media}");
        }
        else
        {
            Console.WriteLine($"Reprovado com nota {media}");
        }
    }
}
