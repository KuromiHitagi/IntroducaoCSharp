using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite o primeiro número:");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Digite o segundo número:");
        double num2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Digite a operação (Soma, Subtração, Multiplicação, Divisão, Resto da Divisão, Potência):");
        string operacao = Console.ReadLine();

        try
        {
            double resultado = Calculadora(num1, num2, operacao);
            Console.WriteLine($"Resultado é {resultado}");
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }

    static double Calculadora(double a, double b, string operacao)
    {
        switch (operacao.ToLower())
        {
            case "soma":
                return a + b;

            case "subtração":
                return a - b;

            case "multiplicação":
                return a * b;

            case "divisão":
                if (b == 0)
                    throw new Exception("Erro: Divisão por zero não é permitida!");
                return a / b;

            case "resto da divisão":
                if (b == 0)
                    throw new Exception("Erro: Divisão por zero não é permitida!");
                return a % b;

            case "potência":
                return Math.Pow(a, b);

            default:
                throw new Exception("Operação não suportada");
        }
    }
}
