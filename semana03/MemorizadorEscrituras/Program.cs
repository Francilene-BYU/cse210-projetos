using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("João", 3, 16);

        string text = "Porque Deus amou o mundo de tal maneira que deu o seu Filho unigênito para que todo aquele que nele crê não pereça mas tenha a vida eterna.";

        Scripture scripture = new Scripture(reference, text);

        // Aprimoramento: oculta somente palavras que ainda estão visíveis.
        while (true)
        {
            Console.Clear();

            Console.WriteLine(scripture.GetDisplayText());

            if (scripture.IsCompletelyHidden())
            {
                Console.WriteLine("\nTodas as palavras foram ocultadas!");
                break;
            }

            Console.WriteLine("\nPressione Enter para continuar ou digite 'sair' para encerrar.");

            string input = Console.ReadLine();

            if (input != null && input.Trim().Equals("sair", StringComparison.OrdinalIgnoreCase))
            {
                break;
            }

            scripture.HideRandomWords(3);
        }
    }
}