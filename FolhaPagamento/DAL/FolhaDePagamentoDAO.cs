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
            //foreach (FolhaDePagamento pgtoCadastradas in pagtos)
            //{
            //    if (pgtoCadastradas.Funcionario.Cpf.Equals(cpf) && pgtoCadastradas.Mes.Equals(mes) && pgtoCadastradas.Ano.Equals(ano))
            //    {
            //        return false;
            //    }
            //}
            //pagtos.Add(pgto);
            //return true;
            if (ConsultarFolhaDePagamento(pgto.Funcionario.Cpf, pgto.Mes, pgto.Ano) != null)
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
                if (pgtoCadastradas.Funcionario.Cpf.Equals(cpf) && pgtoCadastradas.Mes.Equals(mes) && pgtoCadastradas.Ano.Equals(ano))
                {
                    return pgtoCadastradas;
                }
            }
            return null;
        }

        public static List<FolhaDePagamento> retornaFolhasDePagamentos()
        {
            return pagtos;
        }


    }
}
