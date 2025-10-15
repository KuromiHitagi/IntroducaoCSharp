namespace _13;

class Program
{
    static void Main()
    {
        Apresentacao();

        int altura = ReceberAltura("Digite a altura do triângulo: ");

        DesenharTrianguloDireita(altura);
    }

    // --------------------------------------------------------------
    static void Apresentacao()
    {
        Console.WriteLine("\n---------------------------------");
        Console.WriteLine("------ Triângulo Alinhado à Direita ------");
        Console.WriteLine("---------------------------------\n");
    }

    // --------------------------------------------------------------
    static int ReceberAltura(string mensagem)
    {
        Console.Write(mensagem);
        return Convert.ToInt32(Console.ReadLine());
    }

    // --------------------------------------------------------------
    static void DesenharTrianguloDireita(int altura)
    {
        for (int i = 1; i <= altura; i++)
        {
            // Espaços à esquerda
            for (int j = 0; j < altura - i; j++)
            {
                Console.Write(" ");
            }
            // Asteriscos
            for (int k = 0; k < i; k++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}