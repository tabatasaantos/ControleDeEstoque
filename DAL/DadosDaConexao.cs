using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DadosDaConexao
    {
        public static string StringDeConexao
        {
            get
            {
                return "Data Source=TABATA-PC\\SQLEXPRESS;Initial Catalog=DB_CONTROLE_ESTOQUE;User ID=sa;Password=barne";
            }
        }
    }
}
