using FolhaPagamento.DAL;
using FolhaPagamento.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolhaPagamento.View
{
    class CadastrarCargo
    {
        public static void Renderizar()
        {
            Cargo c = new Cargo();
            Console.WriteLine("\tCADASTRO DE CARGO");
            Console.WriteLine("Informe o nome: ");
            c.Nome = Console.ReadLine().ToUpper();

            Console.WriteLine("Informe o valor do Bonus: ");

            c.Bonus = Convert.ToDouble(Console.ReadLine());

            if (CargoDAO.CadastrarCargo(c))
            {
                Console.WriteLine("Cargo cadastrado com sucesso!");
                //foreach (var item in CargoDAO.RetornaCargos())
                //{
                //    Console.WriteLine(item);
                //}
            }
            else
            {
                Console.WriteLine("Cargo já cadastrado!");
            }

        }
    }
}
