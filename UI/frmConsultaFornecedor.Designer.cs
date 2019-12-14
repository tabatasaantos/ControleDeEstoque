namespace UI
{
    partial class frmConsultaFornecedor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbConsuktaCPF = new System.Windows.Forms.RadioButton();
            this.rdbConsultaNome = new System.Windows.Forms.RadioButton();
            this.dgvDados = new System.Windows.Forms.DataGridView();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.lblBusca = new System.Windows.Forms.Label();
            this.btnLocalizar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbConsuktaCPF);
            this.groupBox1.Controls.Add(this.rdbConsultaNome);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(134, 90);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Consultar por";
            // 
            // rdbConsuktaCPF
            // 
            this.rdbConsuktaCPF.AutoSize = true;
            this.rdbConsuktaCPF.Location = new System.Drawing.Point(10, 58);
            this.rdbConsuktaCPF.Name = "rdbConsuktaCPF";
            this.rdbConsuktaCPF.Size = new System.Drawing.Size(52, 17);
            this.rdbConsuktaCPF.TabIndex = 1;
            this.rdbConsuktaCPF.Text = "CNPJ";
            this.rdbConsuktaCPF.UseVisualStyleBackColor = true;
            // 
            // rdbConsultaNome
            // 
            this.rdbConsultaNome.AutoSize = true;
            this.rdbConsultaNome.Checked = true;
            this.rdbConsultaNome.Location = new System.Drawing.Point(10, 20);
            this.rdbConsultaNome.Name = "rdbConsultaNome";
            this.rdbConsultaNome.Size = new System.Drawing.Size(53, 17);
            this.rdbConsultaNome.TabIndex = 0;
            this.rdbConsultaNome.TabStop = true;
            this.rdbConsultaNome.Text = "Nome";
            this.rdbConsultaNome.UseVisualStyleBackColor = true;
            // 
            // dgvDados
            // 
            this.dgvDados.AllowUserToAddRows = false;
            this.dgvDados.AllowUserToDeleteRows = false;
            this.dgvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDados.Location = new System.Drawing.Point(12, 108);
            this.dgvDados.Name = "dgvDados";
            this.dgvDados.ReadOnly = true;
            this.dgvDados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDados.Size = new System.Drawing.Size(616, 285);
            this.dgvDados.TabIndex = 11;
            this.dgvDados.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDados_CellDoubleClick);
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(155, 32);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(425, 20);
            this.txtValor.TabIndex = 10;
            // 
            // lblBusca
            // 
            this.lblBusca.AutoSize = true;
            this.lblBusca.Location = new System.Drawing.Point(152, 16);
            this.lblBusca.Name = "lblBusca";
            this.lblBusca.Size = new System.Drawing.Size(40, 13);
            this.lblBusca.TabIndex = 9;
            this.lblBusca.Text = "Buscar";
            // 
            // btnLocalizar
            // 
            this.btnLocalizar.Image = global::UI.Properties.Resources.localizar1;
            this.btnLocalizar.Location = new System.Drawing.Point(586, 21);
            this.btnLocalizar.Name = "btnLocalizar";
            this.btnLocalizar.Size = new System.Drawing.Size(42, 41);
            this.btnLocalizar.TabIndex = 13;
            this.btnLocalizar.UseVisualStyleBackColor = true;
            this.btnLocalizar.Click += new System.EventHandler(this.btnLocalizar_Click);
            // 
            // frmConsultaFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 412);
            this.Controls.Add(this.btnLocalizar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvDados);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.lblBusca);
            this.Name = "frmConsultaFornecedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmConsultaFornecedor";
            this.Load += new System.EventHandler(this.frmConsultaFornecedor_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbConsuktaCPF;
        private System.Windows.Forms.RadioButton rdbConsultaNome;
        private System.Windows.Forms.DataGridView dgvDados;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label lblBusca;
        private System.Windows.Forms.Button btnLocalizar;
    }
}