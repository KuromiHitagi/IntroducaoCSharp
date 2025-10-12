using System.Reflection.PortableExecutable;

namespace _6;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite uma cor:");
        string cor = Console.ReadLine();

        string resp = Convert.ToString(VerificarCor(cor));
        
        Console.WriteLine($"Pode Atravessar? {resp}");
    }

    public static bool VerificarCor(string cor)
    {
        bool tf = false;
        if (cor == "verde")
        {
            tf = true;
        }
        return tf;
    }
}
