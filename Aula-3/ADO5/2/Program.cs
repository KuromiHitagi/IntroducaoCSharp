namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            Apresentacao();

            string cor1 = ReceberCor(1);
            string cor2 = ReceberCor(2);

            string resultado = CombinarCores(cor1, cor2);

            ExibirResultado(resultado);
        }

        // --------------------------------------------------------------
        // Mostra o título do programa
        public static void Apresentacao()
        {
            Console.WriteLine("\n---------------------------------------------");
            Console.WriteLine("------ Misturador de Cores Primárias 🎨 ------");
            Console.WriteLine("---------------------------------------------\n");
        }

        // --------------------------------------------------------------
        // Pede uma cor ao usuário
        public static string ReceberCor(int numero)
        {
            Console.Write($"Digite a {numero}ª cor primária: ");
            return Console.ReadLine().Trim().ToLower(); // ignora espaços e diferencia maiúsculas/minúsculas
        }

        // --------------------------------------------------------------
        // Faz a combinação das cores
        public static string CombinarCores(string cor1, string cor2)
        {
            // Cores primárias válidas
            string[] coresPrimarias = { "vermelho", "azul", "amarelo" };

            // Verifica se são primárias
            if (!coresPrimarias.Contains(cor1) || !coresPrimarias.Contains(cor2))
            {
                return "Apenas cores primárias são aceitas";
            }

            // Se forem iguais, a cor resultante é a mesma
            if (cor1 == cor2)
                return PrimeiraLetraMaiuscula(cor1);

            // Combinações possíveis
            if ((cor1 == "vermelho" && cor2 == "azul") || (cor1 == "azul" && cor2 == "vermelho"))
                return "Roxo";

            if ((cor1 == "vermelho" && cor2 == "amarelo") || (cor1 == "amarelo" && cor2 == "vermelho"))
                return "Laranja";

            if ((cor1 == "azul" && cor2 == "amarelo") || (cor1 == "amarelo" && cor2 == "azul"))
                return "Verde";

            return "Apenas cores primárias são aceitas";
        }

        // --------------------------------------------------------------
        // Mostra o resultado
        public static void ExibirResultado(string resultado)
        {
            Console.WriteLine($"\nA combinação das cores é: {resultado}");
        }

        // --------------------------------------------------------------
        // Deixa a primeira letra maiúscula (ex: vermelho -> Vermelho)
        public static string PrimeiraLetraMaiuscula(string texto)
        {
            return char.ToUpper(texto[0]) + texto.Substring(1);
        }
    }
}
