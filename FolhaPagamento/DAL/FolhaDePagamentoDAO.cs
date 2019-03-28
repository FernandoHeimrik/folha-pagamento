using FolhaPagamento.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolhaPagamento.DAL
{
    class FolhaDePagamentoDAO
    {
        public static List<FolhaDePagamento> pagtos = new List<FolhaDePagamento>();


        public static bool cadastrarFolhaDePagamento(FolhaDePagamento pgto)
        {
            if (ConsultarFolhaDePagamento(pgto.Funcionario.Cpf, pgto.MesAno.Month, pgto.MesAno.Year) != null)
            {
                return false;
            }
            pagtos.Add(pgto);
            return true;
        }

        public static FolhaDePagamento ConsultarFolhaDePagamento(string cpf, int mes, int ano)
        {
            foreach (FolhaDePagamento pgtoCadastradas in pagtos)
            {
                if (pgtoCadastradas.Funcionario.Cpf.Equals(cpf) && pgtoCadastradas.MesAno.Month.Equals(mes) && pgtoCadastradas.MesAno.Year.Equals(ano))
                {
                    return pgtoCadastradas;
                }
            }
            return null;
        }

        public static List<FolhaDePagamento> RetornaFolhasDePagementoPorFuncionario(string cpf)
        {
            List<FolhaDePagamento> pagtosAux = new List<FolhaDePagamento>();

            foreach (FolhaDePagamento pgtoCadastradas in pagtos)
            {
                if (pgtoCadastradas.Funcionario.Cpf.Equals(cpf))
                {
                    pagtosAux.Add(pgtoCadastradas);
                }
            }
            pagtosAux = pagtosAux.OrderBy(f => f.MesAno).ToList();
            return pagtosAux;
        }

        public static FolhaDePagamento ConsultarFolhaDePagamentoMesAno(int mes, int ano)
        {
            foreach (FolhaDePagamento pgtoCadastradas in pagtos)
            {
                if (pgtoCadastradas.MesAno.Month.Equals(mes) && pgtoCadastradas.MesAno.Year.Equals(ano))
                {
                    return pgtoCadastradas;
                }
            }
            return null;
        }

        public static List<FolhaDePagamento> RetornaFolhasDePamanetoPorMesAno(int mes, int ano)
        {
            List<FolhaDePagamento> pagtosAux = new List<FolhaDePagamento>();

            foreach (FolhaDePagamento pgtoCadastradas in pagtos)
            {
                if (pgtoCadastradas.MesAno.Month.Equals(mes) && pgtoCadastradas.MesAno.Year.Equals(ano))
                {
                    pagtosAux.Add(pgtoCadastradas);
                }
            }
            return pagtosAux;
        }

        public static List<FolhaDePagamento> retornaFolhasDePagamentos()
        {
            return pagtos;
        }


    }
}
