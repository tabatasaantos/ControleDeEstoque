using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class frmModeloDeFormularioDeCadastro : Form
    {
        public string operacao;

        public frmModeloDeFormularioDeCadastro()
        {
            InitializeComponent();
            toolTipModelo.SetToolTip(btnInserir, "Incluir um novo registro");
            toolTipModelo.SetToolTip(btnLocalizar, "Localizar um registro cadastrado");
            toolTipModelo.SetToolTip(btnAlterar, "Alterar um registro");
            toolTipModelo.SetToolTip(btnExcluir, "Excluir um registro");
            toolTipModelo.SetToolTip(btnSalvar, "Salvar um novo registro");
            toolTipModelo.SetToolTip(btnCalcelar, "Cancelar a manipulação do registro");
        }

        public void AlteraBotoes(int op)
        {
            // op = operações que serão feitas com os botões
            // 1 = Preparar ps botões para incluir e localizar
            // 2 = Preparar para incluir ou alterar um registro
            // 3 = Preparar a tela para excluir ou alterar

            pnDados.Enabled = false;
            btnInserir.Enabled = false;
            btnLocalizar.Enabled = false;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnSalvar.Enabled = false;
            btnCalcelar.Enabled = false;

            if (op == 1)
            {
                btnInserir.Enabled = true;
                btnLocalizar.Enabled = true;
            }

            if (op == 2)
            {
                pnDados.Enabled = true;
                btnSalvar.Enabled = true;
                btnCalcelar.Enabled = true;
            }
            if (op == 3)
            {
                btnExcluir.Enabled = true;
                btnCalcelar.Enabled = true;
                btnAlterar.Enabled = true;
            }
        }

        private void frmFormularioCadastro_Load(object sender, EventArgs e)
        {
            this.AlteraBotoes(1);
        }

        private void frmModeloDeFormularioDeCadastro_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
            }
        }
    }
}
