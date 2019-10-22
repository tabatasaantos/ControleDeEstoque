using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferramentas
{
    public class BuscaEndereco
    {
        static public String cep = "";
        static public String cidade = "";
        static public String estado = "";
        static public String endereco = "";
        static public String bairro = "";

        public static Boolean verificaCEP(String CEP)
        {
            bool flag = false;
            try
            {
                DataSet ds = new DataSet(); //criando um dataset para fazer a leitura do que tem no xml.
                string xml = "http://cep.republicavirtual.com.br/web_cep.php?cep=@cep&formato=xml".Replace("@cep", CEP); //acessando o webservice, passando o cep e armazenando o retorno dele num arquivo texto (xml)
                ds.ReadXml(xml);//acessando os dados
                endereco = ds.Tables[0].Rows[0]["logradouro"].ToString(); //devolvendo uma tabela e armazenando nos dados estáticos
                bairro = ds.Tables[0].Rows[0]["bairro"].ToString();
                cidade = ds.Tables[0].Rows[0]["cidade"].ToString();
                estado = ds.Tables[0].Rows[0]["uf"].ToString();
                cep = CEP;
                flag = true;
            }
            // se não houver nenhum retorno, retorna as variavéis estáticas vazias
            catch (Exception ex)
            {
                endereco = "";
                bairro = "";
                cidade = "";
                estado = "";
                cep = "";
            }
            return flag; //o retorno dentro do flag, se entrar no try será verdadeiro, se não, será falso
        }
    }
}
