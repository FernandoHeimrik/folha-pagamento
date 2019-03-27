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
                Menu.Renderizar();

                op = Console.ReadLine();
                Console.Clear();
                switch (op)
                {
                    case "1":
                        CadastrarCargo.Renderizar();
                        break;
                    case "2":
                        CadastrarFuncionario.Renderizar();
                        break;
                    case "3":
                        CadastrarFolhaPagamento.Renderizar();
                        break;
                    case "4":
                        ListarFolhaPagamento.Renderizar();
                        break;
                    case "5":
                        ListarFolhaPagamentoFuncionario.Renderizar();
                        break;
                    case "6":
                        ListarFolhaPagamentoMesAno.Renderizar();
                        break;
                    default:
                        Console.WriteLine("Opção Inválida!");
                        break;
                }

                Console.WriteLine("\nDigite uma tecla para continuar..");
                Console.ReadKey();

            } while (!op.Equals("0"));
        }
    }
}
