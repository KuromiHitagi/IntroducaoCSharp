namespace _10;

class Program
{
    static void Main()
    {
        // Entrada dos dados
        double diametro1 = LerValor("Digite o diâmetro do primeiro cilindro:");
        double altura1 = LerValor("Digite a altura do primeiro cilindro:");
        double diametro2 = LerValor("Digite o diâmetro do segundo cilindro:");
        double altura2 = LerValor("Digite a altura do segundo cilindro:");

        // Cálculo dos volumes
        double volume1 = CalcularVolume(diametro1, altura1);
        double volume2 = CalcularVolume(diametro2, altura2);

        // Verificação
        bool podeTransferir = PodeTransferir(volume1, volume2);

        // Saída
        ExibirResultado(volume1, volume2, podeTransferir);
    }

    // Função para ler valores (usando Convert.ToDouble)
    static double LerValor(string mensagem)
    {
        Console.WriteLine(mensagem);
        return Convert.ToDouble(Console.ReadLine());
    }

    // Função para calcular o volume do cilindro
    static double CalcularVolume(double diametro, double altura)
    {
        double raio = diametro / 2;
        return Math.PI * Math.Pow(raio, 2) * altura;
    }

    // Função para verificar se o primeiro pode ser transferido pro segundo
    static bool PodeTransferir(double volume1, double volume2)
    {
        return volume1 <= volume2;
    }

    // Função para exibir os resultados
    static void ExibirResultado(double volume1, double volume2, bool podeTransferir)
    {
        Console.WriteLine($"O primeiro cilindro tem volume de {volume1}");
        Console.WriteLine($"O segundo cilindro tem volume de {volume2}");
        Console.WriteLine($"É possível transferir o primeiro para o segundo? {podeTransferir.ToString().ToLower()}");
    }
}
