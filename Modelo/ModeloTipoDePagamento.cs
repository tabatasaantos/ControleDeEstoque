using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ModeloTipoDePagamento
    {
        public ModeloTipoDePagamento()
        {
            this.TpaCod = 0;
            this.TpaNome = "";
        }

        public ModeloTipoDePagamento(int tpacod, string tpanome)
        {
            this.TpaCod = tpacod;
            this.TpaNome = tpanome;
        }

        private int tpa_cod;
        public int TpaCod
        {
            get { return this.tpa_cod; }
            set { this.tpa_cod = value; }
        }

        private string tpa_nome;
        public string TpaNome
        {
            get { return this.tpa_nome; }
            set { this.tpa_nome = value; }
        }
        
    }
}
