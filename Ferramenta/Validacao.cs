using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Ferramenta
{
    public class Validacao
    {
        public static bool IsCpf(string cpf)
        {
            //Valida CPF

            int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int soma, resto;
            string tempCpf, digito;

            cpf = cpf.Trim();
            cpf = cpf.Replace(".", "").Replace(".", "").Replace(" ", "").Replace("-", "");

            if (cpf.Length != 11)
            {
                return false;
            }
            else
            {
                tempCpf = cpf.Substring(0, 9);

                soma = 0;
                for (int i = 0; i < 9; i++)
                {
                    soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];
                }
                resto = soma % 11;

                if (resto < 2)
                {
                    resto = 0;
                }

                else
                {
                    resto = 11 - resto;
                }
                   
                digito = resto.ToString();
                tempCpf = tempCpf + digito;

                soma = 0;
                for (int i = 0; i < 10; i++)
                {
                    soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];
                }

                resto = soma % 11;
                if (resto < 2)
                {
                    resto = 0;
                }

                else
                {
                    resto = 11 - resto;
                }                  

                digito = digito + resto.ToString();
                return cpf.EndsWith(digito);
            }

        }

        public static bool IsCnpj(string cnpj)
        {
            int[] multiplicador1 = new int[12] { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2};
            int[] multiplicador2 = new int[13] { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int soma, resto;
            string tempCnpj, digito;

            cnpj = cnpj.Trim();
            cnpj = cnpj.Replace(".", "").Replace(".", "").Replace("/", "").Replace(" ", ""); 

            if(cnpj.Length != 14)
            {
                return false;
            }
            else
            {
                tempCnpj = cnpj.Substring(0, 12);

                soma = 0;
                for(int i = 0; i < 12; i++)
                {
                    soma += int.Parse(tempCnpj[i].ToString()) * multiplicador1[i];
                }

                resto = (soma % 11);
                if(resto < 2)
                {
                    resto = 0;
                }
                else
                {
                    resto = (11 - resto);
                }

                digito = resto.ToString();
                tempCnpj = tempCnpj + digito;

                soma = 0;
                for(int i = 0; i < 13; i++)
                {
                    soma += int.Parse(tempCnpj[i].ToString()) * multiplicador2[i];
                }

                resto = (soma % 11);
                if(resto < 2)
                {
                    resto = 0;
                }

                resto = (11 - resto);

                digito = digito + resto.ToString();
                return cnpj.EndsWith(digito);
            }
        }

        //Validação E-mail
        public static bool ValidaEmail(string email)
        {
            //Validação E-mail
            string strRegex = "^([a-zA-Z0-9_\\-\\.]+)@((\\[[0-9]{1,3}" +
                "\\.[0-9]{1,3}\\.[0-9]{1,3}\\.)|(([a-zA-Z0-9\\-]+" +
                "\\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\\]?)$"; //verificar esse código e a validação do cpf
            Regex re = new Regex(strRegex);
            return re.IsMatch(email);
        }

        //Validação CEP
        public static bool ValidaCep(string cep)
        {
            var retorno = Regex.IsMatch(cep, ("[0-9]{5}-[0-9]{3}"));
            return retorno;
        }
    }
}
