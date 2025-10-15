namespace _2;

class Program
{
    static void Main()
    {
        Apresentacao();

        int limite = ReceberLimite();

        EscreverRegressivo(limite);
    }

    // --------------------------------------------------------------
    static void Apresentacao()
    {
        Console.WriteLine("\n---------------------------------");
        Console.WriteLine("------ Números Naturais Regressivos ------");
        Console.WriteLine("---------------------------------\n");
    }

    // --------------------------------------------------------------
    static int ReceberLimite()
    {
        Console.Write("Digite o número inicial: ");
        return Convert.ToInt32(Console.ReadLine());
    }

    // --------------------------------------------------------------
    static void EscreverRegressivo(int limite)
    {
        for (int i = limite; i >= 1; i--)
        {
            Console.WriteLine(i);
        }
    }
}