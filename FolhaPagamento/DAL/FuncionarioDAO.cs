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


        public static bool cadastrarFuncionario(Funcionario f)
        {
            foreach (Funcionario funcionariosCadastrados in funcionarios)
            {
                if (funcionariosCadastrados.Cpf.Equals(f.Cpf))
                {
                    return false;
                }
            }
            funcionarios.Add(f);
            return true;
        }

        public static List<Funcionario> retornaFuncionarios()
        {
            return funcionarios;
        }
    }
}
