using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL 
{
    public class DadosDaConexao //classe para passar os dados de conexão com o BD.
    {
        public static string servidor = @"TABATA - PC\SQLEXPRESS"; //criando atributos estáticos para os dados do banco.
        public static string banco = "DB_CONTROLE_ESTOQUE";
        public static string usuario = "sa";
        public static string senha = "barne";

        public static string StringDeConexao //método que retorna os atributos
        {
            get
            {
                return @"Data Source="+servidor+";Initial Catalog="+banco+";User ID="+usuario+";Password="+senha; //retornando o que contém nos atributos
            }
        }
    }
}
