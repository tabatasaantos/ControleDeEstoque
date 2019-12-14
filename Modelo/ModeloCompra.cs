using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ModeloCompra
    {
        public ModeloCompra()
        {
            this.ComCod = 0;
            this.ComData = DateTime.Now;
            this.ComNFiscal = 0;
            this.ComTotal = 0;
            this.ComNParcelas = 0;
            this.ComStatus = "Válida!";
            this.ForCod = 0;
            this.TpaCod = 0;
        }


        public ModeloCompra(int comCod, DateTime data, int nFiscal, double total, int nParcelas, string status, int forCod, int tpaCod)
        {
            this.ComCod = comCod;
            this.ComData = data;
            this.ComNFiscal = nFiscal;
            this.ComTotal = total;
            this.ComNParcelas = nParcelas;
            this.ComStatus = status;
            this.ForCod = forCod;
            this.TpaCod = tpaCod;

        }

        private int _com_cod; //criando variável
        public int ComCod //criando propriedade
        {
            get { return this._com_cod; } //se for pegar retorna o valor da _pro_cod
            set { this.ComCod = value; } //se for passar, passa o valor do parâmetro     
        }

        private DateTime _com_data;
        public DateTime ComData
        {
            get { return this._com_data; }
            set { this.ComData = value; }
        }

        private int _com_nfiscal;
        public int ComNFiscal
        {
            get { return this._com_nfiscal; }
            set { this._com_nfiscal = value; }
        }

        private double _com_total;
        public double ComTotal
        {
            get { return this._com_total; }
            set { this._com_total = value; }
        }

        private int _com_nparcelar;
        public int ComNParcelas
        {
            get { return this._com_nparcelar; }
            set { this._com_nparcelar = value; }
        }

        private string _com_status;
        public string ComStatus
        {
            get { return this._com_status; }
            set { this._com_status = value; }
        }

        private int _for_cod;
        public int ForCod
        {
            get { return this._for_cod; }
            set { this._for_cod = value; }
        }

        private int _tpa_cod;
        public int TpaCod
        {
            get { return this._tpa_cod; }
            set { this._tpa_cod = value; }
        }
    }
}
