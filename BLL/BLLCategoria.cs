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
    public class BLLCategoria //classe categoria
    {
        private DALConexao conexao; //instanciando a classe DAL

        public BLLCategoria(DALConexao cx) //criando um construtor e passando para ele um parâmetro do tipo DAL
        {
            this.conexao = cx; //passando para a variável do tipo DAL o parãmetro do mesmo tipo
        }

        public void Incluir(ModeloCategoria modelo) //criando método com variável do tipo modelo
        {
            if (modelo.CatNome.Trim().Length == 0) //retirando os espaços em branco do parâmetro/variável nome e verificando se o que há nele é igual a 0
            {
                throw new Exception("O nome da categoria é obrigatório!"); //retornando uma mensagem através do throw que vai direto no tratamento, sem precisar de um catch
            }

            DALCategoria DALobj = new DALCategoria(conexao); //perguntar 
            DALobj.Incluir(modelo);
        }


        public void Alterar(ModeloCategoria modelo)
        {
            if(modelo.CatCod <= 0) //verificando se o que há no parâmetro/variável é igual ou menor a 0
            {
                throw new Exception("O código da categoria é obrigatório!"); //retornando uma mensagem através do throw que vai direto no tratamento, sem precisar de um catch
            }

            if (modelo.CatNome.Trim().Length == 0) //retirando os espaços em branco do parâmetro/variável nome e verificando se o que há nele é igual a 0
            {
                throw new Exception("O nome da categoria é obrigatório!"); //retornando uma mensagem através do throw que vai direto no tratamento, sem precisar de um catch
            }   

            DALCategoria DALobj = new DALCategoria(conexao);
            DALobj.Alterar(modelo);
        }

        public void Excluir(int codigo)
        {
            DALCategoria Dalobj = new DALCategoria(conexao);
            Dalobj.Excluir(codigo);
        }

        public DataTable Localizar(string valor)
        { 
            DALCategoria Dalobj = new DALCategoria(conexao);
            return Dalobj.Localizar(valor);
        }

        public ModeloCategoria CarregaModeloCategoria(int codigo)
        {
            DALCategoria Dalobj = new DALCategoria(conexao);
            return Dalobj.CarregaModeloCategoria(codigo);
        }
    }
}
