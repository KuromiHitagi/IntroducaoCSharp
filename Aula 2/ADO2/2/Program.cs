namespace _2;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Informe o valor da compra:");
        double valorCompra = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Informe o valor do desconto em %:");
        double valorDesc = Convert.ToDouble(Console.ReadLine());

        double valorFinal = valorCompra - (valorCompra * (valorDesc / 100));

        Console.WriteLine($"O valor da compra é: {valorFinal}");
    }
}
