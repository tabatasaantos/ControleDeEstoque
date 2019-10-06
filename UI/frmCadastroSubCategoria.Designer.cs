namespace UI
{
    partial class frmCadastroSubCategoria
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
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblNomeSubCat = new System.Windows.Forms.Label();
            this.cbNomeCat = new System.Windows.Forms.ComboBox();
            this.lblNomeCat = new System.Windows.Forms.Label();
            this.txtCodigoSubCat = new System.Windows.Forms.TextBox();
            this.txtNomeSubCat = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.pnDados.SuspendLayout();
            this.pnButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnDados
            // 
            this.pnDados.Controls.Add(this.btnAdd);
            this.pnDados.Controls.Add(this.txtNomeSubCat);
            this.pnDados.Controls.Add(this.txtCodigoSubCat);
            this.pnDados.Controls.Add(this.lblNomeCat);
            this.pnDados.Controls.Add(this.cbNomeCat);
            this.pnDados.Controls.Add(this.lblNomeSubCat);
            this.pnDados.Controls.Add(this.lblCodigo);
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
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(27, 25);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(40, 13);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Código";
            // 
            // lblNomeSubCat
            // 
            this.lblNomeSubCat.AutoSize = true;
            this.lblNomeSubCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeSubCat.Location = new System.Drawing.Point(27, 78);
            this.lblNomeSubCat.Name = "lblNomeSubCat";
            this.lblNomeSubCat.Size = new System.Drawing.Size(117, 13);
            this.lblNomeSubCat.TabIndex = 1;
            this.lblNomeSubCat.Text = "Nome da SubCategoria";
            // 
            // cbNomeCat
            // 
            this.cbNomeCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNomeCat.FormattingEnabled = true;
            this.cbNomeCat.Location = new System.Drawing.Point(27, 148);
            this.cbNomeCat.Name = "cbNomeCat";
            this.cbNomeCat.Size = new System.Drawing.Size(422, 21);
            this.cbNomeCat.TabIndex = 2;
            // 
            // lblNomeCat
            // 
            this.lblNomeCat.AutoSize = true;
            this.lblNomeCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeCat.Location = new System.Drawing.Point(24, 132);
            this.lblNomeCat.Name = "lblNomeCat";
            this.lblNomeCat.Size = new System.Drawing.Size(98, 13);
            this.lblNomeCat.TabIndex = 3;
            this.lblNomeCat.Text = "Nome da Categoria";
            // 
            // txtCodigoSubCat
            // 
            this.txtCodigoSubCat.Enabled = false;
            this.txtCodigoSubCat.Location = new System.Drawing.Point(27, 41);
            this.txtCodigoSubCat.Name = "txtCodigoSubCat";
            this.txtCodigoSubCat.Size = new System.Drawing.Size(100, 20);
            this.txtCodigoSubCat.TabIndex = 4;
            // 
            // txtNomeSubCat
            // 
            this.txtNomeSubCat.Location = new System.Drawing.Point(27, 94);
            this.txtNomeSubCat.Name = "txtNomeSubCat";
            this.txtNomeSubCat.Size = new System.Drawing.Size(422, 20);
            this.txtNomeSubCat.TabIndex = 5;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(455, 146);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(22, 23);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // frmCadastroSubCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(640, 412);
            this.Name = "frmCadastroSubCategoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de SubCategoria";
            this.Load += new System.EventHandler(this.frmCadastroSubCategoria_Load);
            this.pnDados.ResumeLayout(false);
            this.pnDados.PerformLayout();
            this.pnButton.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtNomeSubCat;
        private System.Windows.Forms.TextBox txtCodigoSubCat;
        private System.Windows.Forms.Label lblNomeCat;
        private System.Windows.Forms.ComboBox cbNomeCat;
        private System.Windows.Forms.Label lblNomeSubCat;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Button btnAdd;
    }
}
