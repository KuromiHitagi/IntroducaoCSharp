namespace _2;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Quem é o Alquimista da Faísca em Fullmetal Alchemist Broterhood?:");
        string respostaUser = Console.ReadLine();

        verificarResp(respostaUser);
    }

    public static void verificarResp(string respostaUser)
    {
        if (respostaUser == "Roy Mustang" || respostaUser == "roy mustang" || respostaUser == "ROY MUSTANG")
        {
            Console.WriteLine("Resposta correta!");
        }
        else
        {
            Console.WriteLine("Resposta incorreta!");
        }
    }
}
