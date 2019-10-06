using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ModeloCliente
    {
        //construtores da classe
        public ModeloCliente()
        {
            this.CliCod = 0;
            this.CliNome = "";
            this.CliCpfCnpj = "";
            this.CliRgIe = "";
            this.CliRSocial = "";
            this.CliTipo = 0;
            this.CliCep = "";
            this.CliEndereco = "";
            this.CliBairro = "";
            this.CliFone = "";
            this.CliCel = "";
            this.CliEmail = "";
            this.CliEndNum = "";
            this.CliCidade = "";
            this.CliEstado = "";
        }

        public ModeloCliente(int cod, string nome, string cpfcnpj, string rgie, string rsocial, int tipo, string cep, string end, string bairro, 
            string fone, string cel, string email, string endnum, string cidade, string estado)
        {
            this.CliCod = cod;
            this.CliNome = nome;
            this.CliCpfCnpj = cpfcnpj;
            this.CliRgIe = rgie;
            this.CliRSocial = rsocial;
            this.CliTipo = tipo;
            this.CliCep = cep;
            this.CliEndereco = end;
            this.CliBairro = bairro;
            this.CliFone = fone;
            this.CliCel = cel;
            this.CliEmail = email;
            this.CliEndNum = endnum;
            this.CliCidade = cidade;
            this.CliEstado = estado;
        }
        //propriedades da classe
        private int cli_cod;

        public int CliCod
        {
            get { return this.cli_cod; }
            set { this.cli_cod = value; }
        }

        private string cli_nome;

        public string CliNome
        {
            get { return this.cli_nome; }
            set { this.cli_nome = value; }
        }

        private string cli_cpfcnpj;

        public string CliCpfCnpj
        {
            get { return this.cli_cpfcnpj; }
            set { this.cli_cpfcnpj = value; }
        }

        private string cli_rgie;

        public string CliRgIe
        {
            get { return this.cli_rgie; }
            set { this.cli_rgie = value; }
        }

        private string cli_rsocial;

        public string CliRSocial
        {
            get { return this.cli_rsocial; }
            set { this.cli_rsocial = value; }
        }

        private int cli_tipo;

        public int CliTipo
        {
            get { return this.cli_tipo; }
            set { this.cli_tipo = value; }
        }

        private string cli_cep;

        public string CliCep
        {
            get { return this.cli_cep; }
            set { this.cli_cep = value; }
        }

        private string cli_endereco;

        public string CliEndereco
        {
            get { return this.cli_endereco; }
            set { this.cli_endereco = value; }
        }

        private string cli_bairro;

        public string CliBairro
        {
            get { return this.cli_bairro; }
            set { this.cli_bairro = value; }
        }

        private string cli_fone;

        public string CliFone
        {
            get { return this.cli_fone; }
            set { this.cli_fone = value; }
        }

        private string cli_cel;

        public string CliCel
        {
            get { return this.cli_cel; }
            set { this.cli_cel = value; }
        }

        private string cli_email;

        public string CliEmail
        {
            get { return this.cli_email; }
            set { this.cli_email = value; }
        }

        private string cli_endnum;

        public string CliEndNum
        {
            get { return this.cli_endnum; }
            set { this.cli_endnum = value; }
        }

        private string cli_cidade;

        public string CliCidade
        {
            get { return this.cli_cidade; }
            set { this.cli_cidade = value; }
        }

        private string cli_estado;

        public string CliEstado
        {
            get { return this.cli_estado; }
            set { this.cli_estado = value; }
        }
    }
    

}
