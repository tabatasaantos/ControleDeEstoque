namespace UI
{
    partial class frmCadastroTipoDePagamento
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
            this.lblCódigoTP = new System.Windows.Forms.Label();
            this.lblTipoPagamento = new System.Windows.Forms.Label();
            this.txtCodigoTP = new System.Windows.Forms.TextBox();
            this.txtTipoPagamento = new System.Windows.Forms.TextBox();
            this.pnDados.SuspendLayout();
            this.pnButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnDados
            // 
            this.pnDados.Controls.Add(this.txtTipoPagamento);
            this.pnDados.Controls.Add(this.txtCodigoTP);
            this.pnDados.Controls.Add(this.lblTipoPagamento);
            this.pnDados.Controls.Add(this.lblCódigoTP);
            // 
            // btnCalcelar
            // 
            this.btnCalcelar.Click += new System.EventHandler(this.btnCalcelar_Click);
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
            this.btnLocalizar.Click += new System.EventHandler(this.btnLocalizar_Click);
            // 
            // btnInserir
            // 
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // lblCódigoTP
            // 
            this.lblCódigoTP.AutoSize = true;
            this.lblCódigoTP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCódigoTP.Location = new System.Drawing.Point(18, 27);
            this.lblCódigoTP.Name = "lblCódigoTP";
            this.lblCódigoTP.Size = new System.Drawing.Size(40, 13);
            this.lblCódigoTP.TabIndex = 0;
            this.lblCódigoTP.Text = "Código";
            // 
            // lblTipoPagamento
            // 
            this.lblTipoPagamento.AutoSize = true;
            this.lblTipoPagamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoPagamento.Location = new System.Drawing.Point(18, 96);
            this.lblTipoPagamento.Name = "lblTipoPagamento";
            this.lblTipoPagamento.Size = new System.Drawing.Size(100, 13);
            this.lblTipoPagamento.TabIndex = 1;
            this.lblTipoPagamento.Text = "Tipo de Pagamento";
            // 
            // txtCodigoTP
            // 
            this.txtCodigoTP.Location = new System.Drawing.Point(21, 43);
            this.txtCodigoTP.Name = "txtCodigoTP";
            this.txtCodigoTP.ReadOnly = true;
            this.txtCodigoTP.Size = new System.Drawing.Size(100, 20);
            this.txtCodigoTP.TabIndex = 2;
            // 
            // txtTipoPagamento
            // 
            this.txtTipoPagamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTipoPagamento.Location = new System.Drawing.Point(21, 112);
            this.txtTipoPagamento.Name = "txtTipoPagamento";
            this.txtTipoPagamento.Size = new System.Drawing.Size(286, 20);
            this.txtTipoPagamento.TabIndex = 3;
            // 
            // frmCadastroTipoDePagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(640, 412);
            this.Name = "frmCadastroTipoDePagamento";
            this.Text = "Cadastro de Tipo de Pagamento";
            this.Load += new System.EventHandler(this.frmCadastroTipoDePagamento_Load);
            this.pnDados.ResumeLayout(false);
            this.pnDados.PerformLayout();
            this.pnButton.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtTipoPagamento;
        private System.Windows.Forms.TextBox txtCodigoTP;
        private System.Windows.Forms.Label lblTipoPagamento;
        private System.Windows.Forms.Label lblCódigoTP;
    }
}
