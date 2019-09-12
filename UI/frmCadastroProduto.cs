using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {
            toolTip1.Show("Carregar Imagem", btnCarregar);
        }

        private void toolTip2_Popup(object sender, PopupEventArgs e)
        {
            toolTip2.Show("Remover Imagem", btnRemover);
        }

        private void btnInserir_Click(object sender, EventArgs e)
        { 
            this.operacao = "Inserir";
            AlteraBotoes(2);
        }

        private void frmCadastroProduto_Load(object sender, EventArgs e)
        {
            this.AlteraBotoes(1);
        }

        private void txtValorVenda_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            if(e.KeyChar == ','|| e.KeyChar =='.')
            {
                if(!txtValorVenda.Text.Contains("."))
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
    }
}
