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
            Console.WriteLine("CADASTRO FUNCIONÁRIO");
            Console.WriteLine("Informe o nome: ");
            f.Nome = Console.ReadLine();
            Console.WriteLine("Informe o CPF: ");
            f.Cpf = Console.ReadLine();

            if (ValidaCpf.ValidarCpf(f.Cpf))
            {
                Console.WriteLine("Informe a Data de Nascimento: dd/MM/yyyy");
                f.Nascimento = DateTime.Parse(Console.ReadLine());
                if (FuncionarioDAO.cadastrarFuncionario(f))
                {
                    Console.WriteLine("Funcionário Cadastrado com Sucesso!");
                    //foreach (var item in FuncionarioDAO.retornaFuncionarios())
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
