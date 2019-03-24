using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolhaPagamento.Utils
{
    class Calculos
    {

        public static double SalarioBruto(int hrtrabalhadas, double vlhrtrabalhada)
        {
            return Convert.ToDouble(hrtrabalhadas) * vlhrtrabalhada;
        }

        public static double Bonus(double bonus, int hrtrabalhadas, double vlhrtrabalhada)
        {
            return (bonus / 100) * (Convert.ToDouble(hrtrabalhadas) * vlhrtrabalhada);
        }

        public static double ImpostoDeRenda(int hrtrabalhadas, double vlhrtrabalhada)
        {
            if (Convert.ToDouble(hrtrabalhadas) * vlhrtrabalhada <= (1903.98))
            {
                return 0;
            }
            if (Convert.ToDouble(hrtrabalhadas) * vlhrtrabalhada >= (1903.99)
                && Convert.ToDouble(hrtrabalhadas) * vlhrtrabalhada <= (2826.65))
            {
                return ((Convert.ToDouble(hrtrabalhadas) * vlhrtrabalhada) * 0.075) - 142.80;
            }
            if (Convert.ToDouble(hrtrabalhadas) * vlhrtrabalhada >= (2826.66)
                && Convert.ToDouble(hrtrabalhadas) * vlhrtrabalhada <= (3751.05))
            {
                return ((Convert.ToDouble(hrtrabalhadas) * vlhrtrabalhada) * 0.15) - 354.80;
            }
            if (Convert.ToDouble(hrtrabalhadas) * vlhrtrabalhada >= (3751.06)
                && Convert.ToDouble(hrtrabalhadas) * vlhrtrabalhada <= (4664.68))
            {
                return ((Convert.ToDouble(hrtrabalhadas) * vlhrtrabalhada) * 0.225) - 636.13;
            }
            if (Convert.ToDouble(hrtrabalhadas) * vlhrtrabalhada > (4664.68))
            {
                return ((Convert.ToDouble(hrtrabalhadas) * vlhrtrabalhada) * 0.275) - 869.36;
            }
            return 0;
        }
        public static double INSS(int hrtrabalhadas, double vlhrtrabalhada)
        {
            if (Convert.ToDouble(hrtrabalhadas) * vlhrtrabalhada <= (1693.72))
            {
                return (Convert.ToDouble(hrtrabalhadas) * vlhrtrabalhada) * 0.08;
            }
            if (Convert.ToDouble(hrtrabalhadas) * vlhrtrabalhada >= (1693.73)
                && Convert.ToDouble(hrtrabalhadas) * vlhrtrabalhada <= (2822.90))
            {
                return (Convert.ToDouble(hrtrabalhadas) * vlhrtrabalhada) * 0.09;
            }
            if (Convert.ToDouble(hrtrabalhadas) * vlhrtrabalhada >= (2822.91)
                && Convert.ToDouble(hrtrabalhadas) * vlhrtrabalhada <= (5645.80))
            {
                return (Convert.ToDouble(hrtrabalhadas) * vlhrtrabalhada) * 0.11;
            }
            if (Convert.ToDouble(hrtrabalhadas) * vlhrtrabalhada >= (5645.81))
            {
                return (Convert.ToDouble(hrtrabalhadas) * vlhrtrabalhada) - 621.03;
            }
            return 0;
        }

        public static double FGTS(int hrtrabalhadas, double vlhrtrabalhada)
        {
            return (Convert.ToDouble(hrtrabalhadas) * vlhrtrabalhada) * 0.08;
        }
    }
}
