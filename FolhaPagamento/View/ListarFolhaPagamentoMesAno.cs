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
    class ListarFolhaPagamentoMesAno
    {
        public static void Renderizar()
        {
            FolhaDePagamento fp = new FolhaDePagamento();
            Console.WriteLine("\tCONSULTAR HISTÓRICO DE FOLHAS DE PAGAMENTO DO MÊS");
            Console.WriteLine("informe o mês e ano: ");
            fp.MesAno = Convert.ToDateTime(Console.ReadLine());

            fp = FolhaDePagamentoDAO.ConsultarFolhaDePagamentoMesAno(fp.MesAno.Month, fp.MesAno.Year);
            if (fp != null)
            {
                double total = 0;
                foreach (FolhaDePagamento pgtosCadastradas in FolhaDePagamentoDAO.RetornaFolhasDePamanetoPorMesAno(fp.MesAno.Month, fp.MesAno.Year))
                {
                    Console.WriteLine("\n");
                    Console.WriteLine("Nome do funcionário: " + pgtosCadastradas.Funcionario.Nome);
                    Console.WriteLine("Cargo: " + pgtosCadastradas.Cargo.Nome);
                    Console.WriteLine("Data da folha de pagamento: " + pgtosCadastradas.MesAno.ToString("MM/yyyy"));
                    Console.WriteLine("Salário Bruto: " + Calculos.SalarioBruto(pgtosCadastradas.HorasTrabalhadas, pgtosCadastradas.ValorHora).ToString("C2"));
                    Console.WriteLine("Imposto de Renda: " + Calculos.ImpostoDeRenda(pgtosCadastradas.HorasTrabalhadas, pgtosCadastradas.ValorHora).ToString("C2"));
                    Console.WriteLine("INSS: " + Calculos.INSS(pgtosCadastradas.HorasTrabalhadas, pgtosCadastradas.ValorHora).ToString("C2"));
                    Console.WriteLine("FGTS: " + Calculos.FGTS(pgtosCadastradas.HorasTrabalhadas, pgtosCadastradas.ValorHora).ToString("C2"));
                    Console.WriteLine("Bônus: " + Calculos.Bonus(pgtosCadastradas.Cargo.Bonus, pgtosCadastradas.HorasTrabalhadas, pgtosCadastradas.ValorHora).ToString("C2"));
                    Console.WriteLine("Salário Líquido: " + (Calculos.SalarioBruto(pgtosCadastradas.HorasTrabalhadas, pgtosCadastradas.ValorHora) -
                        Calculos.ImpostoDeRenda(pgtosCadastradas.HorasTrabalhadas, pgtosCadastradas.ValorHora) -
                        Calculos.INSS(pgtosCadastradas.HorasTrabalhadas, pgtosCadastradas.ValorHora)).ToString("C2"));
                    total += Calculos.SalarioBruto(pgtosCadastradas.HorasTrabalhadas, pgtosCadastradas.ValorHora);
                }
                Console.WriteLine("\tTotal Salário: " + total.ToString("C2"));
            }
            else
            {
                Console.WriteLine("Nenhum registro encontrado para essa data");
            }
        }
    }
}
