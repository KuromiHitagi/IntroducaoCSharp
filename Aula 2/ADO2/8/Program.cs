namespace _8;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("PROGRAMA DOS AÇAÍS");

        Console.WriteLine("Digite a quantidade de açaí pequeno: ");
        int quantidadePequeno = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Digite a quantidade de açaí médio: ");
        int quantidadeMedio = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Digite a quantidade de açaí grande: ");
        int quantidadeGrande = Convert.ToInt32(Console.ReadLine());

        decimal precoPequeno = 10.00m;
        decimal precoMedio = 13.50m;
        decimal precoGrande = 15.00m;

        decimal valorTotal = (quantidadePequeno * precoPequeno) + (quantidadeMedio * precoMedio) + (quantidadeGrande * precoGrande);

        Console.WriteLine($"O valor total da compra de açaí é: R$ {valorTotal}");
    }
}