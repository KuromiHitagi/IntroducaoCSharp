namespace _9;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Capacidade do tanque (L): ");
        double capacidade = Convert.ToDouble(Console.ReadLine());

        Console.Write("Quantidade atual de combustível (L): ");
        double atual = Convert.ToDouble(Console.ReadLine());

        bool precisaAbastecer = Verificar(capacidade, atual);
        Console.WriteLine($"Carro precisa ser reabastecido? {precisaAbastecer}");
    }

    public static bool Verificar(double capacidade, double atual)
    {
        bool precisaAbastecer = false;
        if (atual <= (capacidade / 4))
        {
            precisaAbastecer = true;
        }
        return precisaAbastecer;
    }
}
