using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numeros = new List<int>();
        Console.WriteLine("Insira uma lista de números e digite 0 quando terminar.");

        int numero = -1;

        while (numero != 0)
        {
            Console.Write("Insira um número: ");
            numero = int.Parse(Console.ReadLine());
            
            

            if (numero != 0)
            {
                numeros.Add(numero);
            }
        }

        int soma = 0;
        foreach (int numeLista in numeros)
        {
            soma += numeLista;
        }

        Console.WriteLine($"A soma é: {soma}");

        double media = (double)soma / numeros.Count;
        Console.WriteLine($"A média é: {media}");

        int maior = numeros[0];
        foreach (int numeLista in numeros)
        {
            if (numeLista > maior)
            {
                maior = numeLista;
            }
        }
        Console.WriteLine($"O maior número é: {maior}");

        int menorPositivo = int.MaxValue;
        foreach (int numeLista in numeros)
        {
            if (numeLista > 0 && numeLista < menorPositivo)
            {
                menorPositivo = numeLista;
            }

        }

        if (menorPositivo != int.MaxValue)
        {
            Console.WriteLine($"O menor número positivo é: {menorPositivo}");
        }
        else
        {
            Console.WriteLine("Não há números positivos na lista.");    
        }

        numeros.Sort();
        Console.WriteLine("A lista reordenada é: ");
        foreach (int numeLista in numeros)
        {
            Console.WriteLine(numeLista);
        }

    }
}