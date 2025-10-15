namespace _3;

class Program
{
    static void Main()
    {
        Apresentacao();

        int inicio = ReceberNumero("Digite o número inicial: ");
        int fim = ReceberNumero("Digite o número final: ");

        EscreverIntervalo(inicio, fim);
    }

    // --------------------------------------------------------------
    static void Apresentacao()
    {
        Console.WriteLine("\n---------------------------------");
        Console.WriteLine("------ Números Naturais de Início a Fim ------");
        Console.WriteLine("---------------------------------\n");
    }

    // --------------------------------------------------------------
    static int ReceberNumero(string mensagem)
    {
        Console.Write(mensagem);
        return Convert.ToInt32(Console.ReadLine());
    }

    // --------------------------------------------------------------
    static void EscreverIntervalo(int inicio, int fim)
    {
        for (int i = inicio; i <= fim; i++)
        {
            Console.WriteLine(i);
        }
    }
}