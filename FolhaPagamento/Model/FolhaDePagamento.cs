using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolhaPagamento.Model
{
    class FolhaDePagamento
    {
        public Funcionario Funcionario { get; set; }

        public int HorasTrabalhadas { get; set; }

        public double ValorHora { get; set; }

        public DateTime MesAno  { get; set; }

        public Cargo Cargo { get; set; }

    }
}
