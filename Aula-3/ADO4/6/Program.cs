namespace _6
{
    class Program
    {
        static void Main(string[] args)
        {
            Apresentacao();

            double peso = ReceberPeso();

            if (peso <= 0)
            {
                Console.WriteLine("Peso Inválido");
                return;
            }

            double total = CalcularTotal(peso);

            ExibirResultado(total);
        }

        // --------------------------------------------------------------
        // Mostra o título do programa (só pra deixar o código bonitinho)
        public static void Apresentacao()
        {
            Console.WriteLine("\n-------------------------------------------");
            Console.WriteLine("---- Sorveteria do Joestar 🍦 ----");
            Console.WriteLine("-------------------------------------------\n");
        }

        // --------------------------------------------------------------
        // Pede o peso em gramas
        public static double ReceberPeso()
        {
            Console.Write("Digite o total de gramas do sorvete: ");
            return Convert.ToDouble(Console.ReadLine());
        }

        // --------------------------------------------------------------
        // Calcula o total a pagar
        public static double CalcularTotal(double gramas)
        {
            double precoPor100g;

            if (gramas >= 1000)
                precoPor100g = 3.00; // desconto de 0,50 a cada 100g
            else
                precoPor100g = 3.50;

            double total = (gramas / 100) * precoPor100g;
            return total;
        }

        // --------------------------------------------------------------
        // Mostra o resultado formatado bonitinho
        public static void ExibirResultado(double total)
        {
            Console.WriteLine($"O total a pagar é R$ {total:F2}");
        }
    }
}