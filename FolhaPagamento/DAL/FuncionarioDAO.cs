using FolhaPagamento.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolhaPagamento.DAL
{
    class FuncionarioDAO
    {
        public static List<Funcionario> funcionarios = new List<Funcionario>();
        public static bool CadastrarFuncionario(Funcionario f)
        {
            if(BuscarFuncionarioPorCpf(f.Cpf) != null)
            {
                return false;
            }
            funcionarios.Add(f);
            return true;
        }

        public static Funcionario BuscarFuncionarioPorCpf(string cpf)
        {
            foreach (Funcionario funcionariosCadastrados in funcionarios)
            {
                if (funcionariosCadastrados.Cpf.Equals(cpf))
                {
                    return funcionariosCadastrados;
                }
            }
            return null;
        }

        public static List<Funcionario> RetornaFuncionarios()
        {
            return funcionarios;
        }
    }
}
