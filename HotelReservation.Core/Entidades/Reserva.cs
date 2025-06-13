using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public class Reserva
{
    public List<Pessoa> Hospedes { get; private set; } = new();
    public Suite Suite { get; private set; }
    public int DiasReservados { get; private set; }

    public Reserva(Suite suite, int diasReservados)
    {
        CadastrarSuite(suite);
        DefinirDiasReservados(diasReservados);
    }

    public void CadastrarHospedes(List<Pessoa> hospedes)
    {
        if (Suite == null)
            throw new InvalidOperationException("A suíte deve ser cadastrada antes dos hóspedes.");

        if (hospedes == null || hospedes.Count == 0)
            throw new ArgumentException("A lista de hóspedes não pode estar vazia.");

        if (hospedes.Count > Suite.Capacidade)
            throw new InvalidOperationException("Número de hóspedes excede a capacidade da suíte.");

        Hospedes = hospedes;
    }

    public void CadastrarSuite(Suite suite)
    {
        Suite = suite ?? throw new ArgumentNullException(nameof(suite));
    }

    public void DefinirDiasReservados(int dias)
    {
        if (dias <= 0)
            throw new ArgumentException("Dias reservados deve ser maior que zero.");

        DiasReservados = dias;
    }

    public int ObterQuantidadeHospedes()
    {
        return Hospedes.Count;
    }

    public decimal CalcularValorDiaria()
    {
        if (Suite == null)
            throw new InvalidOperationException("A suíte não foi cadastrada.");

        decimal total = DiasReservados * Suite.ValorDiaria;

        if (DiasReservados >= 10)
            total *= 0.90m; // 10% de desconto

        return total;
    }
}