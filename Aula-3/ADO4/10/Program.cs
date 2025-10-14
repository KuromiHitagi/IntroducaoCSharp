namespace _10;

class Program
{
    static void Main(string[] args)
    {
        Apresentacao();

        Console.WriteLine("Digite o dia: ");
        string Dia = Console.ReadLine();

        Console.WriteLine("Digite o dia da semana: (0 = Domingo)");
        int DiaSem = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Digite o mês: ");
        int Mes = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Digite o ano: ");
        string Ano = Console.ReadLine();

        string Resultado = Verificar(DiaSem);
        string ResultadoMes = VerificarMes(Mes);

        Console.WriteLine($"Enviado {Resultado}, {Dia} de {ResultadoMes} de {Ano}");
    }

    public static void Apresentacao()
    {
        Console.WriteLine("\n-----------------------------------------------------------");
        Console.WriteLine("-------------------Programa da Mensagem----------------------");
        Console.WriteLine("-----------------------------------------------------------\n");
    }

    public static string Verificar(int DiaSem)
    {
        string Res = "";

        switch (DiaSem)
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
        }
        ;

        return Res;
    }
    
    public static string VerificarMes(int Mes)
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
