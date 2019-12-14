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
    public partial class frmConsultaFornecedor : Form
    {
        public int codigo = 0;

        public frmConsultaFornecedor()
        {
            InitializeComponent();
        }

        private void frmConsultaFornecedor_Load(object sender, EventArgs e)
        {
            btnLocalizar_Click(sender, e);
            dgvDados.Columns[0].HeaderText = "Código";
            //dgvDados.Columns[0].Width = 46;
            dgvDados.Columns[1].HeaderText = "Nome";
            //dgvDados.Columns[1].Width = 400;
            dgvDados.Columns[2].HeaderText = "CNPJ";
            dgvDados.Columns[3].HeaderText = "IE";
            dgvDados.Columns[4].HeaderText = "Razão Social";
            dgvDados.Columns[5].HeaderText = "CEP";
            dgvDados.Columns[6].HeaderText = "Rua";
            dgvDados.Columns[7].HeaderText = "Bairro";
            dgvDados.Columns[8].HeaderText = "Telefone";
            dgvDados.Columns[9].HeaderText = "Celular";
            dgvDados.Columns[10].HeaderText = "E-mail";
            dgvDados.Columns[11].HeaderText = "Número";
            dgvDados.Columns[12].HeaderText = "Cidade";
            dgvDados.Columns[13].HeaderText = "Estado";
        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLFornecedor bll = new BLLFornecedor(cx);
            if (rdbConsultaNome.Checked == true)
            {
                dgvDados.DataSource = bll.LocalizarPorNome(txtValor.Text);
            }
            else
            {
                dgvDados.DataSource = bll.LocalizarPorCNPJ(txtValor.Text);
            }
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
