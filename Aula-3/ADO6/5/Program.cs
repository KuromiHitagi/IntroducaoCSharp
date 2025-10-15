namespace _5;

class Program
{
    static void Main()
    {
        Apresentacao();

        int inicio = ReceberNumero("Digite o número inicial: ");
        int fim = ReceberNumero("Digite o número final: ");

        EscreverPares(inicio, fim);
    }

    // --------------------------------------------------------------
    static void Apresentacao()
    {
        Console.WriteLine("\n---------------------------------");
        Console.WriteLine("------ Números Pares Naturais ------");
        Console.WriteLine("---------------------------------\n");
    }

    // --------------------------------------------------------------
    static int ReceberNumero(string mensagem)
    {
        Console.Write(mensagem);
        return Convert.ToInt32(Console.ReadLine());
    }

    // --------------------------------------------------------------
    static void EscreverPares(int inicio, int fim)
    {
        int primeiroPar = (inicio % 2 == 0) ? inicio : inicio + 1;

        for (int i = primeiroPar; i <= fim; i += 2)
        {
            Console.WriteLine(i);
        }
    }
}