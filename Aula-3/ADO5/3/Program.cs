namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            Apresentacao();

            double[] notas = ReceberNotas();
            int faltas = ReceberFaltas();

            string situacao = ClassificarAluno(notas, faltas);

            ExibirResultado(situacao);
        }

        // --------------------------------------------------------------
        // Mostra o nome do programa
        public static void Apresentacao()
        {
            Console.WriteLine("\n-------------------------------------------------");
            Console.WriteLine("------ Sistema de Classificação de Alunos 🎓 ------");
            Console.WriteLine("-------------------------------------------------\n");
        }

        // --------------------------------------------------------------
        // Pede as 3 notas do aluno
        public static double[] ReceberNotas()
        {
            double[] notas = new double[3];

            for (int i = 0; i < 3; i++)
            {
                Console.Write($"Digite a {i + 1}ª nota: ");
                notas[i] = Convert.ToDouble(Console.ReadLine());
            }

            return notas;
        }

        // --------------------------------------------------------------
        // Pede a quantidade de faltas
        public static int ReceberFaltas()
        {
            Console.Write("\nDigite a quantidade de faltas: ");
            return Convert.ToInt32(Console.ReadLine());
        }

        // --------------------------------------------------------------
        // Calcula a média e retorna a situação
        public static string ClassificarAluno(double[] notas, int faltas)
        {
            // Regra: se tiver mais de 30 faltas, reprova direto
            if (faltas > 30)
                return "Reprovado";

            double media = CalcularMedia(notas);

            if (media == 0)
                return "Desistente";
            else if (media < 3)
                return "Reprovado";
            else if (media >= 3 && media < 6)
                return "Recuperação";
            else if (media >= 6 && media < 8)
                return "Aprovado";
            else
                return "Aprovado com Sucesso";
        }

        // --------------------------------------------------------------
        // Calcula a média das 3 notas
        public static double CalcularMedia(double[] notas)
        {
            double soma = 0;
            foreach (double nota in notas)
            {
                soma += nota;
            }
            return soma / notas.Length;
        }

        // --------------------------------------------------------------
        // Mostra o resultado bonitinho
        public static void ExibirResultado(string situacao)
        {
            Console.WriteLine($"\nSituação do Aluno: {situacao}");
        }
    }
}
