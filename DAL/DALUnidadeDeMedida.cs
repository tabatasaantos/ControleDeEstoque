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
    public class DALUnidadeDeMedida
    {
        private DALConexao conexao;
        
        public DALUnidadeDeMedida(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloUnidadeDeMedida modelo)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.CommandText = "INSERT UNDMEDIDA(UMED_NOME) VALUES (@NOME); SELECT @@IDENTITY;";
                cmd.Parameters.AddWithValue("@NOME", modelo.UmedNome);
                conexao.Conectar();
                modelo.UmedCod = Convert.ToInt32(cmd.ExecuteScalar());
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

        public void Alterar(ModeloUnidadeDeMedida modelo)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.CommandText = "UPDATE UNDMEDIDA SET UMED_NOME = @NOME WHERE UMED_COD = @COD;";
                cmd.Parameters.AddWithValue("@NOME", modelo.UmedNome);
                cmd.Parameters.AddWithValue("@COD", modelo.UmedCod);
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
                cmd.CommandText = "DELETE FROM UNDMEDIDA WHERE UMED_COD = @CODIGO;";
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
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM UNDMEDIDA WHERE UMED_NOME LIKE '%" + valor + "%'", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        public int VerificaUnidadeDeMedida(string valor) //0 - não existe valor no BD / numero > 0 existe
        {
            int r = 0; // 0 - não existe
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "SELECT * FROM UNDMEDIDA WHERE UMED_NOME = @NOME;";
            cmd.Parameters.AddWithValue("@nome", valor);
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();

            if (registro.HasRows)
            {
                registro.Read();
                r = Convert.ToInt32(registro["UMED_COD"]);
            }

            conexao.Desconectar();
            return r;
        }

        public ModeloUnidadeDeMedida CarregaModeloUnidadeDeMedida(int codigo)
        {
            ModeloUnidadeDeMedida modelo = new ModeloUnidadeDeMedida();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "SELECT * FROM UNDMEDIDA WHERE UMED_COD = @CODIGO;";
            cmd.Parameters.AddWithValue("@CODIGO", codigo);
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                modelo.UmedCod = Convert.ToInt32(registro["UMED_COD"]);
                modelo.UmedNome = Convert.ToString(registro["UMED_NOME"]);
            }

            conexao.Desconectar();
            return modelo;
        }
    }
}

