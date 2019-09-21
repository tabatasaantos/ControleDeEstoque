using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALConexao
    {
        private string stringConexao;
        private SqlConnection conexao;

        public DALConexao(string dadosConexao) // construtor com parâmetro do tipo string.
        {
            this.conexao = new SqlConnection(); //pegando a variável conexão e passando uma nova instância do seu tipo que é da classe SQLConnection.
            this.stringConexao = dadosConexao; //pegando a variável stringConexao e passando o parâmetro
            this.conexao.ConnectionString = dadosConexao; //a variável conexao está obtendo os dados para a conexão com o SQL e pasando para o parâmetro.
        }

        public string StringConexao //criando propriedade do tipo string
        {
            get { return this.stringConexao; } //se for pegar retorna o valor da stringConexao
            set { this.stringConexao = value; } //se for passar para a stringConexão o parâmetro
        }

        public SqlConnection ObjetoConexao //criando propriedade do tipo Sql
        {
            get { return this.conexao; } //se for pegar retorna o valor da conexão
            set { this.conexao = value; } //se for passar, passa o valor do parâmetro
        }

        public void Conectar() //método para conectar
        {
            this.conexao.Open();
        }

        public void Desconectar() //método para desconectar
        {
            this.conexao.Close();
        }
    }

    
}
