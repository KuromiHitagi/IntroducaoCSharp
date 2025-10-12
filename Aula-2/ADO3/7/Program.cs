namespace _7;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite sua altura (Ex: 1,7):");
        double altura = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Digite seu peso (Ex: 70):");
        int peso = Convert.ToInt32(Console.ReadLine());

        double IMC = DefinirIMC(altura, peso);
        string resp = Convert.ToString(VerificarIMC(IMC));

        Console.WriteLine($"Seu IMC: {IMC} \nVocê está com sobrepeso? {resp}");
    }

    public static double DefinirIMC(double altura, int peso)
    {
        double imc = peso / (altura * altura);

        return imc;
    }

    public static bool VerificarIMC(double imc)
    {
        bool sobrepeso = false;
        if (imc < 25)
        {
            sobrepeso = false;
        }
        else
        {
            sobrepeso = true;
        }
        return sobrepeso;
    }
}
