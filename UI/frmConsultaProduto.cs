using BLL;
using DAL;
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
    public partial class frmConsultaProduto : Form
    {
        public int codigo = 0;

        public frmConsultaProduto()
        {
            InitializeComponent();
        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLProduto bll = new BLLProduto(cx);
            dgvDados.DataSource = bll.Localizar(txtValor.Text);
        }

        private void frmConsultaProduto_Load(object sender, EventArgs e)
        {
            btnLocalizar_Click(sender, e);
            dgvDados.Columns[0].HeaderText = "Código";
            dgvDados.Columns[0].Width = 46;
            dgvDados.Columns[1].HeaderText = "Produto";
            dgvDados.Columns[1].Width = 100;
            dgvDados.Columns[2].HeaderText = "Descrição";
            dgvDados.Columns[2 ].Width = 200;
            dgvDados.Columns[3].HeaderText = "Foto";
            dgvDados.Columns[3].Width = 50;
            dgvDados.Columns[4].HeaderText = "Valor Pago";
            dgvDados.Columns[4].Width = 100;
            dgvDados.Columns[5].HeaderText = "Valor de Venda";
            dgvDados.Columns[5].Width = 100;
            dgvDados.Columns[6].HeaderText = "Quantidade";
            dgvDados.Columns[6].Width = 75;
            dgvDados.Columns[7].HeaderText = "Unidade de Medida";
            dgvDados.Columns[7].Width = 75;
            dgvDados.Columns[8].HeaderText = "Categoria";
            dgvDados.Columns[8].Width = 75;
            dgvDados.Columns[9].HeaderText = "SubCategoria";
            dgvDados.Columns[9].Width = 75;
            dgvDados.Columns[10].HeaderText = "Unidade de Medida";
            dgvDados.Columns[10].Width = 75;
            dgvDados.Columns[11].HeaderText = "Categoria";
            dgvDados.Columns[11].Width = 75;
            dgvDados.Columns[12].HeaderText = "SubCategoria";
            dgvDados.Columns[12].Width = 75;

            //oculta coluna

            dgvDados.Columns[8].Visible = false;
            dgvDados.Columns[9].Visible = false;
            dgvDados.Columns[4].Visible = false;
            dgvDados.Columns[5].Visible = false;
            dgvDados.Columns[7].Visible = false;
            dgvDados.Columns[3].Visible = false;

            //verificar porque não salva sem foto.
        }

        private void dgvDados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                this.codigo = Convert.ToInt32(dgvDados.Rows[e.RowIndex].Cells[0].Value);
                this.Close();
            }
        }
    }
}
                        