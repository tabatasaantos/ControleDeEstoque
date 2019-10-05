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
    public partial class frmCadastroTipoDePagamento : UI.frmModeloDeFormularioDeCadastro
    {
        public frmCadastroTipoDePagamento()
        {
            InitializeComponent();
        }

        public void LimpaTela()
        {
            txtCodigoTP.Clear();
            txtTipoPagamento.Clear();
        }

        private void frmCadastroTipoDePagamento_Load(object sender, EventArgs e)
        {
            this.AlteraBotoes(1);
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            this.AlteraBotoes(2);
            this.operacao = "Inserir";
        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            frmConsultaTipoDePagamento f = new frmConsultaTipoDePagamento();
            f.ShowDialog();

            if (f.codigo != 0)
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLTipoDePagamento bll = new BLLTipoDePagamento(cx);
                ModeloTipoDePagamento modelo = bll.CarregaModeloTipoDePagamento(f.codigo);
                txtCodigoTP.Text = modelo.TpaCod.ToString();
                txtCodigoTP.Text = modelo.TpaNome;
                AlteraBotoes(3);
            }

            else
            {
                this.LimpaTela();
                this.AlteraBotoes(1);
            }

            f.Dispose();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            this.operacao = "Alterar";
            this.AlteraBotoes(2);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult d = MessageBox.Show("Deseja excluir o registro?", "Aviso", MessageBoxButtons.YesNo);
                if (d.ToString() == "Yes")
                {
                    DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                    BLLTipoDePagamento bll = new BLLTipoDePagamento(cx);
                    bll.Excluir(Convert.ToInt32(txtCodigoTP.Text));
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

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                ModeloTipoDePagamento modelo = new ModeloTipoDePagamento();
                modelo.TpaNome = txtTipoPagamento.Text;
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLTipoDePagamento bll = new BLLTipoDePagamento(cx);

                if (this.operacao == "Inserir")
                {
                    bll.Incluir(modelo);
                    MessageBox.Show("Cadastro efetuado! " + modelo.TpaCod.ToString());
                }
                else
                {
                    //alterar categoria
                    modelo.TpaCod = Convert.ToInt32(txtCodigoTP.Text);
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
    }
}
