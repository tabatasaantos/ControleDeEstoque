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
    public class DALFornecedor
    {
        private DALConexao conexao;

        public DALFornecedor(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloFornecedor modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "INSERT FORNCEDOR(FOR_NOME, FOR_CNPJ, FOR_IE, FOR_RSOCIAL," +
                "FOR_CEP, FOR_ENDERECO, FOR_BAIRRO, FOR_FONE, FOR_CEL, FOR_EMAIL, FOR_ENDNUMERO," +
                "FOR_CIDADE, FOR_ESTADO) VALUES (@NOME, @CNPJ, @IE, @RSOCIAL, @CEP, @ENDERECO, @BAIRRO, @FONE, @CEL, @EMAIL, @ENDNUMERO," +
                "@CIDADE, @ESTADO); SELECT @@IDENTITY;";
            cmd.Parameters.AddWithValue("@NOME", modelo.ForNome);
            cmd.Parameters.AddWithValue("@CPFCNPJ", modelo.ForCnpj);
            cmd.Parameters.AddWithValue("@RGIE", modelo.ForIe);
            cmd.Parameters.AddWithValue("@RSOCIAL", modelo.ForRSocial);
            cmd.Parameters.AddWithValue("@CEP", modelo.ForCep);
            cmd.Parameters.AddWithValue("@ENDERECO", modelo.ForEndereco);
            cmd.Parameters.AddWithValue("@CIDADE", modelo.ForCidade);
            cmd.Parameters.AddWithValue("@ESTADO", modelo.ForEstado);
            cmd.Parameters.AddWithValue("@BAIRRO", modelo.ForBairro);
            cmd.Parameters.AddWithValue("@FONE", modelo.ForFone);
            cmd.Parameters.AddWithValue("@CEL", modelo.ForCel);
            cmd.Parameters.AddWithValue("@EMAIL", modelo.ForEmail);
            cmd.Parameters.AddWithValue("@ENDNUMERO", modelo.ForEndNum);

            conexao.Conectar();
            modelo.ForCod = Convert.ToInt32(cmd.ExecuteScalar());
            conexao.Desconectar();
        }

        public void Alterar(ModeloFornecedor modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "UPDATE FORENTE SET FOR_NOME = @NOME, FOR_CNPJ = @CNPJ, FOR_IE = @IE, FOR_RSOCIAL = @RSOCIAL," +
                "FOR_CEP = @CEP, FOR_ENDERECO = @ENDERECO, FOR_BAIRRO = @BAIRRO, FOR_FONE = @FONE, FOR_CEL = @CEL, FOR_EMAIL = @EMAIL," +
                "FOR_ENDNUMERO = @ENDNUMERO, FOR_CIDADE = @CIDADE, FOR_ESTADO = @ESTADO WHERE FOR_COD = @CODIGO";
            cmd.Parameters.AddWithValue("@CODIGO", modelo.ForCod);
            cmd.Parameters.AddWithValue("@NOME", modelo.ForNome);
            cmd.Parameters.AddWithValue("@CPFCNPJ", modelo.ForCnpj);
            cmd.Parameters.AddWithValue("@RGIE", modelo.ForIe);
            cmd.Parameters.AddWithValue("@RSOCIAL", modelo.ForRSocial);
            cmd.Parameters.AddWithValue("@CEP", modelo.ForCep);
            cmd.Parameters.AddWithValue("@ENDERECO", modelo.ForEndereco);
            cmd.Parameters.AddWithValue("@BAIRRO", modelo.ForBairro);
            cmd.Parameters.AddWithValue("@FONE", modelo.ForFone);
            cmd.Parameters.AddWithValue("@CEL", modelo.ForCel);
            cmd.Parameters.AddWithValue("@EMAIL", modelo.ForEmail);
            cmd.Parameters.AddWithValue("@ENDNUMERO", modelo.ForEndNum);
            cmd.Parameters.AddWithValue("@CIDADE", modelo.ForCidade);
            cmd.Parameters.AddWithValue("@ESTADO", modelo.ForEstado);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }

        public void Excluir(int codigo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "DELETE FROM FORENTE WHERE FOR_COD = @CODIGO";
            cmd.Parameters.AddWithValue("@CODIGO", codigo);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }

        public DataTable Localizar(string valor)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM FORNECEDOR WHERE FOR_NOME LIKE '%" + valor + "%'", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        public DataTable LocalizarPorNome(string valor)
        {
            return Localizar(valor);
        }

        public DataTable LocalizarPorCNPJ(string valor)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM FORNECEDOR WHERE FOR_CPFCNPJ LIKE '%" + valor + "%'", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        public ModeloFornecedor CarregaModeloFornecedor(int codigo)
        {
            ModeloFornecedor modelo = new ModeloFornecedor();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "SELECT * FROM FORNECEDOR WHERE FOR_COD = @CODIGO";
            cmd.Parameters.AddWithValue("@CODIGO", codigo);
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                modelo.ForCod = Convert.ToInt32(registro["FOR_COD"]);
                modelo.ForNome = Convert.ToString(registro["FOR_NOME"]);
                modelo.ForCnpj = Convert.ToString(registro["FOR_CPFCNPJ"]); ;
                modelo.ForIe = Convert.ToString(registro["FOR_RGIE"]); ;
                modelo.ForRSocial = Convert.ToString(registro["FOR_RSOCIAL"]); ;
                modelo.ForCep = Convert.ToString(registro["FOR_CEP"]);
                modelo.ForEndereco = Convert.ToString(registro["FOR_ENDERECO"]);
                modelo.ForBairro = Convert.ToString(registro["FOR_BAIRRO"]);
                modelo.ForFone = Convert.ToString(registro["FOR_FONE"]);
                modelo.ForCel = Convert.ToString(registro["FOR_CEL"]);
                modelo.ForEmail = Convert.ToString(registro["FOR_EMAIL"]);
                modelo.ForEndNum = Convert.ToString(registro["FOR_ENDNUMERO"]);
                modelo.ForCidade = Convert.ToString(registro["FOR_CIDADE"]);
                modelo.ForEstado = Convert.ToString(registro["FOR_ESTADO"]);
            }

            conexao.Desconectar();
            return modelo;
        }

        public ModeloFornecedor CarregaModeloFornecedor(string cnpj)
        {
            ModeloFornecedor modelo = new ModeloFornecedor();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "SELECT * FROM FORNECEDOR WHERE FOR_CNPJ = @CNPJ";
            cmd.Parameters.AddWithValue("@CNPJ", cnpj);
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                modelo.ForCod = Convert.ToInt32(registro["FOR_COD"]);
                modelo.ForNome = Convert.ToString(registro["FOR_NOME"]);
                modelo.ForCnpj = Convert.ToString(registro["FOR_CNPJ"]); ;
                modelo.ForIe = Convert.ToString(registro["FOR_IE"]); ;
                modelo.ForRSocial = Convert.ToString(registro["FOR_RSOCIAL"]); ;
                modelo.ForCep = Convert.ToString(registro["FOR_CEP"]);
                modelo.ForEndereco = Convert.ToString(registro["FOR_ENDERECO"]);
                modelo.ForBairro = Convert.ToString(registro["FOR_BAIRRO"]);
                modelo.ForFone = Convert.ToString(registro["FOR_FONE"]);
                modelo.ForCel = Convert.ToString(registro["FOR_CEL"]);
                modelo.ForEmail = Convert.ToString(registro["FOR_EMAIL"]);
                modelo.ForEndNum = Convert.ToString(registro["FOR_ENDNUMERO"]);
                modelo.ForCidade = Convert.ToString(registro["FOR_CIDADE"]);
                modelo.ForEstado = Convert.ToString(registro["FOR_ESTADO"]);
            }

            conexao.Desconectar();
            return modelo;
        }

    }
}
