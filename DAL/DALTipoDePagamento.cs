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
    public class DALTipoDePagamento
    {
        private DALConexao conexao;

        public DALTipoDePagamento(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloTipoDePagamento modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "INSERT TIPOPAGAMENTO(TPA_NOME) VALUES (@NOME); SELECT @@IDENTITY;";
            cmd.Parameters.AddWithValue("@NOME", modelo.TpaNome);
            conexao.Conectar();
            modelo.TpaCod = Convert.ToInt32(cmd.ExecuteScalar());
            conexao.Desconectar();
        }

        public void Alterar(ModeloTipoDePagamento modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "UPDATE TIPOPAGAMENTO SET TPA_NOME = NOME WHERE TPA_COD = @CODIGO";
            cmd.Parameters.AddWithValue("@NOME", modelo.TpaNome);
            cmd.Parameters.AddWithValue("@CODIGO", modelo.TpaCod);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }

        public void Excluir(int codigo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "DELETE FROM TIPOPAGAMENTO WHERE TPA_COD = @CODIGO";
            cmd.Parameters.AddWithValue("@CODIGO", codigo);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }

        public DataTable Localizar(string valor)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM TIPOPAGAMENTO WHERE TPA_NOME LIKE '%" + valor + "%'", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        public ModeloTipoDePagamento CarregaModeloTipoDePagamento(int codigo)
        {
            ModeloTipoDePagamento modelo = new ModeloTipoDePagamento();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "SELECT * FROM TIPOPAGAMENTO WHERE TPA_COD = @CODIGO";
            cmd.Parameters.AddWithValue("@CODIGO", codigo);
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader(); //passando para a variável registro os dados com mais detalhes da conexão do banco
            if (registro.HasRows) //verificando se há dados na variável registro
            {
                registro.Read(); //lendo os dados da variável registro
                modelo.TpaCod = Convert.ToInt32(registro["TPA_COD"]);
                modelo.TpaNome = Convert.ToString(registro["TPA_NOME"]);
            }

            conexao.Desconectar();
            return modelo;

        }
    }
}
