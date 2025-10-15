namespace _4;

class Program
{
    static void Main()
    {
        Apresentacao();

        int fim = ReceberNumero("Digite o número final: ");
        int inicio = ReceberNumero("Digite o número inicial: ");

        EscreverRegressivo(inicio, fim);
    }

    // --------------------------------------------------------------
    static void Apresentacao()
    {
        Console.WriteLine("\n---------------------------------");
        Console.WriteLine("------ Números Naturais Regressivos de Fim a Início ------");
        Console.WriteLine("---------------------------------\n");
    }

    // --------------------------------------------------------------
    static int ReceberNumero(string mensagem)
    {
        Console.Write(mensagem);
        return Convert.ToInt32(Console.ReadLine());
    }

    // --------------------------------------------------------------
    static void EscreverRegressivo(int inicio, int fim)
    {
        for (int i = fim; i >= inicio; i--)
        {
            Console.WriteLine(i);
        }
    }
}