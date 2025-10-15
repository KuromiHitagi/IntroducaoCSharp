namespace _11;

class Program
{
    static void Main()
    {
        Apresentacao();

        string frase = ReceberFrase("Digite a frase para soletrar: ");

        SoletrarComContagem(frase);
    }

    // --------------------------------------------------------------
    static void Apresentacao()
    {
        Console.WriteLine("\n---------------------------------");
        Console.WriteLine("------ Soletrando com Contagem ------");
        Console.WriteLine("---------------------------------\n");
    }

    // --------------------------------------------------------------
    static string ReceberFrase(string mensagem)
    {
        Console.Write(mensagem);
        return Console.ReadLine();
    }

    // --------------------------------------------------------------
    static void SoletrarComContagem(string frase)
    {
        int contador = 1;

        foreach (char c in frase)
        {
            if (c == ' ')
            {
                Console.WriteLine("Espaço");
            }
            else
            {
                Console.WriteLine($"Letra {contador} = {c}");
                contador++;
            }
        }
    }
}






