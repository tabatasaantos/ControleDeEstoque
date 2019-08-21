using BLL;
using DAL;
using Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UI
{
    public partial class frmCadastroSubCategoria : UI.frmModeloDeFormularioDeCadastro
    {
        public frmCadastroSubCategoria()
        {
            InitializeComponent();
        }

        public void LimpaTela()
        {
            txtNomeSubCat.Clear();
            txtCodigoSubCat.Clear();
        }

        private void frmCadastroSubCategoria_Load(object sender, EventArgs e)
        {
            this.AlteraBotoes(1);
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLCategoria bll = new BLLCategoria(cx);
            cbNomeCat.DataSource = bll.Localizar("");
            cbNomeCat.DisplayMember = "cat_nome";
            cbNomeCat.ValueMember = "cat_cod";
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            this.AlteraBotoes(2);
            this.operacao = "Inserir";
        }

        private void btnCalcelar_Click(object sender, EventArgs e)
        {
            this.LimpaTela();
            this.AlteraBotoes(1); 
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            this.AlteraBotoes(2);
            this.operacao = "Alterar";
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                //leitura dos dados
                ModeloSubCategoria modelo = new ModeloSubCategoria();
                modelo.SCatNome = txtNomeSubCat.Text;
                modelo.CatCod = Convert.ToInt32(cbNomeCat.SelectedValue);
                //obj para gravar os dados no BD
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLSubCategoria bll = new BLLSubCategoria(cx);

                if (this.operacao == "Inserir")
                {
                    //cadastrar categoria
                    bll.Incluir(modelo);
                    MessageBox.Show("Cadastro efetuado! " + modelo.ScatCod.ToString());
                }
                else
                {
                    //alterar categoria
                    modelo.ScatCod = Convert.ToInt32(txtCodigoSubCat.Text);
                    bll.Alterar(modelo);
                    MessageBox.Show("Cadastro alterado com sucesso!");
                }

                this.LimpaTela();
                this.AlteraBotoes(1);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult d = MessageBox.Show("Deseja excluir o registro?", "Aviso", MessageBoxButtons.YesNo);

                if (d.ToString() == "Yes")
                {
                    DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                    BLLSubCategoria bll = new BLLSubCategoria(cx);
                    bll.Excluir(Convert.ToInt32(txtCodigoSubCat.Text));
                    this.LimpaTela();
                    this.AlteraBotoes(1);
                }
            }
            catch
            {
                MessageBox.Show("Impossível excluir esse registro. \nO registro está sendo utilizado em outro local.");
                this.AlteraBotoes(3);
            }

        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            frmConsultaSubCategoria f = new frmConsultaSubCategoria();
            f.ShowDialog();

            if (f.codigo != 0)
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLSubCategoria bll = new BLLSubCategoria(cx);
                ModeloSubCategoria modelo = bll.CarregaModeloSubCategoria(f.codigo);
                txtCodigoSubCat.Text = modelo.ScatCod.ToString();
                txtNomeSubCat.Text = modelo.SCatNome;
                cbNomeCat.SelectedValue = modelo.CatCod;
                AlteraBotoes(3);
            }

            else
            {
                this.LimpaTela();
                this.AlteraBotoes(1);
            }

            f.Dispose();
        }
    }
}
