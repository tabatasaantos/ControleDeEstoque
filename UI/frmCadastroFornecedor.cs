using BLL;
using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Modelo;
using Ferramenta;

namespace UI
{
    public partial class frmCadastroFornecedor : UI.frmModeloDeFormularioDeCadastro
    {
        public frmCadastroFornecedor()
        {
            InitializeComponent();
        }

        public enum Campo
        {
            CPF = 1,
            CNPJ = 2,
        }

        public void Formatar(Campo valor, TextBox txtTexto)
        {
            switch (valor)
            {
                case Campo.CPF:
                    txtTexto.MaxLength = 14;
                    if (txtTexto.Text.Length == 3)
                    {
                        txtTexto.Text = txtTexto.Text + ".";
                        txtTexto.SelectionStart = txtTexto.Text.Length + 1;
                    }
                    else if (txtTexto.Text.Length == 7)
                    {
                        txtTexto.Text = txtTexto.Text + ".";
                        txtTexto.SelectionStart = txtTexto.Text.Length + 1;
                    }
                    else if (txtTexto.Text.Length == 11)
                    {
                        txtTexto.Text = txtTexto.Text + "-";
                        txtTexto.SelectionStart = txtTexto.Text.Length + 1;
                    }
                    break;
            }

            switch (valor)
            {
                case Campo.CNPJ:
                    txtTexto.MaxLength = 18;
                    if (txtTexto.Text.Length == 2 || txtTexto.Text.Length == 6)
                    {
                        txtTexto.Text = txtTexto.Text + ".";
                        txtTexto.SelectionStart = txtTexto.Text.Length + 1;
                    }
                    else if (txtTexto.Text.Length == 10)
                    {
                        txtTexto.Text = txtTexto.Text + "/";
                        txtTexto.SelectionStart = txtTexto.Text.Length + 1;
                    }
                    else if (txtTexto.Text.Length == 15)
                    {
                        txtTexto.Text = txtTexto.Text + "-";
                        txtTexto.SelectionStart = txtTexto.Text.Length + 1;
                    }
                    break;
            }
        }

        public void LimpaTela()
        {
            txtCodFornecedor.Clear();
            txtNomeFor.Clear();
            txtIE.Clear();
            txtCNPJ.Clear();
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
            lblValorInvalido.Visible = false;
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            this.operacao = "Inserir";
            this.AlteraBotoes(2);
        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            //frmConsultaCliente f = new frmConsultaCliente();
            //f.ShowDialog();

            //if (f.codigo != 0)
            //{
            //    DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            //    BLLCliente bll = new BLLCliente(cx);
            //    ModeloCliente modelo = bll.CarregaModeloCliente(f.codigo);
            //    txtCodCliente.Text = modelo.CliCod.ToString();

            //    if (modelo.CliTipo == "Física")
            //    {
            //        rdbFisica.Checked = true;
            //    }
            //    else
            //    {
            //        rdbJuridica.Checked = true;
            //    }

            //    txtNomeCli.Text = modelo.CliNome;
            //    txtBairro.Text = modelo.CliBairro;
            //    mskCelular.Text = modelo.CliCel;
            //    txtCEP.Text = modelo.CliCep;
            //    txtCidade.Text = modelo.CliCidade;
            //    txtCPF.Text = modelo.CliCpfCnpj;
            //    txtEmail.Text = modelo.CliEmail;
            //    txtRua.Text = modelo.CliEndereco;
            //    txtNumero.Text = modelo.CliEndNum;
            //    txtEstado.Text = modelo.CliEstado;
            //    mskTelefone.Text = modelo.CliFone;
            //    txtRG.Text = modelo.CliRgIe;
            //    txtRSocial.Text = modelo.CliRSocial;
            //    AlteraBotoes(3);
            //}
            //else
            //{
            //    this.LimpaTela();
            //    this.AlteraBotoes(1);
            //}

            //f.Dispose();
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
                    BLLFornecedor bll = new BLLFornecedor(cx);
                    bll.Excluir(Convert.ToInt32(txtCodFornecedor.Text));
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
                ModeloFornecedor modelo = new ModeloFornecedor();
                modelo.ForNome = txtNomeFor.Text;
                modelo.ForBairro = txtBairro.Text;
                modelo.ForCel = mskCelular.Text;
                modelo.ForCep = txtCEP.Text;
                modelo.ForCidade = txtCidade.Text;
                modelo.ForCnpj = txtCNPJ.Text;
                modelo.ForEmail = txtEmail.Text;
                modelo.ForEndereco = txtRua.Text;
                modelo.ForEndNum = txtNumero.Text;
                modelo.ForEstado = txtEstado.Text;
                modelo.ForFone = mskTelefone.Text;
                modelo.ForIe = txtIE.Text;
                modelo.ForRSocial = txtRSocial.Text;
         
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLFornecedor bll = new BLLFornecedor(cx);

                if (this.operacao == "Inserir")
                {
                    bll.Incluir(modelo);
                    MessageBox.Show("Cadastro efetuado! " + modelo.ForCod.ToString());
                }
                else
                {
                    //alterar categoria
                    modelo.ForCod = Convert.ToInt32(txtCodFornecedor.Text);
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
            {
                this.LimpaTela();
                this.AlteraBotoes(1);
            }

        }

        private void txtCNPJ_Leave(object sender, EventArgs e)
        {
            lblValorInvalido.Visible = false;
            if (Validacao.IsCnpj(txtCNPJ.Text) == false)
            {
                lblValorInvalido.Visible = true;
            }
        }

        private void txtCNPJ_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)8)
            {
                Campo edit = Campo.CNPJ;              
                Formatar(edit, txtCNPJ);
            }
        }
    }
}
