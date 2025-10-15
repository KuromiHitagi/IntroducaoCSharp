namespace _7;

class Program
{
    static void Main()
    {
        Apresentacao();

        int lado = ReceberLado("Digite o tamanho do lado do quadrado: ");

        DesenharQuadrado(lado);
    }

    // --------------------------------------------------------------
    static void Apresentacao()
    {
        Console.WriteLine("\n---------------------------------");
        Console.WriteLine("------ Quadrado de Pontos ------");
        Console.WriteLine("---------------------------------\n");
    }

    // --------------------------------------------------------------
    static int ReceberLado(string mensagem)
    {
        Console.Write(mensagem);
        return Convert.ToInt32(Console.ReadLine());
    }

    // --------------------------------------------------------------
    static void DesenharQuadrado(int lado)
    {
        for (int i = 0; i < lado; i++)
        {
            for (int j = 0; j < lado; j++)
            {
                Console.Write("* ");
            }
            Console.WriteLine();
        }
    }
}
