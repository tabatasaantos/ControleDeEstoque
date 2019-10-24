using DAL;
using Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
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

            if (modelo.CliRgIe.Trim().Length == 0)
            {
                throw new Exception("O RG/IE do cliente é obrigatório!");
            }

            if (modelo.CliFone.Trim().Length == 0)
            {
                throw new Exception("O Telefone do cliente é obrigatório!");
            }

            // cli_tipo = 0 -> física
            // cli_tipo = 1 -> juridica


            DALCliente DALobj = new DALCliente(conexao);
            DALobj.Incluir(modelo);
        }

        public void Alterar(ModeloCliente modelo)
        {
            if (modelo.CliNome.Trim().Length == 0)
            {
                throw new Exception("O nome do cliente é obrigatório!");
            }

            if (modelo.CliCpfCnpj.Trim().Length == 0)
            {
                throw new Exception("O CPF/CNPJ do cliente é obrigatório!");
            }

            if (modelo.CliRgIe.Trim().Length == 0)
            {
                throw new Exception("O RG/IE do cliente é obrigatório!");
            }

            if (modelo.CliFone.Trim().Length == 0)
            {
                throw new Exception("O Telefone do cliente é obrigatório!");
            }

            DALCliente DALobj = new DALCliente(conexao);
            DALobj.Alterar(modelo);
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
