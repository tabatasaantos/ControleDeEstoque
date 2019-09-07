using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ModeloProduto
    {
        public ModeloProduto()
        {
            this.ProCod = 0;
            this.ProNome = "";
            this.ProDescricao = "";
            //this.ProFoto = "";
            this.ProValorPago = 0;
            this.ProValorVenda = 0;
            this.ProQtde = 0;
            this.UmedCod = 0;
            this.CatCod = 0;
            this.ScatCod = 0;
        }

        public ModeloProduto(int pro_cod, string pro_nome, string pro_descricao, string pro_foto, double pro_valorpago, double pro_valorvenda,
                             float pro_qtde, int umed_cod, int cat_cod, int scat_cod)
        {
            this.ProCod = pro_cod;
            this.ProNome = pro_nome;
            this.ProDescricao = pro_descricao;
           // this.pro_foto = pro_foto;
            this.ProValorPago = pro_valorpago;
            this.ProValorVenda = pro_valorvenda;
            this.ProQtde = pro_qtde;
            this.UmedCod = umed_cod;
            this.CatCod = cat_cod;
            this.ScatCod = scat_cod;
        }

        private int _pro_cod;

        public int ProCod
        {
            get
            {
                return this._pro_cod;
            }

            set
            {
                this._pro_cod = value;
            }
        }

        private string _pro_nome;

        public string ProNome
        {
            get
            {
                return this._pro_nome;
            }

            set
            {
                this._pro_nome = value;
            }
        }

        private string _pro_descricao;

        public string ProDescricao
        {
            get
            {
                return this._pro_descricao;
            }

            set
            {
                this._pro_descricao = value;
            }
        }

        private string _pro_foto;

        public string ProFoto
        {
            get
            {
                return this._pro_foto;
            }

            set
            {
                this._pro_foto = value;
            }
        }

        private double _pro_valorpago;

        public double ProValorPago
        {
            get
            {
                return this._pro_valorpago;
            }

            set
            {
                this._pro_valorpago = value;
            }
        }

        private double _pro_valorvenda;

        public double ProValorVenda
        {
            get
            {
                return this._pro_valorvenda;
            }

            set
            {
                this._pro_valorvenda = value;
            }
        }

        private float _pro_qtde;

        public float ProQtde
        {
            get
            {
                return this._pro_qtde;
            }

            set
            {
                this._pro_qtde = value;
            }
        }

        private int _umed_cod;

        public int UmedCod
        {
            get
            {
                return this._umed_cod;
            }

            set
            {
                this._umed_cod = value;
            }
        }
        private int _cat_cod;

        public int CatCod
        {
            get
            {
                return this._cat_cod;
            }

            set
            {
                this._cat_cod = value;
            }
        }

        private int _scat_cod;

        public int ScatCod
        {
            get
            {
                return this._scat_cod;
            }

            set
            {
                this._scat_cod = value;
            }
        }

    }

}
