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

        public int Mes { get; set; }
        public int Ano { get; set; }

        public int HorasTrabalhadas { get; set; }

        public double ValorHora { get; set; }


        public override string ToString()
        {
            return "Funcionario:  " + Funcionario.Nome + " | Cargo: " + Funcionario.Cargo.Nome +
                " |Mês: " + Mes+ " | Ano: " + Ano + " | Horas Trabalhadas: " + HorasTrabalhadas + " | Valor Hora: " + ValorHora;

        }


    }
}
