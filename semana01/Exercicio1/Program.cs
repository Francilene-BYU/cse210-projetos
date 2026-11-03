using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Qual é o seu primeiro nome? ");
        string primeiroNome = Console.ReadLine();

        Console.WriteLine("Qual é o sobrenome? ");
        string sobrenome = Console.ReadLine();

        Console.WriteLine($"Seu nome é {sobrenome}, {primeiroNome} {sobrenome}.");
        
    }
}