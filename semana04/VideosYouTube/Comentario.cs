
class Comentario
{
    private string _nomePessoa;
    private string _texto;

    public Comentario(string nomePessoa, string texto)
    {
        _nomePessoa = nomePessoa;
        _texto = texto;
    }

    public string NomePessoa
    {
        get { return _nomePessoa; }
    }

    public string Texto
    {
        get { return _texto; }
    }
}
