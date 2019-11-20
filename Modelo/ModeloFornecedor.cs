using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ModeloFornecedor
    {
        //construtores da classe
        public ModeloFornecedor()
        {
            this.ForCod = 0;
            this.ForNome = "";
            this.ForCnpj = "";
            this.ForIe = "";
            this.ForRSocial = "";         
            this.ForCep = "";
            this.ForEndereco = "";
            this.ForBairro = "";
            this.ForFone = "";
            this.ForCel = "";
            this.ForEmail = "";
            this.ForEndNum = "";
            this.ForCidade = "";
            this.ForEstado = "";
        }

        public ModeloFornecedor(int cod, string nome, string cnpj, string ie, string rsocial, string tipo, string cep, string end, string bairro,
            string fone, string cel, string email, string endnum, string cidade, string estado)
        {
            this.ForCod = cod;
            this.ForNome = nome;
            this.ForCnpj = cnpj;
            this.ForIe = ie;
            this.ForRSocial = rsocial;
            this.ForCep = cep;
            this.ForEndereco = end;
            this.ForBairro = bairro;
            this.ForFone = fone;
            this.ForCel = cel;
            this.ForEmail = email;
            this.ForEndNum = endnum;
            this.ForCidade = cidade;
            this.ForEstado = estado;
        }
        //propriedades da classe
        private int for_cod;

        public int ForCod
        {
            get { return this.for_cod; }
            set { this.for_cod = value; }
        }

        private string for_nome;

        public string ForNome
        {
            get { return this.for_nome; }
            set { this.for_nome = value; }
        }

        private string for_cnpj;

        public string ForCnpj
        {
            get { return this.for_cnpj; }
            set { this.for_cnpj = value; }
        }

        private string for_ie;

        public string ForIe
        {
            get { return this.for_ie; }
            set { this.for_ie = value; }
        }

        private string for_rsocial;

        public string ForRSocial
        {
            get { return this.for_rsocial; }
            set { this.for_rsocial = value; }
        }

        private string for_cep;

        public string ForCep
        {
            get { return this.for_cep; }
            set { this.for_cep = value; }
        }

        private string for_endereco;

        public string ForEndereco
        {
            get { return this.for_endereco; }
            set { this.for_endereco = value; }
        }

        private string for_bairro;

        public string ForBairro
        {
            get { return this.for_bairro; }
            set { this.for_bairro = value; }
        }

        private string for_fone;

        public string ForFone
        {
            get { return this.for_fone; }
            set { this.for_fone = value; }
        }

        private string for_cel;

        public string ForCel
        {
            get { return this.for_cel; }
            set { this.for_cel = value; }
        }

        private string for_email;

        public string ForEmail
        {
            get { return this.for_email; }
            set { this.for_email = value; }
        }

        private string for_endnum;

        public string ForEndNum
        {
            get { return this.for_endnum; }
            set { this.for_endnum = value; }
        }

        private string for_cidade;

        public string ForCidade
        {
            get { return this.for_cidade; }
            set { this.for_cidade = value; }
        }

        private string for_estado;

        public string ForEstado
        {
            get { return this.for_estado; }
            set { this.for_estado = value; }
        }
    }
}
