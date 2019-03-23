﻿using FolhaPagamento.Model;
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


        public static bool cadastrarFolhaDePagamento(FolhaDePagamento pgto, string cpf, string mes, string ano)
        {
            foreach (FolhaDePagamento pgtoCadastradas in pagtos)
            {
                if (pgtoCadastradas.Funcionario.Cpf.Equals(cpf) && pgtoCadastradas.Mes.Equals(mes) && pgtoCadastradas.Ano.Equals(ano)){
                    return false;
                }
            }
            pagtos.Add(pgto);
            return true;
        }


        public static List<FolhaDePagamento> retornaFolhasDePagamentos()
        {
            return pagtos;
        }


    }
}