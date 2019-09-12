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
    }
}
