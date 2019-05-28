using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebAtividadeEntrevista.Models.ValidationAttributes
{
    public class ValidaCPF: ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            if (value is string && value != null)
            {
                string CPF = value as string;
                return Validar(CPF);              
            }
            return false;
        }

        /// <summary>
        /// Função que retorna se o CPF é valido
        /// </summary>
        /// <param name="CPF">N.º do CPF</param>
        /// <returns>Se o CPF for valido (true), se não False</returns>
        private bool Validar(string CPF)
        {
            int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            string tempCpf;
            string digito;
            int soma;
            int resto;
            CPF = CPF.Trim();
            CPF = CPF.Replace(".", "").Replace("-", "");
            if (CPF.Length != 11)
                return false;
            tempCpf = CPF.Substring(0, 9);
            soma = 0;

            for (int i = 0; i < 9; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];
            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = resto.ToString();
            tempCpf += digito;
            soma = 0;
            for (int i = 0; i < 10; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];
            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito += resto.ToString();
            return CPF.EndsWith(digito);
        }
    }
}