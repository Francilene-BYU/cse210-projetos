// Criando frações com os três construtores
Fracao fracao1 = new Fracao();
Fracao fracao2 = new Fracao(5);
Fracao fracao3 = new Fracao(3, 4);
Fracao fracao4 = new Fracao(1, 3);

// Exibindo as frações em texto e decimal
Console.WriteLine(fracao1.ObterFracaoEmTexto());
Console.WriteLine(fracao1.ObterFracaoEmDecimal());

Console.WriteLine(fracao2.ObterFracaoEmTexto());
Console.WriteLine(fracao2.ObterFracaoEmDecimal());

Console.WriteLine(fracao3.ObterFracaoEmTexto());
Console.WriteLine(fracao3.ObterFracaoEmDecimal());

Console.WriteLine(fracao4.ObterFracaoEmTexto());
Console.WriteLine(fracao4.ObterFracaoEmDecimal());

// Testando getters e setters
Fracao teste = new Fracao();

teste.DefinirNumerador(3);
teste.DefinirDenominador(4);

Console.WriteLine("Numerador: " + teste.ObterNumerador());
Console.WriteLine("Denominador: " + teste.ObterDenominador());