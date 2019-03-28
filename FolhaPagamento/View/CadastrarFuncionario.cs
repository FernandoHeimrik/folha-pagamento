using FolhaPagamento.DAL;
using FolhaPagamento.Model;
using FolhaPagamento.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolhaPagamento.View
{
    class CadastrarFuncionario
    {
        public static void Renderizar()
        {
            Funcionario f = new Funcionario();
            Cargo c = new Cargo();
            Console.WriteLine("\tCADASTRO FUNCIONÁRIO");
            Console.WriteLine("Informe o nome: ");
            f.Nome = Console.ReadLine();
            Console.WriteLine("Informe o CPF: ");
            f.Cpf = Console.ReadLine();

            if (ValidaCpf.ValidarCpf(f.Cpf))
            {
                Console.WriteLine("Informe a Data de Nascimento: dd/MM/yyyy");
                f.Nascimento = Convert.ToDateTime(Console.ReadLine());

                if (FuncionarioDAO.CadastrarFuncionario(f))
                {
                    Console.WriteLine("Funcionário Cadastrado com Sucesso!");
                    //foreach (var item in FuncionarioDAO.RetornaFuncionarios())
                    //{
                    //    Console.WriteLine(item);
                    //}
                }
                else
                {
                    Console.WriteLine("Funcionario já cadastrado!!");
                }
            }
            else
            {
                Console.WriteLine("CPF invalido");
            }
        }
    }
}
