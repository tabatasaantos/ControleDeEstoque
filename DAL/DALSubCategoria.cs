using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;

namespace DAL
{
    public class DALSubCategoria
    {
        private DALConexao conexao; //criando atributo do tipo DAL

        public DALSubCategoria(DALConexao cx) //construtor com parâmetro do tipo DAL
        {
            this.conexao = cx; //passando o valor do atributo para o parâmetro 
        }

        public void Incluir(ModeloSubCategoria modelo) //criando método com parâmetro do tipo modelo
        {
            try
            {
                SqlCommand cmd = new SqlCommand(); //inicializando uma nova instância da classe sql
                cmd.Connection = conexao.ObjetoConexao; //passando para a variável local e propriedade do Sql a variável conexão com a proprieda Objeto
                cmd.CommandText = "INSERT SUBCATEGORIA(CAT_COD, SCAT_NOME) VALUES (@CATCOD, @NOME); SELECT @@IDENTITY;";
                cmd.Parameters.AddWithValue("@CATCOD", modelo.CatCod);
                cmd.Parameters.AddWithValue("@NOME", modelo.SCatNome);
                conexao.Conectar();
                modelo.ScatCod = Convert.ToInt32(cmd.ExecuteScalar()); //executa a primeira linha, as adicionais são ignoradas 
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                conexao.Desconectar();
            }
            
        }

        public void Alterar(ModeloSubCategoria modelo)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                //erro 2: erro ao alterar uma subcategoria. Erro ocorreu porque o comabdo SQL estava com o AND no lugar da ,.
                //cmd.CommandText = "UPDATE SUBCATEGORIA SET SCAT_NOME = @NOME AND CAT_COD = @CATCOD WHERE SCAT_COD = @SCATCOD;";
                cmd.CommandText = "UPDATE SUBCATEGORIA SET SCAT_NOME = @NOME, CAT_COD = @CATCOD WHERE SCAT_COD = @SCATCOD;";
                cmd.Parameters.AddWithValue("@NOME", modelo.SCatNome);
                cmd.Parameters.AddWithValue("@CATCOD", modelo.CatCod);
                cmd.Parameters.AddWithValue("@SCATCOD", modelo.ScatCod);
                conexao.Conectar();
                cmd.ExecuteNonQuery();
            }

            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            finally
            {
                conexao.Desconectar();
            }
        }

        public void Excluir(int codigo)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.CommandText = "DELETE FROM SUBCATEGORIA WHERE SCAT_COD = @CODIGO;";
                cmd.Parameters.AddWithValue("@CODIGO", codigo);
                conexao.Conectar();
                cmd.ExecuteNonQuery();
            }

            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            finally
            {
                conexao.Desconectar();
            }
        }

        public DataTable Localizar(string valor)
        {
            DataTable tabela = new DataTable(); //instanciando o datatable com o nome tabela.
            SqlDataAdapter da = new SqlDataAdapter("SELECT SC.SCAT_COD, SC.SCAT_NOME, SC.CAT_COD, C.CAT_NOME "+
            " FROM SUBCATEGORIA SC INNER JOIN CATEGORIA C ON SC.CAT_COD = C.CAT_COD WHERE SCAT_NOME LIKE '%" + valor + "%'", conexao.StringConexao);
            da.Fill(tabela); //erro 7: estava acontecendo por estar faltando a essa linha. A variavel não estava recebendo um valor e por isso
            // retornava um valor nulo.
            // passando o "da" que é o que contém o comando SQL conforme passado acima, precisamos atribuir o que o comando trás
            // com o FILL para a variável criada na datatable para ela não fica vazia.
            return tabela; //retornando o resultado do comando SQL
        }

        public DataTable LocalizarPorCategoria(int categoria)
        {
            DataTable tabela = new DataTable(); 
            SqlDataAdapter da = new SqlDataAdapter("SELECT SC.SCAT_COD, SC.SCAT_NOME, SC.CAT_COD, C.CAT_NOME " +
            " FROM SUBCATEGORIA SC INNER JOIN CATEGORIA C ON SC.CAT_COD = C.CAT_COD WHERE SC.CAT_COD = " + categoria.ToString(),
            conexao.StringConexao);
            da.Fill(tabela); 
            return tabela;       
        }

        public ModeloSubCategoria CarregaModeloSubCategoria(int codigo)
        {
            ModeloSubCategoria modelo = new ModeloSubCategoria();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "SELECT * FROM SUBCATEGORIA WHERE SCAT_COD = @CODIGO;";
            cmd.Parameters.AddWithValue("@CODIGO", codigo);
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                modelo.CatCod = Convert.ToInt32(registro["CAT_COD"]);
                modelo.SCatNome = Convert.ToString(registro["SCAT_NOME"]);
                modelo.ScatCod = Convert.ToInt32(registro["SCAT_COD"]);
            }

            conexao.Desconectar();
            return modelo;
        }
    }
}

