namespace cs;

class Principal
{
    static void Main(string[] args)
    {   
        double jojo = 0;

        while (jojo == 0)
        {
            Console.WriteLine("!PROGRAMA INICIAL!");
            Console.WriteLine("==================");

            Console.WriteLine("Digite qual operação você deseja:");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtracao");
            Console.WriteLine("3 - Multiplicacao");
            Console.WriteLine("4 - Divisao");
            Console.WriteLine("0 - Sair");

            string escolha = Console.ReadLine();

            if (escolha == "Sair" || escolha == "0")
            {
                jojo = 1;
            }

            else if (escolha == "Soma" || escolha == "so" || escolha == "+" || escolha == "1")
            {
                Console.WriteLine("Digite o 1° número: ");
                double n1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Digite o 2° número: ");
                double n2 = Convert.ToDouble(Console.ReadLine());

                double soma = n1 + n2;
                Console.WriteLine($"O resultado é: {soma}");
            }

            else if (escolha == "Subtracao" || escolha == "sub" || escolha == "-" || escolha == "2")
            {
                Console.WriteLine("Digite o 1° número: ");
                double n1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Digite o 2° número: ");
                double n2 = Convert.ToDouble(Console.ReadLine());

                double sub = n1 - n2;
                Console.WriteLine($"O resultado é: {sub}");
            }

            else if (escolha == "Multiplicacao" || escolha == "mult" || escolha == "*" || escolha == "3")
            {
                Console.WriteLine("Digite o 1° número: ");
                double n1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Digite o 2° número: ");
                double n2 = Convert.ToDouble(Console.ReadLine());

                double mult = n1 * n2;
                Console.WriteLine($"O resultado é: {mult}");
            }

            else if (escolha == "Divisao" || escolha == "div" || escolha == "/" || escolha == "4")
            {
                Console.WriteLine("Digite o 1° número: ");
                double n1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Digite o 2° número: ");
                double n2 = Convert.ToDouble(Console.ReadLine());

                double div = n1 / n2;
                Console.WriteLine($"O resultado é: {div}");
            }

            else
            {
                Console.WriteLine("Nada selecionado, por favor tente novamente");
            }
        }
    }
}