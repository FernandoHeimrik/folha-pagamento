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
    class ListarFolhaPagamento
    {
        public static void Renderizar()
        {
            Funcionario f = new Funcionario();
            FolhaDePagamento fp = new FolhaDePagamento();
            Console.WriteLine("CONSULTAR FOLHA DE PAGAMENTO");
            Console.WriteLine("Informe o CPF do funcionário: ");
            f.Cpf = Console.ReadLine();
            f = FuncionarioDAO.BuscarFuncionarioPorCpf(f.Cpf);

            if (f != null)
            {
                fp.Funcionario = f;
                Console.WriteLine("Informe o mês: ");
                fp.Mes = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("informe o ano: ");
                fp.Ano = Convert.ToInt32(Console.ReadLine());
                fp = FolhaDePagamentoDAO.ConsultarFolhaDePagamento(fp.Funcionario.Cpf, fp.Mes, fp.Ano);
                if (fp != null)
                {
                    //Console.WriteLine("Nome do funcionário: " + fp.Funcionario.Nome);
                    //Console.WriteLine("CPF: " + fp.Funcionario.Cpf);
                    //Console.WriteLine("Mês: " + fp.Mes + " Ano: " + fp.Ano);
                    Console.WriteLine("Salário Bruto: " + Calculos.SalarioBruto(fp.HorasTrabalhadas, fp.ValorHora));
                    Console.WriteLine("Imposto de Renda: " + Calculos.ImpostoDeRenda(fp.HorasTrabalhadas, fp.ValorHora));
                    Console.WriteLine("INSS: " + Calculos.INSS(fp.HorasTrabalhadas, fp.ValorHora));
                    Console.WriteLine("FGTS: " + Calculos.FGTS(fp.HorasTrabalhadas, fp.ValorHora));
                    Console.WriteLine("Bônus: " + Calculos.Bonus(fp.Funcionario.Cargo.Bonus, fp.HorasTrabalhadas, fp.ValorHora));
                    Console.WriteLine("Salário Líquido: " + (Calculos.SalarioBruto(fp.HorasTrabalhadas, fp.ValorHora)-
                        Calculos.ImpostoDeRenda(fp.HorasTrabalhadas, fp.ValorHora)-
                        Calculos.INSS(fp.HorasTrabalhadas, fp.ValorHora)));

                }
                else
                {
                    Console.WriteLine("Nenhuma Folha de Pagamento encontrada com essas informações");
                }
            }

            //foreach (FolhaDePagamento pgtoCadastradas in FolhaDePagamentoDAO.retornaFolhasDePagamentos())
            //{
            //    Console.WriteLine(pgtoCadastradas);
            //}
        }
    }
}
