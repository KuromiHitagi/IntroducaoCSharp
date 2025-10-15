namespace _8;

class Program
{
    static void Main()
    {
        Apresentacao();

        int baseRetangulo = ReceberValor("Digite a base do retângulo: ");
        int alturaRetangulo = ReceberValor("Digite a altura do retângulo: ");

        DesenharRetangulo(baseRetangulo, alturaRetangulo);
    }

    // --------------------------------------------------------------
    static void Apresentacao()
    {
        Console.WriteLine("\n---------------------------------");
        Console.WriteLine("------ Retângulo de Pontos ------");
        Console.WriteLine("---------------------------------\n");
    }

    // --------------------------------------------------------------
    static int ReceberValor(string mensagem)
    {
        Console.Write(mensagem);
        return Convert.ToInt32(Console.ReadLine());
    }

    // --------------------------------------------------------------
    static void DesenharRetangulo(int baseRetangulo, int alturaRetangulo)
    {
        for (int i = 0; i < alturaRetangulo; i++)
        {
            for (int j = 0; j < baseRetangulo; j++)
            {
                Console.Write("* ");
            }
            Console.WriteLine();
        }
    }
}