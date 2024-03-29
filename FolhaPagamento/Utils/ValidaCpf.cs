﻿using FolhaPagamento.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolhaPagamento.Utils
{
    class ValidaCpf
    {
        public static bool ValidarCpf(string cpf)
        {
            cpf= cpf.Replace(".", "").Replace("-", "");

            if (cpf.Length != 11)
            {
                return false;
            }
            switch (cpf)
            {
                case "00000000000":
                case "11111111111":
                case "22222222222":
                case "33333333333":
                case "44444444444":
                case "55555555555":
                case "66666666666":
                case "77777777777":
                case "88888888888":
                case "99999999999":
                    return false;
                default:
                    break;
            }

            char[] vetor = cpf.ToCharArray();
            int peso = 10, multiplicacao, somatorio = 0, resto, digito1, digito2;

            for (int i = 0; i < 9; i++)
            {
                multiplicacao = Convert.ToInt32(vetor[i].ToString()) * peso;
                somatorio += multiplicacao;
                peso--;
            }
            resto = somatorio % 11;
            if (resto < 2)
            {
                digito1 = 0;
            }
            else
            {
                digito1 = 11 - resto;
            }

            peso = 11;
            somatorio = 0;

            for (int i = 0; i < 10; i++)
            {
                multiplicacao = Convert.ToInt32(vetor[i].ToString()) * peso;
                somatorio += multiplicacao;
                peso--;
            }
            resto = somatorio % 11;
            if (resto < 2)
            {
                digito2 = 0;
            }
            else
            {
                digito2 = 11 - resto;
            }
            
            if (Convert.ToInt32(vetor[9].ToString()) == digito1 &&
                Convert.ToInt32(vetor[10].ToString()) == digito2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
