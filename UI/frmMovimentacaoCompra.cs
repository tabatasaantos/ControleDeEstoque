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
    public partial class frmMovimentacaoCompra : UI.frmModeloDeFormularioDeCadastro
    {
        public double totalCompra = 0;

        public frmMovimentacaoCompra()
        {
            InitializeComponent();
        }

        public void LimpaTela()
        {
            txtCodCom.Clear();
            txtNFeCom.Clear();
            txtCodFor.Clear();
            txtCodPro.Clear();
            lblNomePro.Text = "Informe o código do produto ou clique em localizar";
            txtQtd.Clear();
            txtValorUni.Clear();
            txtTotal.Clear();
            dgvItens.Rows.Clear();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            this.operacao = "Inserir";
            this.totalCompra = 0;
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
        }
        //{
        //        this.LimpaTela();
        //        this.AlteraBotoes(1);
        //}

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
                    BLLCompra bll = new BLLCompra(cx);
                    bll.Excluir(Convert.ToInt32(txtCodCom.Text));
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
            //try
            //{
            //    ModeloCliente modelo = new ModeloCliente();
            //    modelo.CliNome = txtNomeCli.Text;
            //    modelo.CliBairro = txtBairro.Text;
            //    modelo.CliCel = mskCelular.Text;
            //    modelo.CliCep = txtCEP.Text;
            //    modelo.CliCidade = txtCidade.Text;
            //    modelo.CliCpfCnpj = txtCPF.Text;
            //    modelo.CliEmail = txtEmail.Text;
            //    modelo.CliEndereco = txtRua.Text;
            //    modelo.CliEndNum = txtNumero.Text;
            //    modelo.CliEstado = txtEstado.Text;
            //    modelo.CliFone = mskTelefone.Text;
            //    modelo.CliRgIe = txtRG.Text;
            //    modelo.CliRSocial = txtRSocial.Text;

            //    if (rdbFisica.Checked == true)
            //    {
            //        modelo.CliTipo = "Física";
            //        modelo.CliRSocial = "";
            //    }
            //    else
            //    {
            //        modelo.CliTipo = "Jurídica";
            //    }

            //    DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            //    BLLCliente bll = new BLLCliente(cx);

            //    if (this.operacao == "Inserir")
            //    {
            //        bll.Incluir(modelo);
            //        MessageBox.Show("Cadastro efetuado! " + modelo.CliCod.ToString());
            //    }
            //    else
            //    {
            //        //alterar categoria
            //        modelo.CliCod = Convert.ToInt32(txtCodCliente.Text);
            //        bll.Alterar(modelo);
            //        MessageBox.Show("Cadastro alterado com sucesso!");
            //    }

            //    this.LimpaTela();
            //    this.AlteraBotoes(1);
            //}

            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }

        private void btnCalcelar_Click(object sender, EventArgs e)
        {
            this.LimpaTela();
            this.AlteraBotoes(1);
            this.totalCompra = 0;
        }

        private void btnLocalizarFor_Click(object sender, EventArgs e)
        {
            frmConsultaFornecedor f = new frmConsultaFornecedor();
            f.ShowDialog();

            if (f.codigo != 0)
            {
                txtCodFor.Text = f.codigo.ToString();
                txtCodFor_Leave(sender, e);
            }
        }

        private void txtCodFor_Leave(object sender, EventArgs e)
        {
            try
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLFornecedor bll = new BLLFornecedor(cx);
                ModeloFornecedor modelo = bll.CarregaModeloFornecedor(Convert.ToInt32(txtCodFor.Text));
                lblNomeFor.Text = modelo.ForNome;
            }

            catch
            {
                txtCodFor.Clear();
                lblNomeFor.Text = "Informe o código do fornecedor ou clique em locacalizar";
            }
        }

        private void btnLocalizarPro_Click(object sender, EventArgs e)
        {
            frmConsultaProduto f = new frmConsultaProduto();
            f.ShowDialog();

            if (f.codigo != 0)
            {
                txtCodPro.Text = f.codigo.ToString();
                txtCodPro_Leave(sender, e);
            }
        }

        private void txtCodPro_Leave(object sender, EventArgs e)
        {
            try
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLProduto bll = new BLLProduto(cx);
                ModeloProduto modelo = bll.CarregaModeloProduto(Convert.ToInt32(txtCodPro.Text));
                lblNomePro.Text = modelo.ProNome;
                txtQtd.Text = "1";
                txtValorUni.Text = modelo.ProValorPago.ToString();
            }

            catch
            {
                txtCodFor.Clear();
                lblNomePro.Text = "Informe o código do produto ou clique em locacalizar";
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if((txtCodPro.Text != "") && (txtQtd.Text != "") && (txtValorUni.Text != ""))
            {
                double TotalLocal = Convert.ToDouble(txtQtd.Text) * Convert.ToDouble(txtValorUni.Text);
                this.totalCompra = this.totalCompra + TotalLocal;
                string[] i = new string[] { txtCodPro.Text, lblNomePro.Text, txtQtd.Text, txtValorUni.Text, TotalLocal.ToString() };
                this.dgvItens.Rows.Add(i);
            }

            txtCodPro.Clear();
            lblNomePro.Text = "Informe o código do produto ou clique em locacalizar";
            txtQtd.Clear();
            txtValorUni.Clear();

            txtTotal.Text = this.totalCompra.ToString();


        }

        private void frmMovimentacaoCompra_Load(object sender, EventArgs e)
        {
            this.AlteraBotoes(1);
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLTipoDePagamento bll = new BLLTipoDePagamento(cx);
            cmbPgto.DataSource = bll.Localizar("");
            cmbPgto.DisplayMember = "tpa_nome";
            cmbPgto.ValueMember = "tpa_cod";
        }

        private void dgvItens_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                txtCodPro.Text = dgvItens.Rows[e.RowIndex].Cells[0].Value.ToString();
                lblNomePro.Text = dgvItens.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtQtd.Text = dgvItens.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtValorUni.Text = dgvItens.Rows[e.RowIndex].Cells[3].Value.ToString();
                double valor = Convert.ToDouble(dgvItens.Rows[e.RowIndex].Cells[4].Value);
                this.totalCompra = this.totalCompra - valor;
                dgvItens.Rows.RemoveAt(e.RowIndex);
                txtTotal.Text = this.totalCompra.ToString();
            }
        }
    }
}

