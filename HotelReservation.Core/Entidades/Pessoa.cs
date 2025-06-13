using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public class Pessoa
{
    public string Nome { get; }

    public Pessoa(string nome)
    {
        Nome = nome ?? throw new ArgumentNullException(nameof(nome));
    }
}