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
using Ferramenta;

namespace UI
{
    public partial class frmCadastroCliente : UI.frmModeloDeFormularioDeCadastro
    {
        public enum Campo
        {
            CPF = 1,
            CNPJ = 2,
        }

        public void Formatar(Campo valor, TextBox txtTexto)
        {
            switch(valor)
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
                    else if(txtTexto.Text.Length == 11)
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
            frmConsultaCliente f = new frmConsultaCliente();
            f.ShowDialog();

            if (f.codigo != 0)
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLCliente bll = new BLLCliente(cx);
                ModeloCliente modelo = bll.CarregaModeloCliente(f.codigo);
                txtCodCliente.Text = modelo.CliCod.ToString();

                if (modelo.CliTipo == "Física")
                {
                    rdbFisica.Checked = true;
                }
                else
                {
                    rdbJuridica.Checked = true;
                }

                txtNomeCli.Text = modelo.CliNome;
                txtBairro.Text = modelo.CliBairro;
                mskCelular.Text = modelo.CliCel;
                txtCEP.Text = modelo.CliCep;
                txtCidade.Text = modelo.CliCidade;
                txtCPF.Text = modelo.CliCpfCnpj;
                txtEmail.Text = modelo.CliEmail;
                txtRua.Text = modelo.CliEndereco;
                txtNumero.Text = modelo.CliEndNum;
                txtEstado.Text = modelo.CliEstado;
                mskTelefone.Text = modelo.CliFone;
                txtRG.Text = modelo.CliRgIe;
                txtRSocial.Text = modelo.CliRSocial;
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

                if(rdbFisica.Checked == true)
                {
                    modelo.CliTipo = "Física";
                    modelo.CliRSocial = "";
                }
                else
                {
                    modelo.CliTipo = "Jurídica"; 
                }

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

        private void txtCPF_Leave(object sender, EventArgs e)
        {
            lblValorInvalido.Visible = false;
            if(rdbFisica.Checked == true)
            {
                //cpf
                if (Validacao.IsCpf(txtCPF.Text) == false)
                {
                    lblValorInvalido.Visible = true;
                }              
            }
            else
            {
                //cnpj
                if(Validacao.IsCnpj(txtCPF.Text) == false)
                {
                    lblValorInvalido.Visible = true;
                }
            }
        }

        private void txtCPF_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)8)
            {
                Campo edit = Campo.CPF;
                if (rdbFisica.Checked == false) edit = Campo.CNPJ;
                {
                    Formatar(edit, txtCPF);
                }
            }

            
        }
    }
}
