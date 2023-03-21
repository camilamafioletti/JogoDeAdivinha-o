namespace JogoDeAdivinhação.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int chute;
            double pontuacao = 1000;
            double calculo;

            Console.WriteLine("***************************************");
            Console.WriteLine("* Bem-vindo(a) ao Jogo da Adivinhação *");
            Console.WriteLine("***************************************");
            Console.WriteLine(" ");
            Console.WriteLine("Escolha o nivel de dificuldade: ");
            Console.WriteLine("(1) Fácil - (2) Médio - (3) Dificil");
            Console.WriteLine("Escolha: ");
            double escolhaDificuldade = double.Parse(Console.ReadLine());

            Random aleatorio = new Random();
            int numeroAleatorio = aleatorio.Next(0, 20);

            switch (escolhaDificuldade)
            {
                case 1:

                    for (int i = 1; i <= 15; i++)
                    {

                        Console.WriteLine($"Tentiva {i} de 15 tentativas");
                        Console.WriteLine("---------------------------------------");
                        Console.Write("Qual seu chute? ");
                        chute = int.Parse(Console.ReadLine());

                        calculo = Math.Abs(chute - numeroAleatorio);
                        pontuacao = Math.Abs(pontuacao - (calculo / 2));


                        if (chute == numeroAleatorio)
                        {
                            Console.WriteLine("");
                            Console.WriteLine("Parabéns, você ganhou o jogo! "); break;
                        }
                        else if (chute < numeroAleatorio)
                        {
                            Console.WriteLine("");
                            Console.WriteLine("Seu chute foi menor que o número secreto");
                            Console.WriteLine($"Você fez {pontuacao} pontos! ");
                        }
                        else if (chute > numeroAleatorio)
                        {
                            Console.WriteLine("");
                            Console.WriteLine("Seu chute foi maior que o número secreto");
                        }
                    }
                    break;

                case 2:

                    for (int i = 1; i <= 10; i++)
                    {
                        Console.WriteLine($"Tentiva {i} de 10 tentativas");
                        Console.WriteLine("---------------------------------------");
                        Console.Write("Qual seu chute? ");
                        chute = int.Parse(Console.ReadLine());

                        calculo = Math.Abs(chute - numeroAleatorio);
                        pontuacao = Math.Abs(pontuacao - (calculo / 2));

                        if (chute == numeroAleatorio)
                        {
                            Console.WriteLine("");
                            Console.WriteLine("Voce ganhou o jogo! "); break;
                        }
                        else if (chute < numeroAleatorio)
                        {
                            Console.WriteLine("");
                            Console.WriteLine("Seu chute foi menor que o número secreto");
                            Console.WriteLine($"Você fez {pontuacao} pontos! ");
                        }
                        else if (chute > numeroAleatorio)
                        {
                            Console.WriteLine("");
                            Console.WriteLine("Seu chute foi maior que o número secreto");
                        }
                    }
                    break;

                case 3:

                    for (int i = 1; i <= 5; i++)
                    {
                        Console.WriteLine($"Tentiva {i} de 5 tentativas");
                        Console.WriteLine("---------------------------------------");
                        Console.Write("Qual seu chute? ");
                        chute = int.Parse(Console.ReadLine());

                        calculo = Math.Abs(chute - numeroAleatorio);
                        pontuacao = Math.Abs(pontuacao - (calculo / 2));

                        if (chute == numeroAleatorio)
                        {
                            Console.WriteLine("");
                            Console.WriteLine("Você ganhou o jogo! "); break;
                        }
                        else if (chute < numeroAleatorio)
                        {
                            Console.WriteLine("");
                            Console.WriteLine("Seu chute foi menor que o número secreto");
                            Console.WriteLine($"Você fez {pontuacao} pontos! ");
                        }
                        else if (chute > numeroAleatorio)
                        {
                            Console.WriteLine("");
                            Console.WriteLine();
                            Console.WriteLine("Seu chute foi maior que o número secreto");
                        }
                    }
                    break;

                default:
                    Console.WriteLine("Opção inválida"); break;
            }
        }
    }
}
