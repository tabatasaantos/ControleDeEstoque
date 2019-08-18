using BLL;
using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UI
{
    public partial class frmCadastroSubCategoria : UI.frmModeloDeFormularioDeCadastro
    {
        public frmCadastroSubCategoria()
        {
            InitializeComponent();
        }

        private void frmCadastroSubCategoria_Load(object sender, EventArgs e)
        {
            this.AlteraBotoes(1);
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLCategoria bll = new BLLCategoria(cx);
            cbNomeCat.DataSource = bll.Localizar("");
            cbNomeCat.DisplayMember = "cat_nome";
            cbNomeCat.ValueMember = "cat_cod";
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            this.AlteraBotoes(2);
            this.operacao = "Inserir";
        }
    }
}
