using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolhaPagamento.View
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;
            string op = "";
            do
            {

                Console.Clear();
                Console.WriteLine("----PROJETO FOLHA DE PAGAMENTO ----\n");
                Console.WriteLine("1 - CADASTRAR CARGO");
                Console.WriteLine("2 - CADASTRAR FUNCIONÁRIO");
                Console.WriteLine("3 - CADASTRAR FOLHA DE PAGAMENTO");
                Console.WriteLine("4 - CONSULTAR FOLHA DE PAGAMENTO");
                Console.WriteLine("5 - CONSULTAR HISTÓRICO DE FOLHAS DE PAGAMENTO DO FUNCIONÁRIO");
                Console.WriteLine("6 - CONSULTAR HISTÓRICO DE FOLHAS DE PAGAMENTO DO MÊS");
                Console.WriteLine("0 - SAIR");
                Console.WriteLine("Escolha uma opção: ");
                op = Console.ReadLine();

                Console.Clear();
                switch (op)
                {
                    case "1":
                        CadastrarCargo.Renderizar();
                        break;
                    default:
                        break;
                }

                Console.WriteLine("Digite uma tecla para continuar..");
                Console.ReadKey();

            } while (!op.Equals("0"));
        }
    }
}
