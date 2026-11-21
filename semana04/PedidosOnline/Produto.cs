class Produto
{
    private string _nome;
    private string _id;
    private double _preco;
    private int _quantidade;

    public Produto(string nome, string id, double preco, int quantidade)
    {
        _nome = nome;
        _id = id;
        _preco = preco;
        _quantidade = quantidade;
    }

    public string Nome
    {
        get { return _nome; }
        set { _nome = value; }
    }

    public string Id
    {
        get { return _id; }
        set { _id = value; }
    }

    public double Preco
    {
        get { return _preco; }
        set { _preco = value; }
    }

    public int Quantidade
    {
        get { return _quantidade; }
        set { _quantidade = value; }
    }

    public double CalcularCustoTotal()
    {
        return _preco * _quantidade;
    }
}