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
    public partial class frmCadastroUnidadeDeMedida : UI.frmModeloDeFormularioDeCadastro
    {
        public frmCadastroUnidadeDeMedida()
        {
            InitializeComponent();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            this.operacao = "Inserir";
            this.AlteraBotoes(2);
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            this.operacao = "Alterar";
            this.AlteraBotoes(2);
        }

        public void LimpaTela()
        {
            txtCodUmed.Clear();
            txtUmed.Clear();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

            try
            {
                DialogResult d = MessageBox.Show("Deseja excluir o registro?", "Aviso", MessageBoxButtons.YesNo);
                if (d.ToString() == "Yes")
                {
                    DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                    BLLUnidadeDeMedida bll = new BLLUnidadeDeMedida(cx);
                    bll.Excluir(Convert.ToInt32(txtCodUmed.Text));
                    this.LimpaTela();
                    this.AlteraBotoes(1);
                   // MessageBox.Show("message");
                }
            }
            catch
            {
                MessageBox.Show("Impossível excluir esse registro. \nO registro está sendo utilizado em outro local.");
                this.AlteraBotoes(3);
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                //leitura dos dados
                ModeloUnidadeDeMedida modelo = new ModeloUnidadeDeMedida();
                modelo.UmedNome = txtUmed.Text;
                //obj para gravar os dados no BD
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLUnidadeDeMedida bll = new BLLUnidadeDeMedida(cx);

                if (this.operacao == "Inserir")
                {
                    //cadastrar categoria
                    bll.Incluir(modelo);
                    MessageBox.Show("Cadastro efetuado! " + modelo.UmedCod.ToString());
                }
                else
                {
                    //alterar categoria
                    modelo.UmedCod = Convert.ToInt32(txtCodUmed.Text);
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

        private void btnCalcelar_Click(object sender, EventArgs e)
        {
            this.LimpaTela();
            this.AlteraBotoes(1);
        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            frmConsultaCategoria f = new frmConsultaCategoria();
            f.ShowDialog();

            if (f.codigo != 0)
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLUnidadeDeMedida bll = new BLLUnidadeDeMedida(cx);
                ModeloUnidadeDeMedida modelo = bll.CarregaModeloUnidadeDeMedida(f.codigo);
                txtCodUmed.Text = modelo.UmedCod.ToString();
                txtUmed.Text = modelo.UmedNome;
                AlteraBotoes(3);
            }

            else
            {
                this.LimpaTela();
                this.AlteraBotoes(1);
            }

            f.Dispose();
        }

        private void btnLocalizar_Click_1(object sender, EventArgs e)
        {
            frmConsultaUnidadeDeMedida f = new frmConsultaUnidadeDeMedida();
            f.ShowDialog();

            if (f.codigo != 0)
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLUnidadeDeMedida bll = new BLLUnidadeDeMedida(cx);
                ModeloUnidadeDeMedida modelo = bll.CarregaModeloUnidadeDeMedida(f.codigo);
                txtCodUmed.Text = modelo.UmedCod.ToString();
                txtUmed.Text = modelo.UmedNome;
                AlteraBotoes(3);
            }

            else
            {
                this.LimpaTela();
                this.AlteraBotoes(1);
            }

            f.Dispose();
        }

        private void txtUmed_Leave(object sender, EventArgs e)
        {
            if(this.operacao == "Inserir")
            {
                int r = 0;
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLUnidadeDeMedida bll = new BLLUnidadeDeMedida(cx);
                r = bll.VerificaUnidadeDeMedida(txtUmed.Text);

                if(r > 0)
                {
                    DialogResult d = MessageBox.Show("Já existe um registro com esse valor. Deseja alterar o registro?", "Aviso", MessageBoxButtons.YesNo);
                    if (d.ToString() == "Yes")
                    {
                        this.operacao = "Alterar";
                        ModeloUnidadeDeMedida modelo = bll.CarregaModeloUnidadeDeMedida(r);
                        txtCodUmed.Text = modelo.UmedCod.ToString();
                        txtUmed.Text = modelo.UmedNome;
                    }
                }           
            }
        }
    }
}
