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
        private DALConexao conexao; //criando atributo do tipo DALConexão.

        public DALCategoria(DALConexao cx) //construtor com parâmetro do tipo DALConexão 
        {
            this.conexao = cx; //passando valor ao atributo ambos do tipo DALConexão
        }

        public void Incluir(ModeloCategoria modelo) //método que tem um parâmetro do tipo Modelo 
        {
            SqlCommand cmd = new SqlCommand(); //Inicializando uma nova instância da classe sql.
            cmd.Connection = conexao.ObjetoConexao; //passando para a variável local e propriedade do Sql a variável conexão com a proprieda Objeto
            cmd.CommandText = "INSERT CATEGORIA(CAT_NOME) VALUES (@NOME); SELECT @@IDENTITY;"; //passando para o parâmetro do Sql o comando SQL
            cmd.Parameters.AddWithValue("@NOME", modelo.CatNome); //adicionando valores ao parêmetro
            conexao.Conectar(); //conectando 
            modelo.CatCod = Convert.ToInt32(cmd.ExecuteScalar()); //convertendo o valor do parâmetro CatCod e retornando apenas a primeira linha
            conexao.Desconectar(); //desconectando

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
            cmd.ExecuteNonQuery(); //não retorna nenhuma informação 
            conexao.Desconectar();
        }

        public void Excluir(int codigo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "DELETE FROM CATEGORIA WHERE CAT_COD = @CODIGO";
            cmd.Parameters.AddWithValue("@CODIGO", codigo);
            conexao.Conectar();
            cmd.ExecuteNonQuery(); //não retorna nenhuma informação
            conexao.Desconectar();
        }

        public DataTable Localizar(string valor) //criando método do tipo DataTable que retorna os dados do BD
        {
            DataTable tabela = new DataTable(); //inicializa uma nova instância da classe DataTable (uma tabela vázia)
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM CATEGORIA WHERE CAT_NOME LIKE '%" + valor + "%'", conexao.StringConexao); //executa um comando no banco para retornar valores.
            da.Fill(tabela); //atualiza/adiciona as linhas dos valores da que estão armazenados na tabela
            return tabela; //retorna o valor 


        }

        public ModeloCategoria CarregaModeloCategoria(int codigo) //criando método do tipo Modelo com parâmetro
        {
            ModeloCategoria modelo = new ModeloCategoria(); //iniciando uma nova instância pra classe modelo
            SqlCommand cmd = new SqlCommand(); //comando sql
            cmd.Connection = conexao.ObjetoConexao; //passando para a variável local e propriedade do Sql a variável conexão com a proprieda Objeto
            cmd.CommandText = "SELECT * FROM CATEGORIA WHERE CAT_COD = @CODIGO";
            cmd.Parameters.AddWithValue("@CODIGO", codigo);
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader(); //passando para a variável registro os dados com mais detalhes da conexão do banco
            if(registro.HasRows) //verificando se há dados na variável registro
            {
                registro.Read(); //lendo os dados da variável registro
                modelo.CatCod = Convert.ToInt32(registro["CAT_COD"]);
                modelo.CatNome = Convert.ToString(registro["CAT_NOME"]);
            }

            conexao.Desconectar();
            return modelo;
        }
    }
}
