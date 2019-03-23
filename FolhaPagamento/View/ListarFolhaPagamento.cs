using FolhaPagamento.DAL;
using FolhaPagamento.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolhaPagamento.View
{
    class ListarFolhaPagamento
    {
        public static void Renderizar()
        {
            foreach (FolhaDePagamento pgtoCadastradas in FolhaDePagamentoDAO.retornaFolhasDePagamentos())
            {
                Console.WriteLine(pgtoCadastradas);
            }
        }
    }
}
