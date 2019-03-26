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
    class ListarFolhaPagamentoFuncionario
    {
        public static void Renderizar()
        {
            Funcionario f = new Model.Funcionario();
            FolhaDePagamento fp = new FolhaDePagamento();
            Console.WriteLine("CONSULTAR HISTÓRICO DE FOLHAS DE PAGAMENTO DO FUNCIONÁRIO");
            Console.WriteLine("Informe o CPF do Funcionário: ");
            f.Cpf = Console.ReadLine();
            f = FuncionarioDAO.BuscarFuncionarioPorCpf(f.Cpf);
            if(f != null)
            {
                
                foreach (FolhaDePagamento pagtosCadastradas in FolhaDePagamentoDAO.RetornaFolhasDePagementoPorFuncionario(f.Cpf))
                {
                    Console.WriteLine("Nome do funcionário: " + pagtosCadastradas.Funcionario.Nome);
                    Console.WriteLine("Cargo: " + pagtosCadastradas.Funcionario.Cargo.Nome);
                    Console.WriteLine("Data da folha de pagamento: " + pagtosCadastradas.MesAno.ToString("MM/yyyy"));
                    Console.WriteLine("Salário Bruto: " + Calculos.SalarioBruto(pagtosCadastradas.HorasTrabalhadas, pagtosCadastradas.ValorHora).ToString("C2"));
                    Console.WriteLine("Imposto de Renda: " + Calculos.ImpostoDeRenda(pagtosCadastradas.HorasTrabalhadas, pagtosCadastradas.ValorHora).ToString("C2"));
                    Console.WriteLine("INSS: " + Calculos.INSS(pagtosCadastradas.HorasTrabalhadas, pagtosCadastradas.ValorHora).ToString("C2"));
                    Console.WriteLine("FGTS: " + Calculos.FGTS(pagtosCadastradas.HorasTrabalhadas, pagtosCadastradas.ValorHora).ToString("C2"));
                    Console.WriteLine("Bônus: " + Calculos.Bonus(pagtosCadastradas.Funcionario.Cargo.Bonus, pagtosCadastradas.HorasTrabalhadas, pagtosCadastradas.ValorHora).ToString("C2"));
                    Console.WriteLine("Salário Líquido: " + (Calculos.SalarioBruto(pagtosCadastradas.HorasTrabalhadas, pagtosCadastradas.ValorHora) -
                        Calculos.ImpostoDeRenda(pagtosCadastradas.HorasTrabalhadas, pagtosCadastradas.ValorHora) -
                        Calculos.INSS(pagtosCadastradas.HorasTrabalhadas, pagtosCadastradas.ValorHora)).ToString("C2"));
                }
                

            }
            else
            {
                Console.WriteLine("Funcionário não encontrado");
            }

        }
    }
}
