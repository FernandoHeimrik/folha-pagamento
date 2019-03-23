using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolhaPagamento.Model
{
    class Funcionario
    {
        public Funcionario()
        {
           // Cargo = new Model.Cargo();
        }

        public string Nome { get; set; }
        public string Cpf { get; set; }
        public DateTime Nascimento { get; set; }

        public Cargo Cargo { get; set; }

        public override string ToString()
        {
            return "Nome: "+ Nome + " | Cpf: " + Cpf + " | Data de Nascimento: "+ Nascimento.ToString("d") + " | Cargo: "+Cargo.Nome + " | Bonus: " + Cargo.Bonus;
        }

    }
}
