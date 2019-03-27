using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolhaPagamento.View
{
    class Menu
    {
        public static void Renderizar()
        {
            Console.Clear();
            Console.WriteLine("\t----PROJETO FOLHA DE PAGAMENTO ----\n");
            Console.WriteLine("1 - CADASTRAR CARGO");
            Console.WriteLine("2 - CADASTRAR FUNCIONÁRIO");
            Console.WriteLine("3 - CADASTRAR FOLHA DE PAGAMENTO");
            Console.WriteLine("4 - CONSULTAR FOLHA DE PAGAMENTO");
            Console.WriteLine("5 - CONSULTAR HISTÓRICO DE FOLHAS DE PAGAMENTO DO FUNCIONÁRIO");
            Console.WriteLine("6 - CONSULTAR HISTÓRICO DE FOLHAS DE PAGAMENTO DO MÊS");
            Console.WriteLine("0 - SAIR");
            Console.WriteLine("\nEscolha uma opção: ");
        }
    }
}
