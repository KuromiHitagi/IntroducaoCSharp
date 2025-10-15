namespace _10;

class Program
{
    static void Main()
    {
        Apresentacao();

        string frase = ReceberFrase("Digite a frase para soletrar: ");

        Soletrar(frase);
    }

    // --------------------------------------------------------------
    static void Apresentacao()
    {
        Console.WriteLine("\n---------------------------------");
        Console.WriteLine("------ Soletrando Frase ------");
        Console.WriteLine("---------------------------------\n");
    }

    // --------------------------------------------------------------
    static string ReceberFrase(string mensagem)
    {
        Console.Write(mensagem);
        return Console.ReadLine();
    }

    // --------------------------------------------------------------
    static void Soletrar(string frase)
    {
        foreach (char c in frase.Replace(" ", "")) // remove espaços
        {
            Console.WriteLine(c);
        }
    }
}