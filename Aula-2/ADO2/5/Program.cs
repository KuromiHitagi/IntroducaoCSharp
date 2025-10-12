namespace _5;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Informe o valor da compra:");
        double valorCompra = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Informe a quantidade de Parcelas:");
        int qtdParcelas = Convert.ToInt32(Console.ReadLine());

        double valorFinal = Parcelas(valorCompra, qtdParcelas);

        Console.WriteLine($"O valor da compra parcelada é: {valorFinal}");
    }

    public static double Parcelas(double valorCompra, int qtdParcelas)
    {
        double valorFinal = valorCompra / qtdParcelas;
        return valorFinal;
    }
}
