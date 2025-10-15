namespace _8;

class Program
{
    static void Main(string[] args)
    {
        Apresentacao();

        Console.WriteLine("Digite a quantidade de notas:");
        int qtdNotas = Convert.ToInt32(Console.ReadLine());

        double[] notas = new double[qtdNotas];

        for (int i = 0; i < qtdNotas; i++)
        {
            notas[i] = Convert.ToDouble(Receber($"Digite a {i + 1}ª nota:"));
        }

        double media = CalcularMedia(notas);
        string resultado = Verificar(media);

        Console.WriteLine($"A média do aluno é: {media:F1} e a situação: {resultado}");
    }

    public static void Apresentacao()
    {
        Console.WriteLine("\n-----------------------------------------------------------");
        Console.WriteLine("------------------Programa da Nota---------------------");
        Console.WriteLine("-----------------------------------------------------------\n");
    }

    public static string Receber(string mensage)
    {
        Console.WriteLine(mensage);
        return Console.ReadLine();
    }

    public static double CalcularMedia(double[] notas)
    {
        double soma = 0;
        for (int i = 0; i < notas.Length; i++)
        {
            soma += notas[i];
        }
        return soma / notas.Length;
    }

    public static string Verificar(double media)
    {
        string RES = "";

        if (media >= 8)
        {
            RES = "Aprovado com Sucesso";
        }
        else if (media >= 6 && media < 8)
        {
            RES = "Aprovado";
        }
        else if (media >= 3 && media < 6)
        {
            RES = "Recuperação";
        }
        else if (media < 3 && media > 0)
        {
            RES = "Reprovado";
        }
        else
        {
            RES = "Desistente";
        }
        return RES;
    }
}
