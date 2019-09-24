using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
   public class ModeloSubCategoria
    {
        public ModeloSubCategoria() //criando construtor sem parâmetro
        {
            this.CatCod = 0; //não tem valor porque o construtor está sem parâmetro
            this.ScatCod = 0; 
            this.SCatNome = "";
        }

        public ModeloSubCategoria(int scatcod, int catcod, string snome) //criando construtor com parâmetro
        {
            this.CatCod = catcod; //passando o que está na propriedade para as variáveis
            this.ScatCod = scatcod;
            this.SCatNome = snome;
        }

        private int scat_cod; //criando variável
        public int ScatCod //criando propriedade
        {
            get { return this.scat_cod; } //se for pegar retorna o valor da scat_cod
            set { this.scat_cod = value; } //se for passar, passa o valor do parâmetro
        }

        private int cat_cod; //se for pegar retorna o valor da cat_cod
        public int CatCod //se for passar, passa o valor do parâmetro
        {
            get { return this.cat_cod; } //se for pegar retorna o valor da cat_cod
            set { this.cat_cod = value; } //se for passar, passa o valor do parâmetro
        }

        private string scat_nome; //criando variável
        public string SCatNome //criando propriedade
        {
            get { return this.scat_nome; } //se for pegar retorna o valor da scat_nome
            set { this.scat_nome = value; }  //se for passar, passa o valor do parâmetro
        }
    }
}
