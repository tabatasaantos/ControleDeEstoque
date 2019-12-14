using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using System.Text.RegularExpressions;
using System.Data;
using Ferramenta;

namespace BLL
{
   public class BLLFornecedor
    {
        private DALConexao conexao;

        public BLLFornecedor(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloFornecedor modelo)
        {
            if (modelo.ForNome.Trim().Length == 0)
            {
                throw new Exception("O nome do fornecedor é obrigatório!");
            }

            if (modelo.ForCnpj.Trim().Length == 0)
            {
                throw new Exception("O CNPJ do fornecedor é obrigatório!");
            }

            //verificando cnpj            
            if (Validacao.IsCnpj(modelo.ForCnpj) == false)
            {
                throw new Exception("CNPJ Inválido!");
            }

            if (modelo.ForIe.Trim().Length == 0)
            {
                throw new Exception("O IE do fornecedor é obrigatório!");
            }

            if (modelo.ForFone.Trim().Length == 0)
            {
                throw new Exception("O Telefone do fornecedor é obrigatório!");
            }

            //Validação E-mail
            string strRegex = "^([a-zA-Z0-9_\\-\\.]+)@((\\[[0-9]{1,3}" +
                "\\.[0-9]{1,3}\\.[0-9]{1,3}\\.)|(([a-zA-Z0-9\\-]+" +
                "\\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\\]?)$";
            Regex re = new Regex(strRegex);
            if (!re.IsMatch(modelo.ForEmail))
            {
                throw new Exception("O e-mail está inválido");
            }

            //Validação CEP
            //if (Validacao.ValidaCep(modelo.ForCep) == false)
            //{
            //    throw new Exception("CEP Inválido!");
            //}

            //DALFornecedor DALobj = new DALFornecedor(conexao);
            //DALobj.Incluir(modelo);
        }


        public void Alterar(ModeloFornecedor modelo)
        {
            if (modelo.ForNome.Trim().Length == 0)
            {
                throw new Exception("O nome do fornecedor é obrigatório!");
            }

            if (modelo.ForCnpj.Trim().Length == 0)
            {
                throw new Exception("O CNPJ do fornecedor é obrigatório!");
            }

            if (Validacao.IsCnpj(modelo.ForCnpj) == false)
            {
                throw new Exception("CNPJ Inválido!");
            }

            if (modelo.ForIe.Trim().Length == 0)
            {
                throw new Exception("O IE do fornecedor é obrigatório!");
            }

            if (modelo.ForFone.Trim().Length == 0)
            {
                throw new Exception("O Telefone do fornecedor é obrigatório!");
            }

            //Validação E-mail
            string strRegex = "^([a-zA-Z0-9_\\-\\.]+)@((\\[[0-9]{1,3}" +
                "\\.[0-9]{1,3}\\.[0-9]{1,3}\\.)|(([a-zA-Z0-9\\-]+" +
                "\\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\\]?)$"; 
            Regex re = new Regex(strRegex);
            if (!re.IsMatch(modelo.ForEmail))
            {
                throw new Exception("O e-mail está inválido!");
            }

            DALFornecedor DALobj = new DALFornecedor(conexao);
            DALobj.Incluir(modelo);
        }

        public void Excluir(int codigo)
        {
            DALFornecedor Dalobj = new DALFornecedor(conexao);
            Dalobj.Excluir(codigo);
        }

        public DataTable Localizar(string valor)
        {
            DALFornecedor Dalobj = new DALFornecedor(conexao);
            return Dalobj.Localizar(valor);
        }

        public DataTable LocalizarPorNome(string valor)
        {
            DALFornecedor Dalobj = new DALFornecedor(conexao);
            return Dalobj.LocalizarPorNome(valor);
        }

        public DataTable LocalizarPorCNPJ(string valor)
        {
            DALFornecedor Dalobj = new DALFornecedor(conexao);
            return Dalobj.LocalizarPorCNPJ(valor);
        }

        public ModeloFornecedor CarregaModeloFornecedor(int codigo)
        {
            DALFornecedor Dalobj = new DALFornecedor(conexao);
            return Dalobj.CarregaModeloFornecedor(codigo);
        }

        public ModeloFornecedor CarregaModeloFornecedor(string cnpj)
        {
            DALFornecedor Dalobj = new DALFornecedor(conexao);
            return Dalobj.CarregaModeloFornecedor(cnpj);
        }
    }
}
