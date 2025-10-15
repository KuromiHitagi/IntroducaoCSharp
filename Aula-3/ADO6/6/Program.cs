namespace _6;

class Program
{
    static void Main()
    {
        Apresentacao();

        int quantidade = ReceberQuantidade("Digite a quantidade de pontos: ");

        DesenharLinha(quantidade);
    }

    // --------------------------------------------------------------
    static void Apresentacao()
    {
        Console.WriteLine("\n---------------------------------");
        Console.WriteLine("------ Linha de Pontos ------");
        Console.WriteLine("---------------------------------\n");
    }

    // --------------------------------------------------------------
    static int ReceberQuantidade(string mensagem)
    {
        Console.Write(mensagem);
        return Convert.ToInt32(Console.ReadLine());
    }

    // --------------------------------------------------------------
    static void DesenharLinha(int quantidade)
    {
        for (int i = 0; i < quantidade; i++)
        {
            Console.Write("* ");
        }
        Console.WriteLine(); // pula a linha no final
    }
}