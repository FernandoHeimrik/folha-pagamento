using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolhaPagamento.Model
{
    class Funcionario
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public DateTime Nascimento { get; set; }


        public override string ToString()
        {
            return "Nome: "+ Nome + " | Cpf: " + Cpf + " | Data de Nascimento: "+ Nascimento;
        }

    }
}
