﻿using DAL;
using Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
   public class BLLCompra
    {
        private DALConexao conexao;

        public BLLCompra(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloCompra modelo)
        {
            //if (modelo.ComData != DateTime.Now)
            //{
            //    throw new Exception("O data de compra não corresponde a data atual!");
            //}

            if (modelo.ComNParcelas <= 0)
            {
                throw new Exception("O número de parcelas deve ser maior do que 0!");
            }

            if (modelo.ForCod <= 0)
            {
                throw new Exception("O código do fornecedor deve ser informado!");
            }

            if (modelo.ComTotal <= 0)
            {
                throw new Exception("O valor de compra deve ser informado!");
            }

            DALCompra DALobj = new DALCompra(conexao);
            DALobj.Incluir(modelo);
        }

        public void Alterar(ModeloCompra modelo)
        {
            if (modelo.ComCod <= 0)
            {
                throw new Exception("O código da compra não pode ser 0 ou menor que 0");
            }

            if (modelo.ComNParcelas <= 0)
            {
                throw new Exception("O número de parcelas deve ser maior do que 0!");
            }

            if (modelo.ForCod <= 0)
            {
                throw new Exception("O código do fornecedor deve ser informado!");
            }

            if (modelo.ComTotal <= 0)
            {
                throw new Exception("O valor de compra deve ser informado!");
            }

            DALCompra DALobj = new DALCompra(conexao);
            DALobj.Alterar(modelo);
        }

        public void Excluir(int codigo)
        {
            DALCompra DALobj = new DALCompra(conexao);
            DALobj.Excluir(codigo);
        }

        public DataTable Localizar(int codigo)
        {
            DALCompra DALobj = new DALCompra(conexao);
            return DALobj.Localizar(codigo);

        }

        public DataTable Localizar(string nome)
        {
            DALCompra DALobj = new DALCompra(conexao);
            return DALobj.Localizar(nome);
        }

        public DataTable Localizar(DateTime dtinicial, DateTime dtfinal)
        {
            DALCompra DALobj = new DALCompra(conexao);
            return DALobj.Localizar(dtinicial, dtfinal);
        }

        public ModeloCompra CarregaModeloCompra(int codigo)
        {
            DALCompra DALobj = new DALCompra(conexao);
            return DALobj.CarregaModeloCompra(codigo);
        }
    }
}
