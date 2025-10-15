namespace _7;

class Program
{
    static void Main(string[] args)
    {
        Apresentacao();

        Console.WriteLine("Digite sua temperatura em Celsius: ");
        double Temperatura = Convert.ToDouble(Console.ReadLine());

        string Resultado = Verificar(Temperatura);

        Console.WriteLine($"A situação para sua temperatura é: {Resultado}");
    }

    public static void Apresentacao()
    {
        Console.WriteLine("\n-----------------------------------------------------------");
        Console.WriteLine("------------------Programa da Temperatura---------------------");
        Console.WriteLine("-----------------------------------------------------------\n");
    }

    public static string Verificar(double Temperatura)
    {
        string RES = "";
        if (Temperatura >= 41)
        {
            RES = "Hipertermia";
        }
        else if (Temperatura >= 39.6 && Temperatura < 41)
        {
            RES = "Febre Alta";
        }
        else if (Temperatura >= 37.6 && Temperatura < 39.6)
        {
            RES = "Febre";
        }
        else if (Temperatura >= 36 && Temperatura < 37.6)
        {
            RES = "Normal";
        }
        else if (Temperatura < 36)
        {
            RES = "Hipotermia";
        }
        return RES;
    }
}
