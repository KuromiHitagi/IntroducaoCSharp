namespace _4;

class Program
{
    static void Main(string[] args)
    {
        Apresentacao();

        Console.WriteLine("Digite qual o dia da semana com base em números: (0 = Domingo) ");
        int Dia = Convert.ToInt32(Console.ReadLine());

        string Resultado = Verificar(Dia);

        Console.WriteLine($"O dia digitado é: {Resultado}");
    }

    public static void Apresentacao()
    {
        Console.WriteLine("\n-----------------------------------------------------------");
        Console.WriteLine("------------------Programa do Ingresso---------------------");
        Console.WriteLine("-----------------------------------------------------------\n");
    }

    public static string Verificar(int Dia)
    {
        string Res = "";

        switch (Dia)
        {
            case 0:
                Res = "Domingo";
                break;

            case 1:
                Res = "Segunda-feira";
                break;

            case 2:
                Res = "Terça-feira";
                break;

            case 3:
                Res = "Quarta-feira";
                break;

            case 4:
                Res = "Quinta-feira";
                break;

            case 5:
                Res = "Sexta-feira";
                break;

            case 6:
                Res = "Sábado";
                break;

            default:
                Res = "Dia inválido";
                break;
        };
        
        return Res;
    }
}
