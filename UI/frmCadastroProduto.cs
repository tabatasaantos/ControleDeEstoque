using BLL;
using DAL;
using Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace UI
{
    public partial class frmCadastroProduto : UI.frmModeloDeFormularioDeCadastro
    {
        public string foto = "";

        public frmCadastroProduto()
        {
            InitializeComponent();
            toolTipCarrega.SetToolTip(btnCarregar, "Carregar Imagem");
            toolTipRemove.SetToolTip(btnRemover, "Remover Imagem");
        }

        private void LimpaTela()
        {
            txtCodProduto.Clear();
            txtDescricaoProduto.Clear();
            txtNomeProduto.Clear();
            txtValorPago.Clear();
            txtValorVenda.Clear();
            txtQtdeProduto.Clear();
            this.foto = "";
            pbFoto.Image = null;
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            this.operacao = "Inserir";
            AlteraBotoes(2);
        }

        private void frmCadastroProduto_Load(object sender, EventArgs e)
        {
            this.AlteraBotoes(1);
            //combo da categoria
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLCategoria bll = new BLLCategoria(cx);
            cmbCategoria.DataSource = bll.Localizar("");
            cmbCategoria.DisplayMember = "cat_nome";
            cmbCategoria.ValueMember = "cat_cod";

            try
            {
                //combo da subcategoria           
                BLLSubCategoria sbll = new BLLSubCategoria(cx);
                cmbSubCategoria.DataSource = sbll.LocalizarPorCategoria((int)cmbCategoria.SelectedValue);
                cmbSubCategoria.DisplayMember = "scat_nome";
                cmbSubCategoria.ValueMember = "scat_cod";
            }
            catch
            {
                MessageBox.Show("Cadastre uma categoria!");
            }

            //combo unidade de medida
            BLLUnidadeDeMedida ubll = new BLLUnidadeDeMedida(cx);
            cmbUnMedida.DataSource = ubll.Localizar("");
            cmbUnMedida.DisplayMember = "umed_nome";
            cmbUnMedida.ValueMember = "umed_cod";
        }

        private void txtValorVenda_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            if (e.KeyChar == ',' || e.KeyChar == '.')
            {
                if (!txtValorVenda.Text.Contains("."))
                {
                    e.KeyChar = '.';
                }

                else
                {
                    e.Handled = true;
                }
            }
        }

        private void txtValorVenda_Leave(object sender, EventArgs e)
        {
            if (txtValorVenda.Text.Contains(".") == false)
            {
                txtValorVenda.Text += ".00";
            }
            else
            {
                if (txtValorVenda.Text.IndexOf(".") == txtValorVenda.Text.Length - 1)
                {
                    txtValorVenda.Text += "00";
                }
            }

            try
            {
                double d = Convert.ToDouble(txtValorVenda.Text);
            }

            catch
            {
                txtValorVenda.Text = "0.00";
            }
        }

        private void txtValorPago_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            if (e.KeyChar == ',' || e.KeyChar == '.')
            {
                if (!txtValorPago.Text.Contains("."))
                {
                    e.KeyChar = '.';
                }

                else
                {
                    e.Handled = true;
                }
            }
        }

        private void txtValorPago_Leave(object sender, EventArgs e)
        {
            {
                if (txtValorPago.Text.Contains(".") == false)
                {
                    txtValorPago.Text += ".00";
                }
                else
                {
                    if (txtValorPago.Text.IndexOf(".") == txtValorPago.Text.Length - 1)
                    {
                        txtValorPago.Text += "00";
                    }
                }

                try
                {
                    double d = Convert.ToDouble(txtValorPago.Text);
                }

                catch
                {
                    txtValorPago.Text = "0.00";
                }
            }
        }

        private void txtQtdeProduto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            if (e.KeyChar == ',' || e.KeyChar == '.')
            {
                if (!txtQtdeProduto.Text.Contains("."))
                {
                    e.KeyChar = '.';
                }

                else
                {
                    e.Handled = true;
                }
            }
        }

        private void txtQtdeProduto_Leave(object sender, EventArgs e)
        {
            if (txtQtdeProduto.Text.Contains(".") == false)
            {
                txtQtdeProduto.Text += ".00";
            }
            else
            {
                if (txtQtdeProduto.Text.IndexOf(".") == txtQtdeProduto.Text.Length - 1)
                {
                    txtQtdeProduto.Text += "00";
                }
            }

            try
            {
                double d = Convert.ToDouble(txtQtdeProduto.Text);
            }

            catch
            {
                txtQtdeProduto.Text = "0.00";
            }
        }

        private void cmbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            try
            {
                cmbSubCategoria.Text = "";
                //combo da subcategoria           
                BLLSubCategoria sbll = new BLLSubCategoria(cx);
                cmbSubCategoria.DataSource = sbll.LocalizarPorCategoria((int)cmbCategoria.SelectedValue);
                cmbSubCategoria.DisplayMember = "scat_nome";
                cmbSubCategoria.ValueMember = "scat_cod";
            }
            catch
            {

            }
        }

        private void btnCarregar_Click(object sender, EventArgs e)
        {
            OpenFileDialog od = new OpenFileDialog();
            od.ShowDialog();
            if (!string.IsNullOrEmpty(od.FileName))
            {
                this.foto = od.FileName;
                pbFoto.Load(this.foto);
            }
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            this.foto = "";
            pbFoto.Image = null;
        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            frmConsultaProduto f = new frmConsultaProduto();
            f.ShowDialog();

            if (f.codigo != 0)
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLProduto bll = new BLLProduto(cx);
                ModeloProduto modelo = bll.CarregaModeloProduto(f.codigo);
                txtCodProduto.Text = modelo.ProCod.ToString();
                txtNomeProduto.Text = modelo.ProNome;
                txtDescricaoProduto.Text = modelo.ProDescricao;
                txtQtdeProduto.Text = modelo.ProQtde.ToString();
                txtValorPago.Text = modelo.ProValorPago.ToString();
                txtValorVenda.Text = modelo.ProValorVenda.ToString();
                cmbCategoria.SelectedValue = modelo.CatCod;
                cmbSubCategoria.SelectedValue = modelo.ScatCod;
                cmbUnMedida.SelectedValue = modelo.UmedCod;

                try
                {
                    MemoryStream ms = new MemoryStream(modelo.ProFoto);
                    pbFoto.Image = Image.FromStream(ms);
                }
                catch
                {

                }
                
                AlteraBotoes(3);
            }

            else
            {
                this.LimpaTela();
                this.AlteraBotoes(1);
            }

            f.Dispose();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult d = MessageBox.Show("Deseja excluir o registro?", "Aviso", MessageBoxButtons.YesNo);

                if (d.ToString() == "Yes")
                {
                    DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                    BLLProduto bll = new BLLProduto(cx);
                    bll.Excluir(Convert.ToInt32(txtCodProduto.Text));
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

        private void btnCalcelar_Click(object sender, EventArgs e)
        {
            this.AlteraBotoes(1);
            this.LimpaTela();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                //leitura dos dados
                ModeloProduto modelo = new ModeloProduto();
                modelo.ProNome = txtNomeProduto.Text;
                modelo.ProDescricao = txtDescricaoProduto.Text;
                modelo.ProValorPago = Convert.ToDouble(txtValorPago.Text);
                modelo.ProValorVenda = Convert.ToDouble(txtValorVenda.Text);
                modelo.ProQtde = Convert.ToDouble(txtQtdeProduto.Text);
                modelo.UmedCod = Convert.ToInt32(cmbUnMedida.SelectedValue);
                modelo.CatCod = Convert.ToInt32(cmbCategoria.SelectedValue);
                modelo.ScatCod = Convert.ToInt32(cmbSubCategoria.SelectedValue);
                modelo.CarregaImagem(this.foto);

                //obj para gravar os dados no BD
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLProduto bll = new BLLProduto(cx);

                if (this.operacao == "Inserir")
                {
                    bll.Incluir(modelo);
                    MessageBox.Show("Cadastro efetuado: Código " + modelo.ProCod.ToString());
                }
                else
                {
                    modelo.ProCod = Convert.ToInt32(txtCodProduto.Text);
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

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            this.operacao = "Alterar";
            this.AlteraBotoes(2);
        }
    }
}

       
    



