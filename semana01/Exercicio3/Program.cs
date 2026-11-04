using System;

class Program
{
    static void Main(string[] args)
    {
        Random aleatorio = new Random();

        string jogarNovamente = "sim";

        while (jogarNovamente == "sim")
        {
            int numeroMagico = aleatorio.Next(1, 101);
            int tentativas = 0;

            Console.WriteLine("Bem-vindo ao jogo de adivinhação!");
            Console.WriteLine("Tente adivinhar o número mágico entre 1 e 100.");

            Console.Write("Qual é o seu palpite? ");
            int palpite = int.Parse(Console.ReadLine());

            tentativas++;

            while (palpite != numeroMagico)

            {
                if (palpite < numeroMagico)
                {
                    Console.WriteLine("Mais alto");
                }
                else
                {
                    Console.WriteLine("Mais baixo");
                }

                Console.Write("Qual é o seu palpite? ");
                palpite = int.Parse(Console.ReadLine());

                tentativas++;
            }

            Console.WriteLine("Você adivinhou!");
            Console.WriteLine($"Você precisou de {tentativas} tentativas.");

            Console.Write("Deseja jogar novamente? ");
            jogarNovamente = Console.ReadLine().Trim().ToLower();

        }
        Console.WriteLine("Obrigado por jogar!");
    }
}   