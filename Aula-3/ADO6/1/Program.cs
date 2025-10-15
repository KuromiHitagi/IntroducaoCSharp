namespace _1;
class Program
{
    static void Main()
    {
        Apresentacao();

        int limite = ReceberLimite();

        EscreverNaturais(limite);
    }

    // --------------------------------------------------------------
    static void Apresentacao()
    {
        Console.WriteLine("\n---------------------------------");
        Console.WriteLine("------ Números Naturais 1 até N ------");
        Console.WriteLine("---------------------------------\n");
    }

    // --------------------------------------------------------------
    static int ReceberLimite()
    {
        Console.Write("Digite o número limite: ");
        return Convert.ToInt32(Console.ReadLine());
    }

    // --------------------------------------------------------------
    static void EscreverNaturais(int limite)
    {
        for (int i = 1; i <= limite; i++)
        {
            Console.WriteLine(i);
        }
    }
}