using FolhaPagamento.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolhaPagamento.DAL
{
    class CargoDAO
    {
        public static List<Cargo> cargos = new List<Cargo>();


        public static bool CadastrarCargo(Cargo c)
        {
            //foreach (Cargo cargosCadastrados in cargos)
            //{
            //    if (cargosCadastrados.Nome.Equals(c.Nome))
            //    {
            //        return false;
            //    }
            //}
            //cargos.Add(c);
            //return true;

            if (BuscarCargoPeloNome(c.Nome) != null)
            {
                return false;
            }

            cargos.Add(c);
            return true;

        }

        public static Cargo BuscarCargoPeloNome(string nome)
        {
            foreach (Cargo cargosCadastrados in cargos)
            {
                if (cargosCadastrados.Nome.Equals(nome))
                {
                    return cargosCadastrados;
                }
            }
            return null;
        }

        public static List<Cargo> retornaCargos()
        {
            return cargos;
        }
    }
}
