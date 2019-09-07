using Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALCategoria
    {
        private DALConexao conexao;

        public DALCategoria(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloCategoria modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "INSERT CATEGORIA(CAT_NOME) VALUES (@NOME); SELECT @@IDENTITY;";
            cmd.Parameters.AddWithValue("@NOME", modelo.CatNome);
            conexao.Conectar();
            modelo.CatCod = Convert.ToInt32(cmd.ExecuteScalar());
            conexao.Desconectar();

            //erro 4: como mostra na coluna abaixo, está sendo passado o parâmetro para o código, e como ele está definido
            //como identity, ele auto se incrementa, se passarmos um valor "x" ele não aceita e não consegue registrar um novo cadastro.
            //cmd.CommandText = "INSERT CATEGORIA(CAT_COD, CAT_NOME) VALUES (@CAT_COD, @NOME); SELECT @@IDENTITY;";
            //cmd.Parameters.AddWithValue("@CAT_COD", modelo.CatCod);
        }

        public void Alterar(ModeloCategoria modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "UPDATE CATEGORIA SET CAT_NOME = @NOME WHERE CAT_COD = @CODIGO";
            cmd.Parameters.AddWithValue("@NOME", modelo.CatNome);
            cmd.Parameters.AddWithValue("@CODIGO", modelo.CatCod);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }

        public void Excluir(int codigo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "DELETE FROM CATEGORIA WHERE CAT_COD = @CODIGO";
            cmd.Parameters.AddWithValue("@CODIGO", codigo);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }

        public DataTable Localizar(string valor)
        {
            DataTable tabela = new DataTable(); //comentar
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM CATEGORIA WHERE CAT_NOME LIKE '%" + valor + "%'", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        public ModeloCategoria CarregaModeloCategoria(int codigo)
        {
            ModeloCategoria modelo = new ModeloCategoria();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "SELECT * FROM CATEGORIA WHERE CAT_COD = @CODIGO";
            cmd.Parameters.AddWithValue("@CODIGO", codigo);
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();
            if(registro.HasRows)
            {
                registro.Read();
                modelo.CatCod = Convert.ToInt32(registro["CAT_COD"]);
                modelo.CatNome = Convert.ToString(registro["CAT_NOME"]);
            }

            conexao.Desconectar();

            return modelo;
        }
    }
}
