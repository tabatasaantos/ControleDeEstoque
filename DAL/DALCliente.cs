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
    public class DALCliente
    {
        private DALConexao conexao;

        public DALCliente(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloCliente modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "INSERT CLIENTE(CLI_NOME, CLI_CPFCNPJ, CLI_RGIE, CLI_RSOCIAL, CLI_TIPO," +
                "CLI_CEP, CLI_ENDERECO, CLI_BAIRRO, CLI_FONE, CLI_CEL, CLI_EMAIL, CLI_ENDNUMERO," +
                "CLI_CIDADE, CLI_ESTADO) VALUES (@NOME, @CPFCNPJ, @RGIE, @RSOCIAL, @TIPO, @CEP, @ENDERECO, @BAIRRO, @FONE, @CEL, @EMAIL, @ENDNUMERO," +
                "@CIDADE, @ESTADO); SELECT @@IDENTITY;";
            cmd.Parameters.AddWithValue("@NOME", modelo.CliNome);
            cmd.Parameters.AddWithValue("@CPFCNPJ", modelo.CliCpfCnpj);
            cmd.Parameters.AddWithValue("@RGIE", modelo.CliRgIe);
            cmd.Parameters.AddWithValue("@RSOCIAL", modelo.CliRSocial);
            cmd.Parameters.AddWithValue("@TIPO", modelo.CliTipo);
            cmd.Parameters.AddWithValue("@CEP", modelo.CliCep);
            cmd.Parameters.AddWithValue("@ENDERECO", modelo.CliEndereco);
            cmd.Parameters.AddWithValue("@CIDADE", modelo.CliCidade);
            cmd.Parameters.AddWithValue("@ESTADO", modelo.CliEstado);
            cmd.Parameters.AddWithValue("@BAIRRO", modelo.CliBairro);
            cmd.Parameters.AddWithValue("@FONE", modelo.CliFone);
            cmd.Parameters.AddWithValue("@CEL", modelo.CliCel);
            cmd.Parameters.AddWithValue("@EMAIL", modelo.CliEmail);
            cmd.Parameters.AddWithValue("@ENDNUMERO", modelo.CliEndNum);

            conexao.Conectar();
            modelo.CliCod = Convert.ToInt32(cmd.ExecuteScalar());
            conexao.Desconectar();
        }

        public void Alterar(ModeloCliente modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "UPDATE CLIENTE SET CLI_NOME = @NOME, CLI_CPFCNPJ = @CPFCNPJ, CLI_RGIE = @RGIE, CLI_RSOCIAL = @RSOCIAL, CLI_TIPO = @TIPO," +
                "CLI_CEP = @CEP, CLI_ENDERECO = @ENDERECO, CLI_BAIRRO = @BAIRRO, CLI_FONE = @FONE, CLI_CEL = @CEL, CLI_EMAIL = @EMAIL," +
                "CLI_ENDNUMERO = @ENDNUMERO, CLI_CIDADE = @CIDADE, CLI_ESTADO = @ESTADO WHERE CLI_COD = @CODIGO";
            cmd.Parameters.AddWithValue("@CODIGO", modelo.CliCod);
            cmd.Parameters.AddWithValue("@NOME", modelo.CliNome);
            cmd.Parameters.AddWithValue("@TIPO", modelo.CliTipo);
            cmd.Parameters.AddWithValue("@CPFCNPJ", modelo.CliCpfCnpj);
            cmd.Parameters.AddWithValue("@RGIE", modelo.CliRgIe);
            cmd.Parameters.AddWithValue("@RSOCIAL", modelo.CliRSocial);
            cmd.Parameters.AddWithValue("@CEP", modelo.CliCep);
            cmd.Parameters.AddWithValue("@ENDERECO", modelo.CliEndereco);
            cmd.Parameters.AddWithValue("@BAIRRO", modelo.CliBairro);
            cmd.Parameters.AddWithValue("@FONE", modelo.CliFone);
            cmd.Parameters.AddWithValue("@CEL", modelo.CliCel);
            cmd.Parameters.AddWithValue("@EMAIL", modelo.CliEmail);
            cmd.Parameters.AddWithValue("@ENDNUMERO", modelo.CliEndNum);
            cmd.Parameters.AddWithValue("@CIDADE", modelo.CliCidade);
            cmd.Parameters.AddWithValue("@ESTADO", modelo.CliEstado);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }

        public void Excluir(int codigo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "DELETE FROM CLIENTE WHERE CLI_COD = @CODIGO";
            cmd.Parameters.AddWithValue("@CODIGO", codigo);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }

        public DataTable Localizar(string valor)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM CLIENTE WHERE CLI_NOME LIKE '%" + valor + "%'", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        public DataTable LocalizarPorNome(string valor)
        {   
            return Localizar(valor);
        }

        public DataTable LocalizarPorCPFCNPJ(string valor)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM CLIENTE WHERE CLI_CPFCNPJ LIKE '%" + valor + "%'", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        public ModeloCliente CarregaModeloCliente(int codigo)
        {
            ModeloCliente modelo = new ModeloCliente();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "SELECT * FROM CLIENTE WHERE CLI_COD = @CODIGO";
            cmd.Parameters.AddWithValue("@CODIGO", codigo);
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                modelo.CliCod = Convert.ToInt32(registro["CLI_COD"]);
                modelo.CliNome = Convert.ToString(registro["CLI_NOME"]);
                modelo.CliCpfCnpj = Convert.ToString(registro["CLI_CPFCNPJ"]); ;
                modelo.CliRgIe = Convert.ToString(registro["CLI_RGIE"]); ;
                modelo.CliRSocial = Convert.ToString(registro["CLI_RSOCIAL"]); ;
                modelo.CliTipo = Convert.ToString(registro["CLI_TIPO"]); ;
                modelo.CliCep = Convert.ToString(registro["CLI_CEP"]);
                modelo.CliEndereco = Convert.ToString(registro["CLI_ENDERECO"]);
                modelo.CliBairro = Convert.ToString(registro["CLI_BAIRRO"]);
                modelo.CliFone = Convert.ToString(registro["CLI_FONE"]);
                modelo.CliCel = Convert.ToString(registro["CLI_CEL"]);
                modelo.CliEmail = Convert.ToString(registro["CLI_EMAIL"]);
                modelo.CliEndNum = Convert.ToString(registro["CLI_ENDNUMERO"]);
                modelo.CliCidade = Convert.ToString(registro["CLI_CIDADE"]);
                modelo.CliEstado = Convert.ToString(registro["CLI_ESTADO"]);
            }

            conexao.Desconectar();
            return modelo;
        }

        public ModeloCliente CarregaModeloCliente(string cpfcnpj)
        {
            ModeloCliente modelo = new ModeloCliente();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "SELECT * FROM CLIENTE WHERE CLI_CPFCNPJ = @CPFCNPJ";
            cmd.Parameters.AddWithValue("@CPFCNPJ", cpfcnpj);
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                modelo.CliCod = Convert.ToInt32(registro["CLI_COD"]);
                modelo.CliNome = Convert.ToString(registro["CLI_NOME"]);
                modelo.CliCpfCnpj = Convert.ToString(registro["CLI_CPFCNPJ"]); ;
                modelo.CliRgIe = Convert.ToString(registro["CLI_RGIE"]); ;
                modelo.CliRSocial = Convert.ToString(registro["CLI_RSOCIAL"]); ;
                modelo.CliTipo = Convert.ToString(registro["CLI_TIPO"]); ;
                modelo.CliCep = Convert.ToString(registro["CLI_CEP"]);
                modelo.CliEndereco = Convert.ToString(registro["CLI_ENDERECO"]);
                modelo.CliBairro = Convert.ToString(registro["CLI_BAIRRO"]);
                modelo.CliFone = Convert.ToString(registro["CLI_FONE"]);
                modelo.CliCel = Convert.ToString(registro["CLI_CEL"]);
                modelo.CliEmail = Convert.ToString(registro["CLI_EMAIL"]);
                modelo.CliEndNum = Convert.ToString(registro["CLI_ENDNUMERO"]);
                modelo.CliCidade = Convert.ToString(registro["CLI_CIDADE"]);
                modelo.CliEstado = Convert.ToString(registro["CLI_ESTADO"]);
            }

            conexao.Desconectar();
            return modelo;
        }
        
    }  
}   

