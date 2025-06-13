using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public class Suite
{
    public string TipoSuite { get; }
    public int Capacidade { get; }
    public decimal ValorDiaria { get; }

    public Suite(string tipoSuite, int capacidade, decimal valorDiaria)
    {
        if (string.IsNullOrWhiteSpace(tipoSuite))
            throw new ArgumentException("Tipo da suíte é obrigatório.");

        if (capacidade <= 0)
            throw new ArgumentException("Capacidade deve ser maior que zero.");

        if (valorDiaria <= 0)
            throw new ArgumentException("Valor da diária deve ser maior que zero.");

        TipoSuite = tipoSuite;
        Capacidade = capacidade;
        ValorDiaria = valorDiaria;
    }
}