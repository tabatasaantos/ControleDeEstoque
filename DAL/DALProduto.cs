﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;

namespace DAL
{
    public class DALProduto
    {
        private DALConexao conexao;

        public DALProduto(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloProduto obj)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "INSERT PRODUTO(PRO_NOME, PRO_DESCRICAO, PRO_FOTO, PRO_VALORPAGO, PRO_VALORVENDA, PRO_QTDE, UMED_COD, " +
                "CAT_COD, SCAT_COD) VALUES (@NOME, @DESCRICAO, @FOTO, @VALORPAGO, @VALORVENDA, " +
                "@QTDE, @UMEDCOD, @CATCOD, @SCATCOD); SELECT @@IDENTITY;";
            cmd.Parameters.AddWithValue("@NOME", obj.ProNome);
            cmd.Parameters.AddWithValue("@DESCRICAO", obj.ProDescricao);
            cmd.Parameters.AddWithValue("@FOTO", System.Data.SqlDbType.Image);

            if (obj.ProFoto == null)
            {
                cmd.Parameters["@FOTO"].Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters["@FOTO"].Value = obj.ProFoto;
            }

            cmd.Parameters.AddWithValue("@VALORPAGO", obj.ProValorPago);
            cmd.Parameters.AddWithValue("@VALORVENDA", obj.ProValorVenda);
            cmd.Parameters.AddWithValue("@QTDE", obj.ProQtde);
            cmd.Parameters.AddWithValue("@UMEDCOD", obj.UmedCod);
            cmd.Parameters.AddWithValue("@CATCOD", obj.CatCod);
            cmd.Parameters.AddWithValue("@SCATCOD", obj.ScatCod);

            conexao.Conectar();
            obj.ProCod = Convert.ToInt32(cmd.ExecuteScalar());
            conexao.Desconectar();
        }

        public void Excluir(int codigo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "DELETE FROM PRODUTO WHERE PRO_COD = @CODIGO";
            cmd.Parameters.AddWithValue("@CODIGO", codigo);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }

        public void Alterar(ModeloProduto obj)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "UPDATE PRODUTO SET PRO_NOME = @NOME, PRO_DESCRICAO = @DESCRICAO," +
                "PRO_FOTO = @FOTO, PRO_VALORPAGO = @VALORPAGO, PRO_VALORVENDA = @VALORVENDA, PRO_QTDE = @QTDE," +
                "UMED_COD = @UMEDCOD, CAT_COD = @CATCOD, SCAT_COD = @SCATCOD WHERE PRO_COD = @CODIGO";
            cmd.Parameters.AddWithValue("@NOME", obj.ProNome);
            cmd.Parameters.AddWithValue("@DESCRICAO", obj.ProDescricao);
            cmd.Parameters.AddWithValue("@FOTO", System.Data.SqlDbType.Image);

            if (obj.ProFoto == null)
            {
                cmd.Parameters["@FOTO"].Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters["@FOTO"].Value = obj.ProFoto;
            }

            cmd.Parameters.AddWithValue("@VALORPAGO", obj.ProValorPago);
            cmd.Parameters.AddWithValue("@VALORVENDA", obj.ProValorVenda);
            cmd.Parameters.AddWithValue("@QTDE", obj.ProQtde);
            cmd.Parameters.AddWithValue("@UMEDCOD", obj.UmedCod);
            cmd.Parameters.AddWithValue("@CATCOD", obj.CatCod);
            cmd.Parameters.AddWithValue("@SCATCOD", obj.ScatCod);
            cmd.Parameters.AddWithValue("@CODIGO", obj.ProCod);

            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }

        public DataTable Localizar(string valor)
        {
            DataTable tabela = new DataTable(); 
            SqlDataAdapter da = new SqlDataAdapter("SELECT P.PRO_COD, P.PRO_NOME, P.PRO_DESCRICAO, P.PRO_FOTO, P.PRO_VALORPAGO, " +
                "P.PRO_VALORVENDA, P.PRO_QTDE, P.UMED_COD, P.CAT_COD, P.SCAT_COD, U.UMED_NOME, C.CAT_NOME, SC.SCAT_NOME FROM PRODUTO P INNER JOIN " +
                "UNDMEDIDA U ON P.UMED_COD = U.UMED_COD INNER JOIN CATEGORIA C ON P.CAT_COD = C.CAT_COD INNER JOIN SUBCATEGORIA " +
                "SC ON P.SCAT_COD = SC.SCAT_COD WHERE P.PRO_NOME LIKE '%" + valor + "%'", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        public ModeloProduto CarregaModeloProduto(int codigo)
        {
            ModeloProduto modelo = new ModeloProduto();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "SELECT * FROM PRODUTO WHERE PRO_COD =" + codigo.ToString();
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                modelo.ProCod = Convert.ToInt32(registro["PRO_COD"]);
                modelo.ProNome = Convert.ToString(registro["PRO_NOME"]);
                modelo.ProDescricao = Convert.ToString(registro["PRO_DESCRICAO"]);

                try
                {
                    modelo.ProFoto = (byte[])registro["PRO_FOTO"];
                }

                catch { }

                modelo.ProValorPago = Convert.ToDouble(registro["PRO_VALORPAGO"]);
                modelo.ProValorVenda = Convert.ToDouble(registro["PRO_VALORVENDA"]);
                modelo.ProQtde = Convert.ToInt32(registro["PRO_QTDE"]);
                modelo.UmedCod = Convert.ToInt32(registro["UMED_COD"]);
                modelo.CatCod = Convert.ToInt32(registro["CAT_COD"]);
                modelo.ScatCod = Convert.ToInt32(registro["SCAT_COD"]);
            }

            conexao.Desconectar();
            return modelo;
        }
    }
         
}

        
    
