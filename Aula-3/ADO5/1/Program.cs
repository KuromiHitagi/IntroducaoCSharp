namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            Apresentacao();

            double lado1 = ReceberLado(1);
            double lado2 = ReceberLado(2);
            double lado3 = ReceberLado(3);

            if (!EhTrianguloValido(lado1, lado2, lado3))
            {
                Console.WriteLine("Os valores informados não formam um triângulo válido!");
                return;
            }

            string tipo = IdentificarTipo(lado1, lado2, lado3);
            ExibirResultado(tipo);
        }

        // --------------------------------------------------------------
        // Mostra o nome do programa
        public static void Apresentacao()
        {
            Console.WriteLine("\n-------------------------------------------");
            Console.WriteLine("------ Identificador de Triângulos 🔺 ------");
            Console.WriteLine("-------------------------------------------\n");
        }

        // --------------------------------------------------------------
        // Pede um dos lados do triângulo
        public static double ReceberLado(int numero)
        {
            Console.Write($"Digite o {numero}º lado do triângulo: ");
            return Convert.ToDouble(Console.ReadLine());
        }

        // --------------------------------------------------------------
        // Verifica se os lados formam um triângulo possível
        public static bool EhTrianguloValido(double a, double b, double c)
        {
            // Regra do triângulo: cada lado < soma dos outros dois
            return (a < b + c) && (b < a + c) && (c < a + b);
        }

        // --------------------------------------------------------------
        // Descobre o tipo de triângulo
        public static string IdentificarTipo(double a, double b, double c)
        {
            if (a == b && b == c)
                return "Equilátero";
            else if (a == b || b == c || a == c)
                return "Isósceles";
            else
                return "Escaleno";
        }

        // --------------------------------------------------------------
        // Mostra o resultado bonitinho
        public static void ExibirResultado(string tipo)
        {
            Console.WriteLine($"\nEsse é um triângulo {tipo}");
        }
    }
}