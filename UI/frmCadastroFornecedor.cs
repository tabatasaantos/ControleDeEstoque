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
using Ferramentas;

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
            frmConsultaFornecedor f = new frmConsultaFornecedor();
            f.ShowDialog();

            if (f.codigo != 0)
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLFornecedor bll = new BLLFornecedor(cx);
                ModeloFornecedor modelo = bll.CarregaModeloFornecedor(f.codigo);
                txtCodFornecedor.Text = modelo.ForCod.ToString();

                txtNomeFor.Text = modelo.ForNome;
                txtBairro.Text = modelo.ForBairro;
                mskCelular.Text = modelo.ForCel;
                txtCEP.Text = modelo.ForCep;
                txtCidade.Text = modelo.ForCidade;
                txtCNPJ.Text = modelo.ForCnpj;
                txtEmail.Text = modelo.ForEmail;
                txtRua.Text = modelo.ForEndereco;
                txtNumero.Text = modelo.ForEndNum;
                txtEstado.Text = modelo.ForEstado;
                mskTelefone.Text = modelo.ForFone;
                txtIE.Text = modelo.ForIe;
                txtRSocial.Text = modelo.ForRSocial;
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

        private void txtCEP_Leave(object sender, EventArgs e)
        {
            if (Validacao.ValidaCep(txtCEP.Text) == false)
            {
                MessageBox.Show("CEP Inválido!");
            }

            else
            {
                if (BuscaEndereco.verificaCEP(txtCEP.Text) == true)
                {
                    txtBairro.Text = BuscaEndereco.bairro;
                    txtEstado.Text = BuscaEndereco.estado;
                    txtCidade.Text = BuscaEndereco.cidade;
                    txtRua.Text = BuscaEndereco.endereco;
                }
            }
        }
    }
}
