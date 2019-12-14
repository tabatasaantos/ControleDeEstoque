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
    public class DALCompra
    {
        private DALConexao conexao;

        public DALCompra(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloCompra modelo)
        {
            SqlCommand cmd = new SqlCommand(); 
            cmd.Connection = conexao.ObjetoConexao; 
            cmd.CommandText = "INSERT COMPRA(COM_DATA, COM_NFISCAL, COM_TOTAL, COM_NPARCELAS, COM_STATUS, FOR_COD, TPA_COD) VALUES " +
                "(@DATA, @NFISCAL, @TOTAL, @NPARCELAS, @STATUS, @FORCOD, @TPACOD); SELECT @@IDENTITY;)";
            //quando o valor for uma data
            cmd.Parameters.AddWithValue("@DATA", System.Data.SqlDbType.DateTime);
            cmd.Parameters["@DATA"].Value = modelo.ComData;
            //para dados primitivos
            cmd.Parameters.AddWithValue("@NFISCAL", modelo.ComNFiscal);
            cmd.Parameters.AddWithValue("@TOTAL", modelo.ComTotal);
            cmd.Parameters.AddWithValue("@NPARCELAS", modelo.ComNParcelas);
            cmd.Parameters.AddWithValue("@STATUS", modelo.ComStatus);
            cmd.Parameters.AddWithValue("@FORCOD", modelo.ForCod);
            cmd.Parameters.AddWithValue("@TPACOD", modelo.TpaCod);
            conexao.Conectar();
            modelo.ComCod = Convert.ToInt32(cmd.ExecuteScalar()); 
            conexao.Desconectar();
        }

        public void Alterar(ModeloCompra modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "UPDATE COMPRA SET COM_DATA=@DATA, COM_NFISCAL=@NFISCAL, COM_TOTAL=@TOTAL, COM_NPARCELAS=@NPARCELAS, COM_STATUS=@STATUS," +
                " FOR_COD=@FORCOD, TPA_COD=@TPACOD WHERE COM_COD = @CODIGO;";
            cmd.Parameters.AddWithValue("@CODIGO", modelo.ComCod);
            cmd.Parameters.AddWithValue("@COM_DATA", System.Data.SqlDbType.DateTime);
            cmd.Parameters["@COM_DATA"].Value = modelo.ComData;
            cmd.Parameters.AddWithValue("@NFISCAL", modelo.ComNFiscal);
            cmd.Parameters.AddWithValue("@TOTAL", modelo.ComTotal);
            cmd.Parameters.AddWithValue("@NPARCELAS", modelo.ComNParcelas);
            cmd.Parameters.AddWithValue("@STATUS", modelo.ComStatus);
            cmd.Parameters.AddWithValue("@FORCOD", modelo.ForCod);
            cmd.Parameters.AddWithValue("@TPACOD", modelo.TpaCod);
            conexao.Conectar();
            modelo.ComCod = Convert.ToInt32(cmd.ExecuteScalar());
            conexao.Desconectar();
        }

        public void Excluir(int codigo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "DELETE FROM COMPRA WHERE COM_COD = @CODIGO";
            cmd.Parameters.AddWithValue("@CODIGO", codigo);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }

        //localizar pelo cod do fornecedor
        public DataTable Localizar(int codigo)
        {
            DataTable tabela = new DataTable();
            //SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM COMPRA WHERE FOR_COD = " + codigo.ToString(), conexao.StringConexao);
            SqlDataAdapter da = new SqlDataAdapter("SELECT C.COM_COD, C.COM_DATA, C.COM_NFISCAL, C.COM_NPARCELAS, C.COM_TOTAL, C.COM_STATUS, C.FOR_COD," +
               "C.TPA_COD, F.FOR_NOME FROM COMPRA C INNER JOIN FORNECEDOR F ON C.FOR_COD = F.FOR_COD" +
               "WHERE FOR_COD = " + codigo.ToString(), conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        //localizar por nome do forncedor 
        public DataTable Localizar(string nome)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT C.COM_COD, C.COM_DATA, C.COM_NFISCAL, C.COM_NPARCELAS, C.COM_TOTAL, C.COM_STATUS, C.FOR_COD," +
                "C.TPA_COD, F.FOR_NOME FROM COMPRA C INNER JOIN FORNECEDOR F ON C.FOR_COD = F.FOR_COD" +
                "WHERE F.FOR_NOME = '%" + nome + "%'", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        //localizar por data
        public DataTable Localizar(DateTime dtinicial, DateTime dtfinal)
        {
            DataTable tabela = new DataTable();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "SELECT C.COM_COD, C.COM_DATA, C.COM_NFISCAL, C.COM_NPARCELAS, C.COM_TOTAL, C.COM_STATUS, C.FOR_COD," +
                "C.TPA_COD, F.FOR_NOME FROM COMPRA C INNER JOIN FORNECEDOR F ON C.FOR_COD = F.FOR_COD" +
                "WHERE C.COM_DATA BETWEEN @DTINICIAL AND @DTFINAL";
            cmd.Parameters.AddWithValue("@DTINICIAL", System.Data.SqlDbType.DateTime);
            cmd.Parameters["@DTINICIAL"].Value = dtinicial;
            cmd.Parameters.AddWithValue("@DTFINAL", System.Data.SqlDbType.DateTime);
            cmd.Parameters["@DTFINAL"].Value = dtfinal;
            //conexao.Conectar();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(tabela);
            //conexao.Desconectar();
            return tabela;
        }

        public ModeloCompra CarregaModeloCompra(int codigo) 
        {
            ModeloCompra modelo = new ModeloCompra(); 
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "SELECT * FROM COMPRA WHERE COM_COD = @CODIGO";
            cmd.Parameters.AddWithValue("@CODIGO", codigo);
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader(); 
            if (registro.HasRows) 
            {
                registro.Read();
                modelo.ComCod = Convert.ToInt32(registro["COM_COD"]);
                modelo.ComData = Convert.ToDateTime(registro["COM_DATA"]);
                modelo.ComNFiscal = Convert.ToInt32(registro["COM_NFISCAL"]);
                modelo.ComTotal = Convert.ToInt32(registro["COM_TOTAL"]);
                modelo.ComNParcelas = Convert.ToInt32(registro["COM_NPARCELAS"]);
                modelo.ComStatus = Convert.ToString(registro["COM_STATUS"]);
                modelo.ForCod = Convert.ToInt32(registro["FOR_COD"]);
                modelo.TpaCod = Convert.ToInt32(registro["TPA_COD"]);
            }

            conexao.Desconectar();
            return modelo;
        }
    }
}
