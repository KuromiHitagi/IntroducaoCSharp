namespace _7;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Informe a quantidade de Açaís:");
        int qtdAcai = Convert.ToInt32(Console.ReadLine());

        double valorFinal = qtdAcai * 13.5;

        Console.WriteLine($"O valor total dos Açaís é: {valorFinal.ToString("0.00")}");
    }
}
