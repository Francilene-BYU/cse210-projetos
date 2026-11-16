
class Program
{
    static void Main(string[] args)
    {

        //Projeto - Meu Diário
        // 1. O diário registra automaticamente a data e o horário de cada entrada.
        // 2. O gerador possui dez perguntas para diversificar as reflexões diárias.
        // 3. O programa impede o registro de respostas vazias.
        // 4. O salvamento e o carregamento possuem tratamento de erros,
        //    evitando que problemas com arquivos encerrem inesperadamente o programa.

        Journal diario = new Journal();
        GeradorPerguntas gerador = new GeradorPerguntas();

        bool continuar = true;

        Console.WriteLine("Bem-vinda ao Meu Diário Pessoal!");

        while (continuar)
        {
            Console.WriteLine();
            Console.WriteLine("================================");
            Console.WriteLine("       MEU DIÁRIO PESSOAL");
            Console.WriteLine("================================");
            Console.WriteLine("1. Escrever um novo registro");
            Console.WriteLine("2. Exibir meu diário");
            Console.WriteLine("3. Salvar diário");
            Console.WriteLine("4. Carregar diário");
            Console.WriteLine("5. Sair");
            Console.WriteLine();
            Console.Write("Escolha uma opção: ");

            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    string pergunta = gerador.ObterPerguntaAleatoria();

                    Console.WriteLine();
                    Console.WriteLine($"Pergunta: {pergunta}");
                    Console.Write("Sua resposta: ");

                    string resposta = Console.ReadLine();

                    if (string.IsNullOrWhiteSpace(resposta))
                    {
                        Console.WriteLine("A resposta não pode ficar vazia.");
                        break;
                    }

                    string data = DateTime.Now.ToString("dd/MM/yyyy HH:mm");

                    Entry novaEntrada = new Entry(data, pergunta, resposta);

                    diario.AddEntry(novaEntrada);

                    Console.WriteLine("Registro adicionado com sucesso!");
                    break;

                case "2":
                    Console.WriteLine();
                    Console.WriteLine("===== MEU DIÁRIO =====");
                    diario.DisplayAll();
                    break;

                case "3":
                    Console.Write("Digite o nome do arquivo para salvar: ");
                    string arquivoSalvar = Console.ReadLine();

                    if (!string.IsNullOrWhiteSpace(arquivoSalvar))
                    {
                        try
                        {
                            diario.SaveToFile(arquivoSalvar);
                        }
                        catch (Exception erro)
                        {
                            Console.WriteLine($"Erro ao salvar: {erro.Message}");
                        }
                    }
                    break;

                case "4":
                    Console.Write("Digite o nome do arquivo para carregar: ");
                    string arquivoCarregar = Console.ReadLine();

                    if (!string.IsNullOrWhiteSpace(arquivoCarregar))
                    {
                        try
                        {
                            diario.LoadFromFile(arquivoCarregar);
                        }
                        catch (Exception erro)
                        {
                            Console.WriteLine($"Erro ao carregar: {erro.Message}");
                        }
                    }
                    break;

                case "5":
                    continuar = false;
                    Console.WriteLine("Obrigada por utilizar o Meu Diário!");
                    break;

                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }
        }
    }
}
