namespace UI
{
    partial class frmCadastroUnidadeDeMedida
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblCodUmed = new System.Windows.Forms.Label();
            this.lblUmed = new System.Windows.Forms.Label();
            this.txtCodUmed = new System.Windows.Forms.TextBox();
            this.txtUmed = new System.Windows.Forms.TextBox();
            this.pnDados.SuspendLayout();
            this.pnButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnDados
            // 
            this.pnDados.Controls.Add(this.txtUmed);
            this.pnDados.Controls.Add(this.txtCodUmed);
            this.pnDados.Controls.Add(this.lblUmed);
            this.pnDados.Controls.Add(this.lblCodUmed);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnLocalizar
            // 
            this.btnLocalizar.Click += new System.EventHandler(this.btnLocalizar_Click_1);
            // 
            // btnInserir
            // 
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // lblCodUmed
            // 
            this.lblCodUmed.AutoSize = true;
            this.lblCodUmed.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodUmed.Location = new System.Drawing.Point(18, 17);
            this.lblCodUmed.Name = "lblCodUmed";
            this.lblCodUmed.Size = new System.Drawing.Size(40, 13);
            this.lblCodUmed.TabIndex = 0;
            this.lblCodUmed.Text = "Código";
            // 
            // lblUmed
            // 
            this.lblUmed.AutoSize = true;
            this.lblUmed.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUmed.Location = new System.Drawing.Point(18, 65);
            this.lblUmed.Name = "lblUmed";
            this.lblUmed.Size = new System.Drawing.Size(100, 13);
            this.lblUmed.TabIndex = 1;
            this.lblUmed.Text = "Unidade de Medida";
            // 
            // txtCodUmed
            // 
            this.txtCodUmed.Enabled = false;
            this.txtCodUmed.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodUmed.Location = new System.Drawing.Point(21, 33);
            this.txtCodUmed.Name = "txtCodUmed";
            this.txtCodUmed.Size = new System.Drawing.Size(100, 20);
            this.txtCodUmed.TabIndex = 2;
            // 
            // txtUmed
            // 
            this.txtUmed.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUmed.Location = new System.Drawing.Point(21, 81);
            this.txtUmed.Name = "txtUmed";
            this.txtUmed.Size = new System.Drawing.Size(593, 20);
            this.txtUmed.TabIndex = 3;
            this.txtUmed.Leave += new System.EventHandler(this.txtUmed_Leave);
            // 
            // frmCadastroUnidadeDeMedida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(640, 412);
            this.Name = "frmCadastroUnidadeDeMedida";
            this.Text = "Cadastro Unidade de Medida";
            this.pnDados.ResumeLayout(false);
            this.pnDados.PerformLayout();
            this.pnButton.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtUmed;
        private System.Windows.Forms.TextBox txtCodUmed;
        private System.Windows.Forms.Label lblUmed;
        private System.Windows.Forms.Label lblCodUmed;
    }
}
