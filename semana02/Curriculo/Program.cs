
using System;

class Program
{
    static void Main(string[] args)
    {
        // Primeiro emprego
        Emprego emprego1 = new Emprego();
        emprego1._cargo = "Engenheiro de Software";
        emprego1._empresa = "Microsoft";
        emprego1._anoInicio = 2019;
        emprego1._anoFim = 2022;

        // Segundo emprego
        Emprego emprego2 = new Emprego();
        emprego2._cargo = "Gerente";
        emprego2._empresa = "Apple";
        emprego2._anoInicio = 2022;
        emprego2._anoFim = 2023;

        // Criar o currículo
        Curriculo meuCurriculo = new Curriculo();
        meuCurriculo._nome = "José Carlos";

        // Adicionar os empregos ao currículo
        meuCurriculo._empregos.Add(emprego1);
        meuCurriculo._empregos.Add(emprego2);

        // Exibir o currículo completo
        meuCurriculo.Exibir();
    }
}
