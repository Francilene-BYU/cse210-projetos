/*using System;

class Program
{
    static void Main(string[] args)
       {
        Console.Write("Digite um número: ");
        string valorDigitado = Console.ReadLine();

       int x = int.Parse(valorDigitado);
       int y = 2;
       int z = 5;

       if (!(x < y || x < z) && y < z)
       {
           Console.WriteLine("Maior");
       }
       else if (x < y)
       {
           Console.WriteLine("Menor");
       }
       else
       {
           Console.WriteLine("Igual");

       }
    }*/

    /*________________________________________________*/

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite sua nota: " );
        int nota = int.Parse(Console.ReadLine());

        // Criar a variável letra
        string letra;

        if (nota >= 90)
        {
            letra = "A";            
        }
        else if (nota >= 80)
        {
            letra = "B";
        }
        else if (nota >= 70)
        {
            letra = "C";
        }
        else if (nota >= 60)
        {
            letra = "D";
        }
        else
        {
            letra = "F";
        }

        Console.WriteLine($"Seu conceito é {letra}.");

        if (nota >= 70)
        {
            Console.WriteLine("Parabéns! Você foi aprovado no curso!");
        }
        else
        {
            Console.WriteLine("Continue se esforçando! Você conseguirá na próxima vez.");
        }
    }
}