using System.Collections.Generic;

class Pedido
{
    private List<Produto> _produtos;
    private Cliente _cliente;

    public Pedido(List<Produto> produtos, Cliente cliente)
    {
        _produtos = produtos;
        _cliente = cliente;
    }

    public List<Produto> Produtos
    {
        get { return _produtos; }
        set { _produtos = value; }
    }

    public Cliente Cliente
    {
        get { return _cliente; }
        set { _cliente = value; }
    }

    public double CalcularTotal()
    {
        double total = 0;

        foreach (Produto produto in _produtos)
        {
            total += produto.CalcularCustoTotal();
        }

        if (_cliente.EhNosEUA())
        {
            total += 5;
        }
        else
        {
            total += 35;
        }

        return total;
    }
    public string ObterEtiquetaEmbalagem()
    {
        string etiqueta = "ETIQUETA DE EMBALAGEM\n";

        foreach (Produto produto in _produtos)
        {
            etiqueta += $"Produto: {produto.Nome} - ID: {produto.Id}\n";
        }

        return etiqueta;
    }
    public string ObterEtiquetaEnvio()
    {
        return $"ETIQUETA DE ENVIO\n" +
            $"Cliente: {_cliente.Nome}\n" +
            $"{_cliente.Endereco.ObterEnderecoCompleto()}";
    }
}

