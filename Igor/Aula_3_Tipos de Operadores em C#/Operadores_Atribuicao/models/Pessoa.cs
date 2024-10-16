using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Operadores_Atribuicao.models
{
    public class Pessoa
    {
        public string? Nome { get; set; }
        public int Idade { get; set; }
        public required string NomeRepresentanteLegalDaPessoaFisica { get; set; }

        public void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome}, e tenho {Idade} anos!");
        }
    }
}