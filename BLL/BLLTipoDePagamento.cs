using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using System.Data;

namespace BLL
{
   public class BLLTipoDePagamento
    {
        DALConexao conexao;

        public BLLTipoDePagamento(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloTipoDePagamento modelo)
        {
            if(modelo.TpaNome.Trim().Length == 0)
            {
                throw new Exception("O tipo de pagamento é obrigatório!");
            }

            DALTipoDePagamento DALobj = new DALTipoDePagamento(conexao);  
            DALobj.Incluir(modelo);
        }

        public void Alterar(ModeloTipoDePagamento modelo)
        {
            if(modelo.TpaCod <= 0)
            {
                throw new Exception("O código do tipo de pagamento é obrigatório!");
            }

            if (modelo.TpaNome.Trim().Length == 0)
            {
                throw new Exception("O tipo de pagamento é obrigatório!");
            }

            DALTipoDePagamento DALobj = new DALTipoDePagamento(conexao);
            DALobj.Incluir(modelo);
        }

        public void Excluir(int codigo)
        {
            DALTipoDePagamento Dalobj = new DALTipoDePagamento(conexao);
            Dalobj.Excluir(codigo);
        }

        public DataTable Localizar(string valor)
        {
            DALTipoDePagamento Dalobj = new DALTipoDePagamento(conexao);
            return Dalobj.Localizar(valor);
        }

        public ModeloTipoDePagamento CarregaModeloTipoDePagamento(int codigo)
        {
            DALTipoDePagamento Dalobj = new DALTipoDePagamento(conexao);
            return Dalobj.CarregaModeloTipoDePagamento(codigo);
        }
    }
}
