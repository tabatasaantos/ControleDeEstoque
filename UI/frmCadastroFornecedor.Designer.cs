namespace UI
{
    partial class frmCadastroFornecedor
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
            this.lblValorInvalido = new System.Windows.Forms.Label();
            this.mskCelular = new System.Windows.Forms.MaskedTextBox();
            this.mskTelefone = new System.Windows.Forms.MaskedTextBox();
            this.lblCelular = new System.Windows.Forms.Label();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblBairro = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.txtRua = new System.Windows.Forms.TextBox();
            this.lblNumero = new System.Windows.Forms.Label();
            this.lblRua = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.lblCidade = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.txtCEP = new System.Windows.Forms.TextBox();
            this.lblCEP = new System.Windows.Forms.Label();
            this.txtIE = new System.Windows.Forms.TextBox();
            this.lblIE = new System.Windows.Forms.Label();
            this.txtRSocial = new System.Windows.Forms.TextBox();
            this.lblRazaoFor = new System.Windows.Forms.Label();
            this.txtNomeFor = new System.Windows.Forms.TextBox();
            this.lblNomeFor = new System.Windows.Forms.Label();
            this.lblCodFornecedor = new System.Windows.Forms.Label();
            this.txtCodFornecedor = new System.Windows.Forms.TextBox();
            this.lblCNPJ = new System.Windows.Forms.Label();
            this.txtCNPJ = new System.Windows.Forms.TextBox();
            this.pnDados.SuspendLayout();
            this.pnButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnDados
            // 
            this.pnDados.Controls.Add(this.lblValorInvalido);
            this.pnDados.Controls.Add(this.mskCelular);
            this.pnDados.Controls.Add(this.mskTelefone);
            this.pnDados.Controls.Add(this.lblCelular);
            this.pnDados.Controls.Add(this.lblTelefone);
            this.pnDados.Controls.Add(this.txtEmail);
            this.pnDados.Controls.Add(this.txtBairro);
            this.pnDados.Controls.Add(this.lblEmail);
            this.pnDados.Controls.Add(this.lblBairro);
            this.pnDados.Controls.Add(this.txtNumero);
            this.pnDados.Controls.Add(this.txtRua);
            this.pnDados.Controls.Add(this.lblNumero);
            this.pnDados.Controls.Add(this.lblRua);
            this.pnDados.Controls.Add(this.txtCidade);
            this.pnDados.Controls.Add(this.lblCidade);
            this.pnDados.Controls.Add(this.lblEstado);
            this.pnDados.Controls.Add(this.txtEstado);
            this.pnDados.Controls.Add(this.txtCEP);
            this.pnDados.Controls.Add(this.lblCEP);
            this.pnDados.Controls.Add(this.txtIE);
            this.pnDados.Controls.Add(this.txtCNPJ);
            this.pnDados.Controls.Add(this.lblIE);
            this.pnDados.Controls.Add(this.lblCNPJ);
            this.pnDados.Controls.Add(this.txtRSocial);
            this.pnDados.Controls.Add(this.lblRazaoFor);
            this.pnDados.Controls.Add(this.txtNomeFor);
            this.pnDados.Controls.Add(this.lblNomeFor);
            this.pnDados.Controls.Add(this.lblCodFornecedor);
            this.pnDados.Controls.Add(this.txtCodFornecedor);
            this.pnDados.Size = new System.Drawing.Size(635, 299);
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
            // lblValorInvalido
            // 
            this.lblValorInvalido.AutoSize = true;
            this.lblValorInvalido.BackColor = System.Drawing.Color.Transparent;
            this.lblValorInvalido.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorInvalido.ForeColor = System.Drawing.Color.Red;
            this.lblValorInvalido.Location = new System.Drawing.Point(202, 125);
            this.lblValorInvalido.Name = "lblValorInvalido";
            this.lblValorInvalido.Size = new System.Drawing.Size(71, 13);
            this.lblValorInvalido.TabIndex = 59;
            this.lblValorInvalido.Text = "Valor Inválido";
            this.lblValorInvalido.Visible = false;
            // 
            // mskCelular
            // 
            this.mskCelular.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskCelular.Location = new System.Drawing.Point(118, 259);
            this.mskCelular.Mask = "(99) 00000-0000";
            this.mskCelular.Name = "mskCelular";
            this.mskCelular.Size = new System.Drawing.Size(100, 20);
            this.mskCelular.TabIndex = 55;
            // 
            // mskTelefone
            // 
            this.mskTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskTelefone.Location = new System.Drawing.Point(12, 259);
            this.mskTelefone.Mask = "(99) 0000-0000";
            this.mskTelefone.Name = "mskTelefone";
            this.mskTelefone.Size = new System.Drawing.Size(100, 20);
            this.mskTelefone.TabIndex = 54;
            // 
            // lblCelular
            // 
            this.lblCelular.AutoSize = true;
            this.lblCelular.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCelular.Location = new System.Drawing.Point(115, 244);
            this.lblCelular.Name = "lblCelular";
            this.lblCelular.Size = new System.Drawing.Size(39, 13);
            this.lblCelular.TabIndex = 58;
            this.lblCelular.Text = "Celular";
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefone.Location = new System.Drawing.Point(8, 244);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(49, 13);
            this.lblTelefone.TabIndex = 57;
            this.lblTelefone.Text = "Telefone";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(222, 259);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(371, 20);
            this.txtEmail.TabIndex = 56;
            // 
            // txtBairro
            // 
            this.txtBairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBairro.Location = new System.Drawing.Point(326, 222);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(183, 20);
            this.txtBairro.TabIndex = 53;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(219, 243);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEmail.TabIndex = 34;
            this.lblEmail.Text = "E-mail";
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBairro.Location = new System.Drawing.Point(321, 205);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(34, 13);
            this.lblBairro.TabIndex = 52;
            this.lblBairro.Text = "Bairro";
            // 
            // txtNumero
            // 
            this.txtNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumero.Location = new System.Drawing.Point(515, 222);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(78, 20);
            this.txtNumero.TabIndex = 51;
            // 
            // txtRua
            // 
            this.txtRua.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRua.Location = new System.Drawing.Point(11, 222);
            this.txtRua.Name = "txtRua";
            this.txtRua.Size = new System.Drawing.Size(309, 20);
            this.txtRua.TabIndex = 50;
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumero.Location = new System.Drawing.Point(512, 205);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(44, 13);
            this.lblNumero.TabIndex = 49;
            this.lblNumero.Text = "Número";
            // 
            // lblRua
            // 
            this.lblRua.AutoSize = true;
            this.lblRua.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRua.Location = new System.Drawing.Point(9, 205);
            this.lblRua.Name = "lblRua";
            this.lblRua.Size = new System.Drawing.Size(27, 13);
            this.lblRua.TabIndex = 48;
            this.lblRua.Text = "Rua";
            // 
            // txtCidade
            // 
            this.txtCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCidade.Location = new System.Drawing.Point(153, 182);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(283, 20);
            this.txtCidade.TabIndex = 47;
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCidade.Location = new System.Drawing.Point(154, 166);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(40, 13);
            this.lblCidade.TabIndex = 46;
            this.lblCidade.Text = "Cidade";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Location = new System.Drawing.Point(439, 166);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(40, 13);
            this.lblEstado.TabIndex = 45;
            this.lblEstado.Text = "Estado";
            // 
            // txtEstado
            // 
            this.txtEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEstado.Location = new System.Drawing.Point(442, 182);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(151, 20);
            this.txtEstado.TabIndex = 44;
            // 
            // txtCEP
            // 
            this.txtCEP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCEP.Location = new System.Drawing.Point(12, 182);
            this.txtCEP.Name = "txtCEP";
            this.txtCEP.Size = new System.Drawing.Size(135, 20);
            this.txtCEP.TabIndex = 43;
            this.txtCEP.Leave += new System.EventHandler(this.txtCEP_Leave);
            // 
            // lblCEP
            // 
            this.lblCEP.AutoSize = true;
            this.lblCEP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCEP.Location = new System.Drawing.Point(9, 166);
            this.lblCEP.Name = "lblCEP";
            this.lblCEP.Size = new System.Drawing.Size(28, 13);
            this.lblCEP.TabIndex = 42;
            this.lblCEP.Text = "CEP";
            // 
            // txtIE
            // 
            this.txtIE.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIE.Location = new System.Drawing.Point(299, 141);
            this.txtIE.Name = "txtIE";
            this.txtIE.Size = new System.Drawing.Size(294, 20);
            this.txtIE.TabIndex = 41;
            // 
            // lblIE
            // 
            this.lblIE.AutoSize = true;
            this.lblIE.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIE.Location = new System.Drawing.Point(296, 123);
            this.lblIE.Name = "lblIE";
            this.lblIE.Size = new System.Drawing.Size(17, 13);
            this.lblIE.TabIndex = 39;
            this.lblIE.Text = "IE";
            // 
            // txtRSocial
            // 
            this.txtRSocial.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRSocial.Location = new System.Drawing.Point(11, 100);
            this.txtRSocial.Name = "txtRSocial";
            this.txtRSocial.Size = new System.Drawing.Size(582, 20);
            this.txtRSocial.TabIndex = 37;
            // 
            // lblRazaoFor
            // 
            this.lblRazaoFor.AutoSize = true;
            this.lblRazaoFor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRazaoFor.Location = new System.Drawing.Point(8, 83);
            this.lblRazaoFor.Name = "lblRazaoFor";
            this.lblRazaoFor.Size = new System.Drawing.Size(70, 13);
            this.lblRazaoFor.TabIndex = 36;
            this.lblRazaoFor.Text = "Razão Social";
            // 
            // txtNomeFor
            // 
            this.txtNomeFor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeFor.Location = new System.Drawing.Point(11, 56);
            this.txtNomeFor.Name = "txtNomeFor";
            this.txtNomeFor.Size = new System.Drawing.Size(582, 20);
            this.txtNomeFor.TabIndex = 35;
            // 
            // lblNomeFor
            // 
            this.lblNomeFor.AutoSize = true;
            this.lblNomeFor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeFor.Location = new System.Drawing.Point(8, 40);
            this.lblNomeFor.Name = "lblNomeFor";
            this.lblNomeFor.Size = new System.Drawing.Size(35, 13);
            this.lblNomeFor.TabIndex = 33;
            this.lblNomeFor.Text = "Nome";
            // 
            // lblCodFornecedor
            // 
            this.lblCodFornecedor.AutoSize = true;
            this.lblCodFornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodFornecedor.Location = new System.Drawing.Point(9, 1);
            this.lblCodFornecedor.Name = "lblCodFornecedor";
            this.lblCodFornecedor.Size = new System.Drawing.Size(40, 13);
            this.lblCodFornecedor.TabIndex = 32;
            this.lblCodFornecedor.Text = "Código";
            // 
            // txtCodFornecedor
            // 
            this.txtCodFornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodFornecedor.Location = new System.Drawing.Point(12, 17);
            this.txtCodFornecedor.Name = "txtCodFornecedor";
            this.txtCodFornecedor.ReadOnly = true;
            this.txtCodFornecedor.Size = new System.Drawing.Size(135, 20);
            this.txtCodFornecedor.TabIndex = 31;
            // 
            // lblCNPJ
            // 
            this.lblCNPJ.AutoSize = true;
            this.lblCNPJ.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCNPJ.Location = new System.Drawing.Point(8, 125);
            this.lblCNPJ.Name = "lblCNPJ";
            this.lblCNPJ.Size = new System.Drawing.Size(34, 13);
            this.lblCNPJ.TabIndex = 38;
            this.lblCNPJ.Text = "CNPJ";
            // 
            // txtCNPJ
            // 
            this.txtCNPJ.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCNPJ.Location = new System.Drawing.Point(11, 141);
            this.txtCNPJ.Name = "txtCNPJ";
            this.txtCNPJ.Size = new System.Drawing.Size(282, 20);
            this.txtCNPJ.TabIndex = 40;
            this.txtCNPJ.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCNPJ_KeyPress);
            this.txtCNPJ.Leave += new System.EventHandler(this.txtCNPJ_Leave);
            // 
            // frmCadastroFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(640, 412);
            this.Name = "frmCadastroFornecedor";
            this.pnDados.ResumeLayout(false);
            this.pnDados.PerformLayout();
            this.pnButton.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblValorInvalido;
        private System.Windows.Forms.MaskedTextBox mskCelular;
        private System.Windows.Forms.MaskedTextBox mskTelefone;
        private System.Windows.Forms.Label lblCelular;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.TextBox txtRua;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Label lblRua;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.TextBox txtCEP;
        private System.Windows.Forms.Label lblCEP;
        private System.Windows.Forms.TextBox txtIE;
        private System.Windows.Forms.Label lblIE;
        private System.Windows.Forms.TextBox txtRSocial;
        private System.Windows.Forms.Label lblRazaoFor;
        private System.Windows.Forms.TextBox txtNomeFor;
        private System.Windows.Forms.Label lblNomeFor;
        private System.Windows.Forms.Label lblCodFornecedor;
        private System.Windows.Forms.TextBox txtCodFornecedor;
        private System.Windows.Forms.TextBox txtCNPJ;
        private System.Windows.Forms.Label lblCNPJ;
    }
}
