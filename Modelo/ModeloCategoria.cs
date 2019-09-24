using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ModeloCategoria //classe 
    {
        public ModeloCategoria()  //construtor 
        {
            this.CatCod = 0; //não tem valor porque o construtor está sem parâmetro
            this.CatNome = ""; 
        }

        public ModeloCategoria(int catcod, string nome) //construtor passando valores
        {
            this.CatCod = catcod; //passando valor para os atributos dos parâmetros.
            this.CatNome = nome;
        }

        private int cat_cod; //criando variável
        public int CatCod //criando propriedade
        {
            get { return this.cat_cod; }  //se for pegar retorna o valor da cat_cod
            set { this.cat_cod = value; } //se for passar, passa o valor do parâmetro
        }
        private string cat_nome; //criando a variável
        public string CatNome //criando propriedade
        {
            get { return this.cat_nome; } //se for pegar retorna o valor da cat_nome
            set { this.cat_nome = value; } //se for passar, passa o valor do parâmetro
        }
    }
}
