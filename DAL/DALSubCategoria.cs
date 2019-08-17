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
        private DALConexao conexao;

        public DALSubCategoria(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloSubCategoria modelo)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.CommandText = "INSERT SUBCATEGORIA(CAT_COD, SCAT_NOME) VALUES (@CATCOD, @NOME); SELECT @@IDENTITY;";
                cmd.Parameters.AddWithValue("@CATCOD", modelo.CatCod);
                cmd.Parameters.AddWithValue("@NOME", modelo.SCatNome);
                conexao.Conectar();
                modelo.CatCod = Convert.ToInt32(cmd.ExecuteScalar());
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
                cmd.CommandText = "DELETE FROM SUBCATEGORIA WHERE SCAT_COD = @CODIGO";
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
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM SUBCATEGORIA WHERE SCAT_NOME LIKE '%" + valor + "%'", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        public ModeloSubCategoria CarregaModeloSubCategoria(int codigo)
        {
            ModeloSubCategoria modelo = new ModeloSubCategoria();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "SELECT * FROM SUBCATEGORIA WHERE SCAT_COD = @CODIGO";
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
}
