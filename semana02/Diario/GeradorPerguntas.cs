
class GeradorPerguntas
{
    private List<string> _perguntas = new List<string>
    {
        "Quem foi a pessoa mais interessante com quem conversei hoje?",
        "Qual foi a melhor parte do meu dia?",
        "Como percebi a mão do Senhor em minha vida hoje?",
        "Qual foi a emoção mais forte que senti hoje?",
        "O que aprendi de novo hoje?",
        "Pelo que sou grata hoje?",
        "Qual desafio consegui superar hoje?",
        "O que me fez sorrir hoje?",
        "O que eu poderia ter feito melhor hoje?",
        "Qual é uma coisa que desejo realizar amanhã?"
    };

    public string ObterPerguntaAleatoria()
    {
        Random aleatorio = new Random();

        int indice = aleatorio.Next(_perguntas.Count);

        return _perguntas[indice];
    }
}
