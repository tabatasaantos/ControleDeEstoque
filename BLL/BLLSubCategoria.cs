using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using DAL;
using System.Data;

namespace BLL
{
    public class BLLSubCategoria
    {

        private DALConexao conexao;

        public BLLSubCategoria(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloSubCategoria modelo)
        {
            if (modelo.SCatNome.Trim().Length == 0)
            {
                throw new Exception("O nome da categoria é obrigatório!");
            }

            if(modelo.CatCod <= 0)
            {
                throw new Exception("O código da categoria é obrigatório!");
            }
            
            DALSubCategoria DALobj = new DALSubCategoria(conexao);
            DALobj.Incluir(modelo);
        }

        public void Alterar(ModeloSubCategoria modelo)
        {
            if (modelo.SCatNome.Trim().Length == 0)
            {
                throw new Exception("O nome da categoria é obrigatório!");
            }

            if (modelo.CatCod <= 0)
            {
                throw new Exception("O código da categoria é obrigatório!");
            }
            if (modelo.ScatCod <= 0)
            {
                throw new Exception("O código da subcategoria é obrigatório!");
            }

            DALSubCategoria DALobj = new DALSubCategoria(conexao);
            DALobj.Alterar(modelo);

        }

        public void Excluir(int codigo)
        {
            DALSubCategoria Dalobj = new DALSubCategoria(conexao);
            Dalobj.Excluir(codigo);
        }

        public DataTable Localizar(string valor)
        {
            DALSubCategoria Dalobj = new DALSubCategoria(conexao);
            return Dalobj.Localizar(valor);
        }

        public ModeloSubCategoria CarregaModeloCategoria(int codigo)
        {
            DALSubCategoria Dalobj = new DALSubCategoria(conexao);
            return Dalobj.CarregaModeloSubCategoria(codigo);
        }
    }
}
   

