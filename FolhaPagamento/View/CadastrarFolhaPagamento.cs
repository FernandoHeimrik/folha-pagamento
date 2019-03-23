﻿using FolhaPagamento.DAL;
using FolhaPagamento.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolhaPagamento.View
{
    class CadastrarFolhaPagamento
    {
        public static void Renderizar()
        {
            Funcionario f = new Funcionario();
            Cargo c = new Model.Cargo();
            FolhaDePagamento fp = new FolhaDePagamento();
            Console.WriteLine("CADASTRO FOLHA DE PAGAMENTO");
            Console.WriteLine("Informe o CPF do funcionario: ");
            f.Cpf = Console.ReadLine();
            f = FuncionarioDAO.BuscarFuncionarioPorCpf(f.Cpf);
            if ( f != null)
            {
                fp.Funcionario = f;
                Console.WriteLine("Informe o Cargo: ");
                c.Nome = Console.ReadLine();
                c = CargoDAO.BuscarCargoPeloNome(c.Nome);
                if ( c != null)
                {
                    fp.Funcionario.Cargo = c;
                    Console.WriteLine("informe o Mês: ");
                    fp.Mes = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("informe o Ano: ");
                    fp.Ano = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("informe o numero de Horas Trabalhadas: ");
                    fp.HorasTrabalhadas = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Informe o valor da hora: ");
                    fp.ValorHora = Convert.ToDouble(Console.ReadLine());

                    if (FolhaDePagamentoDAO.cadastrarFolhaDePagamento(fp,fp.Funcionario.Cpf, Convert.ToString(fp.Mes), Convert.ToString(fp.Mes)))
                    {
                        Console.WriteLine("Folha de Pagamento Cadastrada");
                    }
                    else
                    {
                        Console.WriteLine("Não é permitido gravar outra folha de pagamento com as mesmas informações");
                    }
                }
                else
                {
                    Console.WriteLine("Cargo não encontrado");
                }
            }
            else
            {
                Console.WriteLine("Funcionario não encontrado");
            }
        }
    }
}