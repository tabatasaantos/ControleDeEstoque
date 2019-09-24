using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ModeloUnidadeDeMedida
    {
        public ModeloUnidadeDeMedida() //criando construtor 
        {
            this.UmedCod = 0; //não tem valor porque o construtor está sem parâmetro
            this.UmedNome = ""; 
        }

        public ModeloUnidadeDeMedida(int cod, string nome)
        {
            this.UmedCod = cod; //passando o que está na propriedade para as variáveis
            this.UmedNome = nome;
        }

        private int umed_cod; //criando variável
        public int UmedCod //criando propriedade
        {
            get { return this.umed_cod; } //se for pegar retorna o valor da umed_cod
            set { this.umed_cod = value; } //se for passar, passa o valor do umed_cod           
        }

        private string umed_nome; //criando variável
        public string UmedNome //criando propriedade
        {
            get { return this.umed_nome; } //se for pegar retorna o valor da umed_nome
            set { this.umed_nome = value; } //se for passar, passa o valor do umed_nome

        }
    }
}
