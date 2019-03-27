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
            Console.WriteLine("\tCONSULTAR FOLHA DE PAGAMENTO");
            Console.WriteLine("Informe o CPF do funcionário: ");
            f.Cpf = Console.ReadLine();
            f = FuncionarioDAO.BuscarFuncionarioPorCpf(f.Cpf);
            if (f != null)
            {
                fp.Funcionario = f;
                Console.WriteLine("Informe o mês e ano: MM/yyyy");
                fp.MesAno = Convert.ToDateTime(Console.ReadLine());
                fp = FolhaDePagamentoDAO.ConsultarFolhaDePagamento(fp.Funcionario.Cpf, fp.MesAno.Month, fp.MesAno.Year);
                if (fp != null)
                {
                    //Console.WriteLine("Nome do funcionário: " + fp.Funcionario.Nome);
                    //Console.WriteLine("CPF: " + fp.Funcionario.Cpf);
                    //Console.WriteLine("Mês: " + fp.Mes + " Ano: " + fp.Ano);
                    
                    Console.WriteLine("Salário Bruto: " + Calculos.SalarioBruto(fp.HorasTrabalhadas, fp.ValorHora).ToString("C2"));
                    Console.WriteLine("Imposto de Renda: " + Calculos.ImpostoDeRenda(fp.HorasTrabalhadas, fp.ValorHora).ToString("C2"));
                    Console.WriteLine("INSS: " + Calculos.INSS(fp.HorasTrabalhadas, fp.ValorHora).ToString("C2"));
                    Console.WriteLine("FGTS: " + Calculos.FGTS(fp.HorasTrabalhadas, fp.ValorHora).ToString("C2"));
                    Console.WriteLine("Bônus: " + Calculos.Bonus(fp.Funcionario.Cargo.Bonus, fp.HorasTrabalhadas, fp.ValorHora).ToString("C2"));
                    Console.WriteLine("Salário Líquido: " + (Calculos.SalarioBruto(fp.HorasTrabalhadas, fp.ValorHora)-
                        Calculos.ImpostoDeRenda(fp.HorasTrabalhadas, fp.ValorHora)-
                        Calculos.INSS(fp.HorasTrabalhadas, fp.ValorHora)).ToString("C2"));

                }
                else
                {
                    Console.WriteLine("Nenhuma Folha de Pagamento encontrada com essas informações");
                }
            }
            else
            {
                Console.WriteLine("Funcionário não encontrado");
            }
            

            //foreach (FolhaDePagamento pgtoCadastradas in FolhaDePagamentoDAO.retornaFolhasDePagamentos())
            //{
            //    Console.WriteLine(pgtoCadastradas);
            //}
        }
    }
}
