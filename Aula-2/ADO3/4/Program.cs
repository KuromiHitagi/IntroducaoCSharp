namespace _4;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite o primeiro número:");
        int num1 = Convert.ToInt32(Console.ReadLine());

        string resp = Convert.ToString(DefinirPar(num1));

        Console.WriteLine($"O número {num1} é par? {resp}");
    }

    public static bool DefinirPar(int num1)
    {
        bool tf = false;

        if (num1 % 2 == 0)
        {
            tf = true;
        };

        return tf;
    }
}
