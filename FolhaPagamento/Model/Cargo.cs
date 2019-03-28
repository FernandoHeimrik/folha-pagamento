using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolhaPagamento.Model
{
    class Cargo
    {
        public string Nome { get; set; }

        public double Bonus { get; set; }

        public override string ToString()
        {
            return "Nome do Cargo: " + Nome + " | Valor do Bonus: " + Bonus;
        }
    }
}
