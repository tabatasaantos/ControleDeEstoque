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

        public DALConexao(string dadosConexao)
        {
            this.conexao = new SqlConnection();
            this.stringConexao = dadosConexao;
            this.conexao.ConnectionString = dadosConexao;
        }

        public string StringConexao
        {
            get { return this.stringConexao; }
            set { this.stringConexao = value; }
        }

        public SqlConnection ObjetoConexao
        {
            get { return this.conexao; }
            set { this.conexao = value; }
        }

        public void Conectar()
        {
            this.conexao.Open();
        }

        public void Desconectar()
        {
            this.conexao.Close();
        }
    }

    
}
