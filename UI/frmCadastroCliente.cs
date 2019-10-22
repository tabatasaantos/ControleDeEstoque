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
using Ferramentas;

namespace UI
{
    public partial class frmCadastroCliente : UI.frmModeloDeFormularioDeCadastro
    {
        public frmCadastroCliente()
        {
            InitializeComponent();
        }

        public void LimpaTela()
        {
            txtCodCliente.Clear();
            txtNomeCli.Clear();
            txtRG.Clear();
            txtCPF.Clear();
            txtCEP.Clear();
            txtEstado.Clear();
            txtRSocial.Clear();
            txtRua.Clear();
            txtNumero.Clear();
            mskCelular.Clear();
            mskTelefone.Clear();
            txtEmail.Clear();
            txtBairro.Clear();
            txtCidade.Clear();
            rdbFisica.Checked = true;
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            this.operacao = "Inserir";
            this.AlteraBotoes(2);
        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            /*frmConsultaCategoria f = new frmConsultaCategoria();
            f.ShowDialog();

            if (f.codigo != 0)
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLCategoria bll = new BLLCategoria(cx);
                ModeloCategoria modelo = bll.CarregaModeloCategoria(f.codigo);
                txtCodigo.Text = modelo.CatCod.ToString();
                txtNome.Text = modelo.CatNome;
                AlteraBotoes(3);
            }

            else
            {
                this.LimpaTela();
                this.AlteraBotoes(1);
            }

            f.Dispose();*/
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
                    BLLCliente bll = new BLLCliente(cx);
                    bll.Excluir(Convert.ToInt32(txtCodCliente.Text));
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
                ModeloCliente modelo = new ModeloCliente();
                modelo.CliNome = txtNomeCli.Text;
                modelo.CliBairro = txtBairro.Text;
                modelo.CliCel = mskCelular.Text;
                modelo.CliCep = txtCEP.Text;
                modelo.CliCidade = txtCidade.Text;
                modelo.CliCpfCnpj = txtCPF.Text;
                modelo.CliEmail = txtEmail.Text;
                modelo.CliEndereco = txtRua.Text;
                modelo.CliEndNum = txtNumero.Text;
                modelo.CliEstado = txtEstado.Text;
                modelo.CliFone = mskTelefone.Text;
                modelo.CliRgIe = txtRG.Text;
                modelo.CliRSocial = txtRSocial.Text;
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLCliente bll = new BLLCliente(cx);

                if (this.operacao == "Inserir")
                {
                    bll.Incluir(modelo);
                    MessageBox.Show("Cadastro efetuado! " + modelo.CliCod.ToString());
                }
                else
                {
                    //alterar categoria
                    modelo.CliCod = Convert.ToInt32(txtCodCliente.Text);
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

        private void frmCadastroCliente_Load(object sender, EventArgs e)
        {
            this.AlteraBotoes(1);
        }

        private void rdbFisica_CheckedChanged(object sender, EventArgs e)
        {
            if(rdbFisica.Checked == true)
            {
                lblRazaoCli.Visible = false;
                txtRSocial.Visible = false;
                lblCPF.Text = "CPF";
                lblRG.Text = "RG";            
            }
            else
            {
                lblRazaoCli.Visible = true;
                txtRSocial.Visible = true;
                lblCPF.Text = "CNPJ";
                lblRG.Text = "IE";
            }
        }

        private void txtCEP_Leave(object sender, EventArgs e)
        {
            if (BuscaEndereco.verificaCEP(txtCEP.Text) == true)
            {
                txtBairro.Text = BuscaEndereco.bairro;
                txtEstado.Text = BuscaEndereco.estado;
                txtCidade.Text = BuscaEndereco.cidade;
                txtRua.Text = BuscaEndereco.endereco;
            }

            else
            {
                //limpar os campos do endereço
            }
        }
    }
}
