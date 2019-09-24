using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ModeloProduto
    {
        public ModeloProduto() //criando construtor sem parâmetro
        {
            this.ProCod = 0; //criando as propriedades sem valores
            this.ProNome = "";
            this.ProDescricao = "";
            //null;
            this.ProValorPago = 0;
            this.ProValorVenda = 0;
            this.ProQtde = 0;
            this.UmedCod = 0;
            this.CatCod = 0;
            this.ScatCod = 0;
        }

        public ModeloProduto(int pro_cod, string pro_nome, string pro_descricao, string pro_foto, double pro_valorpago, double pro_valorvenda,
                             double pro_qtde, int umed_cod, int cat_cod, int scat_cod) //módulo com parâmetros
        {
            this.ProCod = pro_cod; //passando o que está nas propriedades para as variáveis, aqui com a foto do tipo string
            this.ProNome = pro_nome;
            this.ProDescricao = pro_descricao;
            this.CarregaImagem(pro_foto);
            this.ProValorPago = pro_valorpago;
            this.ProValorVenda = pro_valorvenda;
            this.ProQtde = pro_qtde;
            this.UmedCod = umed_cod;
            this.CatCod = cat_cod;
            this.ScatCod = scat_cod;
        }
        public ModeloProduto(int pro_cod, string pro_nome, string pro_descricao, byte[] pro_foto, double pro_valorpago, double pro_valorvenda,
                             double pro_qtde, int umed_cod, int cat_cod, int scat_cod)
        {
            this.ProCod = pro_cod; //passando o que está nas propriedades para as variáveis, aqui com a foto do tipo byte
            this.ProNome = pro_nome;
            this.ProDescricao = pro_descricao;
            this.ProFoto = pro_foto;
            this.ProValorPago = pro_valorpago;
            this.ProValorVenda = pro_valorvenda;
            this.ProQtde = pro_qtde;
            this.UmedCod = umed_cod;
            this.CatCod = cat_cod;
            this.ScatCod = scat_cod;
        }

        private int _pro_cod; //criando variável
        public int ProCod //criando propriedade
        {
            get { return this._pro_cod; } //se for pegar retorna o valor da _pro_cod
            set { this._pro_cod = value; } //se for passar, passa o valor do parâmetro     
        }

        private string _pro_nome; //criando variável
        public string ProNome //criando propriedade
        {
            get { return this._pro_nome; } //se for pegar retorna o valor da _pro_nome
            set { this._pro_nome = value; } //se for passar, passa o valor do parâmetro         
        }

        private string _pro_descricao; //criando variável
        public string ProDescricao //criando propriedade
        {
            get { return this._pro_descricao; } //se for pegar retorna o valor da _pro_descricao
            set { this._pro_descricao = value; } //se for passar, passa o valor do parâmetro         
        }

        private byte[] _pro_foto; //criando variável
        public byte[] ProFoto //criando propriedade
        {
            get { return this._pro_foto; } //se for pegar retorna o valor da _pro_foto
            set { this._pro_foto = value; } //se for passar, passa o valor do parâmetro    
        }

        public void CarregaImagem(string imgCaminho)
        {
            try
            {
                if (string.IsNullOrEmpty(imgCaminho))
                    return;
                //fornece propriedades métodos de instância para criar, copiar, excluir, mover e abrir arquivos e ajuda na criação
                //de objetos FileStream.
                FileInfo arqImagem = new FileInfo(imgCaminho);
                //Espôe um Streams ao redor de um arquivo de suporte
                //síncrono e assíncrono operações de leitura e gravar.
                FileStream fs = new FileStream(imgCaminho, FileMode.Open, FileAccess.Read, FileShare.Read);
                //aloca memória para o valor
                this.ProFoto = new byte[Convert.ToInt32(arqImagem.Length)];
                //lê um bloco de bytes do fluxo e grava os dados em um buffer fornecido.
                int iByteRead = fs.Read(this.ProFoto, 0, Convert.ToInt32(arqImagem.Length));
            }

            catch
            {
                //não retorna nada pois o erro que pode dar é de não ter a imagem
            }
        }

        private double _pro_valorpago; //criando variável   
        public double ProValorPago //criando propriedade
        {
            get { return this._pro_valorpago; } //se for pegar retorna o valor da _pro_valorpago
            set { this._pro_valorpago = value; }  //se for passar, passa o valor do parâmetro           
        }

        private double _pro_valorvenda; //criando variável
        public double ProValorVenda //criando propriedade
        {
            get { return this._pro_valorvenda; } //se for pegar retorna o valor da _pro_valorvenda
            set { this._pro_valorvenda = value; } //se for passar, passa o valor do parâmetro        
        }

        private double _pro_qtde; //criando variável
        public double ProQtde //criando propriedade
        {
            get { return this._pro_qtde; } //se for pegar retorna o valor da _pro_qtde
            set { this._pro_qtde = value; } //se for passar, passa o valor do parâmetro         
        }

        private int _umed_cod; //criando variável
        public int UmedCod //criando propriedade
        {
            get { return this._umed_cod; } //se for pegar retorna o valor da _umed_cod
            set { this._umed_cod = value; } //se for passar, passa o valor do parâmetro             
        }

        private int _cat_cod; //criando variável
        public int CatCod //criando propriedade
        {
            get { return this._cat_cod; } //se for pegar retorna o valor da _cat_cod
            set { this._cat_cod = value; } //se for passar, passa o valor do parâmetro             
        }

        private int _scat_cod; //criando variável
        public int ScatCod //criando propriedade
        {
            get { return this._scat_cod; } //se for pegar retorna o valor da _scat_cod
            set { this._scat_cod = value; } //se for passar, passa o valor do parâmetro          
        }

    }

}
