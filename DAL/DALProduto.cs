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
    public class DALProduto
    {
        private DALConexao conexao; //criando atributo do tipo DAL

        public DALProduto(DALConexao cx) //criando um construtor do tipo DAL
        {
            this.conexao = cx; //atribuindo o atributo para a variável
        }

        public void Incluir(ModeloProduto obj) //método do tipo Modelo
        {
            SqlCommand cmd = new SqlCommand(); //inicializando uma nova instância da classe sql
            cmd.Connection = conexao.ObjetoConexao; //passando para a variável local e propriedade do Sql a variável conexão com a proprieda Objeto
            cmd.CommandText = "INSERT PRODUTO(PRO_NOME, PRO_DESCRICAO, PRO_FOTO, PRO_VALORPAGO, PRO_VALORVENDA, PRO_QTDE, UMED_COD, " +
                "CAT_COD, SCAT_COD) VALUES (@NOME, @DESCRICAO, @FOTO, @VALORPAGO, @VALORVENDA, " +
                "@QTDE, @UMEDCOD, @CATCOD, @SCATCOD); SELECT @@IDENTITY;"; //passando comeando do BD 
            cmd.Parameters.AddWithValue("@NOME", obj.ProNome); //passando valores dos parâmetros
            cmd.Parameters.AddWithValue("@DESCRICAO", obj.ProDescricao);
            cmd.Parameters.AddWithValue("@FOTO", System.Data.SqlDbType.Image); //especificando o tipo que será saldo no BD (no caso, foto)

            if (obj.ProFoto == null) //se o valor no obj fofo for nulo
            {
                cmd.Parameters["@FOTO"].Value = DBNull.Value; //perguntar do DBnull
            }
            else
            {
                cmd.Parameters["@FOTO"].Value = obj.ProFoto; //obtendo valor do parâmetro
            }

            cmd.Parameters.AddWithValue("@VALORPAGO", obj.ProValorPago); //criando valores para os parâmetros
            cmd.Parameters.AddWithValue("@VALORVENDA", obj.ProValorVenda);
            cmd.Parameters.AddWithValue("@QTDE", obj.ProQtde);
            cmd.Parameters.AddWithValue("@UMEDCOD", obj.UmedCod);
            cmd.Parameters.AddWithValue("@CATCOD", obj.CatCod);
            cmd.Parameters.AddWithValue("@SCATCOD", obj.ScatCod);

            conexao.Conectar();
            obj.ProCod = Convert.ToInt32(cmd.ExecuteScalar()); //convertendo o valor do parâmetro ProCod e retornando apenas a primeira linha
            conexao.Desconectar();
        }

        public void Excluir(int codigo) //método do tipo int
        {
            SqlCommand cmd = new SqlCommand(); //inicializando uma nova instância da classe sql
            cmd.Connection = conexao.ObjetoConexao; //passando para a variável local e propriedade do Sql a variável conexão com a proprieda Objeto
            cmd.CommandText = "DELETE FROM PRODUTO WHERE PRO_COD = @CODIGO"; //passando a instrução pela CommandText do sql
            cmd.Parameters.AddWithValue("@CODIGO", codigo);
            conexao.Conectar();
            cmd.ExecuteNonQuery(); //não retorna nenhuma informação
            conexao.Desconectar();
        }

        public void Alterar(ModeloProduto obj) //criando método do tipo modelo
        {
            SqlCommand cmd = new SqlCommand();  //inicializando uma nova instância da classe sql
            cmd.Connection = conexao.ObjetoConexao; //passando para a variável local e propriedade do Sql a variável conexão com a proprieda Objeto
            cmd.CommandText = "UPDATE PRODUTO SET PRO_NOME = @NOME, PRO_DESCRICAO = @DESCRICAO," +
                "PRO_FOTO = @FOTO, PRO_VALORPAGO = @VALORPAGO, PRO_VALORVENDA = @VALORVENDA, PRO_QTDE = @QTDE," +
                "UMED_COD = @UMEDCOD, CAT_COD = @CATCOD, SCAT_COD = @SCATCOD WHERE PRO_COD = @CODIGO"; //passando a instrução pela CommandText do sql
            cmd.Parameters.AddWithValue("@NOME", obj.ProNome);
            cmd.Parameters.AddWithValue("@DESCRICAO", obj.ProDescricao);
            cmd.Parameters.AddWithValue("@FOTO", System.Data.SqlDbType.Image); //especificando o tipo que será saldo no BD (no caso, foto)

            if (obj.ProFoto == null)
            {
                cmd.Parameters["@FOTO"].Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters["@FOTO"].Value = obj.ProFoto; //obtendo valor do parâmetro
            }

            cmd.Parameters.AddWithValue("@VALORPAGO", obj.ProValorPago); //passando valor aos parâmetros
            cmd.Parameters.AddWithValue("@VALORVENDA", obj.ProValorVenda);
            cmd.Parameters.AddWithValue("@QTDE", obj.ProQtde);
            cmd.Parameters.AddWithValue("@UMEDCOD", obj.UmedCod);
            cmd.Parameters.AddWithValue("@CATCOD", obj.CatCod);
            cmd.Parameters.AddWithValue("@SCATCOD", obj.ScatCod);
            cmd.Parameters.AddWithValue("@CODIGO", obj.ProCod);

            conexao.Conectar();
            cmd.ExecuteNonQuery(); //nenhum retorno de informação
            conexao.Desconectar();
        }

        public DataTable Localizar(string valor)
        {
            DataTable tabela = new DataTable(); //inicializa uma nova instância da classe DataTable (uma tabela vázia)
            SqlDataAdapter da = new SqlDataAdapter("SELECT P.PRO_COD, P.PRO_NOME, P.PRO_DESCRICAO, P.PRO_FOTO, P.PRO_VALORPAGO, " +
                "P.PRO_VALORVENDA, P.PRO_QTDE, P.UMED_COD, P.CAT_COD, P.SCAT_COD, U.UMED_NOME, C.CAT_NOME, SC.SCAT_NOME FROM PRODUTO P INNER JOIN " +
                "UNDMEDIDA U ON P.UMED_COD = U.UMED_COD INNER JOIN CATEGORIA C ON P.CAT_COD = C.CAT_COD INNER JOIN SUBCATEGORIA " +
                "SC ON P.SCAT_COD = SC.SCAT_COD WHERE P.PRO_NOME LIKE '%" + valor + "%'", conexao.StringConexao);
            da.Fill(tabela); //atualiza/adiciona as linhas dos valores da que estão armazenados na tabela
            return tabela;
        }

        public ModeloProduto CarregaModeloProduto(int codigo) //criando método do tipo modelo e parâmetro do tipo int 
        {
            ModeloProduto modelo = new ModeloProduto(); //iniciando uma nova instância da classe modelo
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "SELECT * FROM PRODUTO WHERE PRO_COD =" + codigo.ToString();
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader(); //passando para a variável registro os dados com mais detalhes da conexão do banco
            if (registro.HasRows) //verificando se há dadoa na variável registro
            {
                registro.Read(); //lendo os dados da váriavel registro
                modelo.ProCod = Convert.ToInt32(registro["PRO_COD"]);
                modelo.ProNome = Convert.ToString(registro["PRO_NOME"]);
                modelo.ProDescricao = Convert.ToString(registro["PRO_DESCRICAO"]);

                try
                {
                    modelo.ProFoto = (byte[])registro["PRO_FOTO"]; //pedir explicação
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

        
    
