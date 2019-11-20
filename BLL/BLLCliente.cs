using DAL;
using Ferramenta;
using Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BLL
{
    public class BLLCliente
    {
        private DALConexao conexao;

        public BLLCliente(DALConexao cx) 
        {
            this.conexao = cx; 
        }

        public void Incluir(ModeloCliente modelo) 
        {
            if (modelo.CliNome.Trim().Length == 0)
            {
                throw new Exception("O nome do cliente é obrigatório!");
            }         

            if (modelo.CliCpfCnpj.Trim().Length == 0)
            {
                throw new Exception("O CPF/CNPJ do cliente é obrigatório!");
            }

            //validacão cpf 
            if (modelo.CliTipo == "Física")
            {
                if(Validacao.IsCpf(modelo.CliCpfCnpj) == false)
                {
                    throw new Exception("CPF Inválido!");
                }
            }
            //verificando cnpj
            else
            {                
                if (Validacao.IsCpf(modelo.CliCpfCnpj) == false)
                {
                    throw new Exception("CNPJ Inválido!");
                }
            }

            if (modelo.CliRgIe.Trim().Length == 0)
            {
                throw new Exception("O RG/IE do cliente é obrigatório!");
            }

            if (modelo.CliFone.Trim().Length == 0)
            {
                throw new Exception("O Telefone do cliente é obrigatório!");
            }

            //Validação E-mail
            string strRegex = "^([a-zA-Z0-9_\\-\\.]+)@((\\[[0-9]{1,3}" +
                "\\.[0-9]{1,3}\\.[0-9]{1,3}\\.)|(([a-zA-Z0-9\\-]+" +
                "\\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\\]?)$";
            Regex re = new Regex(strRegex);
            if (!re.IsMatch(modelo.CliEmail))
            {
                throw new Exception("O e-mail está inválido");
            }

            //Validação CEP
            //if (Validacao.ValidaCep(modelo.CliCep) == false)
            //{
            //    throw new Exception("CEP Inválido!");
            //}

            DALCliente DALobj = new DALCliente(conexao);
            DALobj.Incluir(modelo);
        }

       
        public void Alterar(ModeloCliente modelo)
        {
            if (modelo.CliNome.Trim().Length == 0)
            {
                throw new Exception("O nome do cliente é obrigatório!");
            }

            if (modelo.CliRgIe.Trim().Length == 0)
            {
                throw new Exception("O RG/IE do cliente é obrigatório!");
            }

            if (modelo.CliFone.Trim().Length == 0)
            {
                throw new Exception("O Telefone do cliente é obrigatório!");
            }

            //Validação E-mail
            string strRegex = "^([a-zA-Z0-9_\\-\\.]+)@((\\[[0-9]{1,3}" +
                "\\.[0-9]{1,3}\\.[0-9]{1,3}\\.)|(([a-zA-Z0-9\\-]+" +
                "\\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\\]?)$"; //verificar esse código e a validação do cpf
            Regex re = new Regex(strRegex);
            if (!re.IsMatch(modelo.CliEmail))
            {
                throw new Exception("O e-mail está inválido!");
            }

            DALCliente DALobj = new DALCliente(conexao);
            DALobj.Incluir(modelo);
        }

        public void Excluir(int codigo)
        {
            DALCliente Dalobj = new DALCliente(conexao);
            Dalobj.Excluir(codigo);
        }

        public DataTable Localizar(string valor)
        {
            DALCliente Dalobj = new DALCliente(conexao);
            return Dalobj.Localizar(valor);
        }

        public DataTable LocalizarPorNome(string valor)
        {
            DALCliente Dalobj = new DALCliente(conexao);
            return Dalobj.LocalizarPorNome(valor);
        }

        public DataTable LocalizarPorCPFCNPJ(string valor)
        {
            DALCliente Dalobj = new DALCliente(conexao);
            return Dalobj.LocalizarPorCPFCNPJ(valor);
        }

        public ModeloCliente CarregaModeloCliente(int codigo)
        {
            DALCliente Dalobj = new DALCliente(conexao);
            return Dalobj.CarregaModeloCliente(codigo);
        }

        public ModeloCliente CarregaModeloCliente(string cpfcnpj)
        {
            DALCliente Dalobj = new DALCliente(conexao);
            return Dalobj.CarregaModeloCliente(cpfcnpj);
        }
    }
}
