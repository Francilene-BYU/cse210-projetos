using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // CLIENTE 1 - ESTADOS UNIDOS

        Endereco endereco1 = new Endereco(
            "123 Main Street",
            "New York",
            "NY",
            "USA"
        );

        Cliente cliente1 = new Cliente("John Smith", endereco1);

        // PRODUTOS DO PEDIDO 1

        Produto produto1 = new Produto("Notebook", "P001", 800, 1);
        Produto produto2 = new Produto("Mouse", "P002", 25, 2);
        Produto produto3 = new Produto("Teclado", "P003", 45, 1);

        List<Produto> produtos1 = new List<Produto>
        {
            produto1,
            produto2,
            produto3
        };

        Pedido pedido1 = new Pedido(produtos1, cliente1);


        // CLIENTE 2 - BRASIL

        Endereco endereco2 = new Endereco(
            "Rua das Flores, 100",
            "Fortaleza",
            "CE",
            "Brasil"
        );

        Cliente cliente2 = new Cliente("Maria Oliveira", endereco2);

        // PRODUTOS DO PEDIDO 2

        Produto produto4 = new Produto("Fone de ouvido", "P004", 120, 1);
        Produto produto5 = new Produto("Carregador", "P005", 50, 2);

        List<Produto> produtos2 = new List<Produto>
        {
            produto4,
            produto5
        };

        Pedido pedido2 = new Pedido(produtos2, cliente2);


        // EXIBIÇÃO DOS PEDIDOS

        Console.WriteLine("=================================");
        Console.WriteLine("         PEDIDO 1");
        Console.WriteLine("=================================");

        Console.WriteLine(pedido1.ObterEtiquetaEmbalagem());
        Console.WriteLine(pedido1.ObterEtiquetaEnvio());
        Console.WriteLine($"Total do pedido: US$ {pedido1.CalcularTotal():F2}");

        Console.WriteLine();

        Console.WriteLine("=================================");
        Console.WriteLine("         PEDIDO 2");
        Console.WriteLine("=================================");

        Console.WriteLine(pedido2.ObterEtiquetaEmbalagem());
        Console.WriteLine(pedido2.ObterEtiquetaEnvio());
        Console.WriteLine($"Total do pedido: US$ {pedido2.CalcularTotal():F2}");
    }
}