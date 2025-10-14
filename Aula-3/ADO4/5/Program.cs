namespace _5;

class Program
{
    static void Main(string[] args)
    {
        Apresentacao();

        Console.WriteLine("Digite qual o mês com base em números: (1 = Janeiro) ");
        int Mes = Convert.ToInt32(Console.ReadLine());

        string Resultado = Verificar(Mes);

        Console.WriteLine($"O mes digitado é: {Resultado}");
    }

    public static void Apresentacao()
    {
        Console.WriteLine("\n-----------------------------------------------------------");
        Console.WriteLine("------------------Programa do Ingresso---------------------");
        Console.WriteLine("-----------------------------------------------------------\n");
    }

    public static string Verificar(int Mes)
    {
        string Res = "";

        switch (Mes)
        {
            case 0:
                Res = "Mês Inválido";
                break;

            case 1:
                Res = "Janeiro";
                break;

            case 2:
                Res = "Fevereiro";
                break;

            case 3:
                Res = "Março";
                break;

            case 4:
                Res = "Abril";
                break;

            case 5:
                Res = "Junho";
                break;

            case 6:
                Res = "Julho";
                break;

            case 7:
                Res = "Agosto";
                break;

            case 8:
                Res = "Setembro";
                break;

            case 9:
                Res = "Outubro";
                break;

            case 10:
                Res = "Novembro";
                break;

            case 11:
                Res = "Dezembro";
                break;

            default:
                Res = "Mês inválido";
                break;
        };
        
        return Res;
    }
}