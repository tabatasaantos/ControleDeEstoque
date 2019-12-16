namespace UI
{
    partial class frmMovimentacaoCompra
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
            this.lblCodCom = new System.Windows.Forms.Label();
            this.lblNFeCom = new System.Windows.Forms.Label();
            this.lblDtCom = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblNParcelas = new System.Windows.Forms.Label();
            this.lblTpaCom = new System.Windows.Forms.Label();
            this.lblDt2Com = new System.Windows.Forms.Label();
            this.lblCodFor = new System.Windows.Forms.Label();
            this.lblNomeFor = new System.Windows.Forms.Label();
            this.txtCodCom = new System.Windows.Forms.TextBox();
            this.txtNFeCom = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtCodFor = new System.Windows.Forms.TextBox();
            this.btnLocalizarFor = new System.Windows.Forms.Button();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.cmbPgto = new System.Windows.Forms.ComboBox();
            this.cmbNParcelas = new System.Windows.Forms.ComboBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dgvItens = new System.Windows.Forms.DataGridView();
            this.proCod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.forNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.forQtd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proValorTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proValorUni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCodPro = new System.Windows.Forms.Label();
            this.txtCodPro = new System.Windows.Forms.TextBox();
            this.btnLocalizarPro = new System.Windows.Forms.Button();
            this.lblNomePro = new System.Windows.Forms.Label();
            this.lblQtd = new System.Windows.Forms.Label();
            this.txtQtd = new System.Windows.Forms.TextBox();
            this.txtValorUni = new System.Windows.Forms.TextBox();
            this.lblValorUni = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblValorSifrao = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnDados.SuspendLayout();
            this.pnButton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens)).BeginInit();
            this.SuspendLayout();
            // 
            // pnDados
            // 
            this.pnDados.Controls.Add(this.label2);
            this.pnDados.Controls.Add(this.lblValorSifrao);
            this.pnDados.Controls.Add(this.btnAdd);
            this.pnDados.Controls.Add(this.lblValorUni);
            this.pnDados.Controls.Add(this.txtValorUni);
            this.pnDados.Controls.Add(this.txtQtd);
            this.pnDados.Controls.Add(this.lblQtd);
            this.pnDados.Controls.Add(this.lblNomePro);
            this.pnDados.Controls.Add(this.btnLocalizarPro);
            this.pnDados.Controls.Add(this.txtCodPro);
            this.pnDados.Controls.Add(this.lblCodPro);
            this.pnDados.Controls.Add(this.label1);
            this.pnDados.Controls.Add(this.dgvItens);
            this.pnDados.Controls.Add(this.dateTimePicker2);
            this.pnDados.Controls.Add(this.cmbNParcelas);
            this.pnDados.Controls.Add(this.cmbPgto);
            this.pnDados.Controls.Add(this.txtTotal);
            this.pnDados.Controls.Add(this.btnLocalizarFor);
            this.pnDados.Controls.Add(this.txtCodFor);
            this.pnDados.Controls.Add(this.dateTimePicker1);
            this.pnDados.Controls.Add(this.txtNFeCom);
            this.pnDados.Controls.Add(this.txtCodCom);
            this.pnDados.Controls.Add(this.lblNomeFor);
            this.pnDados.Controls.Add(this.lblCodFor);
            this.pnDados.Controls.Add(this.lblDt2Com);
            this.pnDados.Controls.Add(this.lblTpaCom);
            this.pnDados.Controls.Add(this.lblNParcelas);
            this.pnDados.Controls.Add(this.lblTotal);
            this.pnDados.Controls.Add(this.lblDtCom);
            this.pnDados.Controls.Add(this.lblNFeCom);
            this.pnDados.Controls.Add(this.lblCodCom);
            this.pnDados.Location = new System.Drawing.Point(3, 4);
            this.pnDados.Size = new System.Drawing.Size(635, 307);
            // 
            // pnButton
            // 
            this.pnButton.Location = new System.Drawing.Point(3, 317);
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
            // lblCodCom
            // 
            this.lblCodCom.AutoSize = true;
            this.lblCodCom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodCom.Location = new System.Drawing.Point(9, 4);
            this.lblCodCom.Name = "lblCodCom";
            this.lblCodCom.Size = new System.Drawing.Size(40, 13);
            this.lblCodCom.TabIndex = 0;
            this.lblCodCom.Text = "Código";
            // 
            // lblNFeCom
            // 
            this.lblNFeCom.AutoSize = true;
            this.lblNFeCom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNFeCom.Location = new System.Drawing.Point(71, 4);
            this.lblNFeCom.Name = "lblNFeCom";
            this.lblNFeCom.Size = new System.Drawing.Size(30, 13);
            this.lblNFeCom.TabIndex = 1;
            this.lblNFeCom.Text = "NF-e";
            // 
            // lblDtCom
            // 
            this.lblDtCom.AutoSize = true;
            this.lblDtCom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDtCom.Location = new System.Drawing.Point(155, 4);
            this.lblDtCom.Name = "lblDtCom";
            this.lblDtCom.Size = new System.Drawing.Size(84, 13);
            this.lblDtCom.TabIndex = 2;
            this.lblDtCom.Text = "Data da Compra";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(491, 265);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(31, 13);
            this.lblTotal.TabIndex = 3;
            this.lblTotal.Text = "Total";
            // 
            // lblNParcelas
            // 
            this.lblNParcelas.AutoSize = true;
            this.lblNParcelas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNParcelas.Location = new System.Drawing.Point(196, 265);
            this.lblNParcelas.Name = "lblNParcelas";
            this.lblNParcelas.Size = new System.Drawing.Size(63, 13);
            this.lblNParcelas.TabIndex = 4;
            this.lblNParcelas.Text = "N° Parcelas";
            // 
            // lblTpaCom
            // 
            this.lblTpaCom.AutoSize = true;
            this.lblTpaCom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTpaCom.Location = new System.Drawing.Point(9, 266);
            this.lblTpaCom.Name = "lblTpaCom";
            this.lblTpaCom.Size = new System.Drawing.Size(85, 13);
            this.lblTpaCom.TabIndex = 5;
            this.lblTpaCom.Text = "Tipo Pagamento";
            // 
            // lblDt2Com
            // 
            this.lblDt2Com.AutoSize = true;
            this.lblDt2Com.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDt2Com.Location = new System.Drawing.Point(312, 265);
            this.lblDt2Com.Name = "lblDt2Com";
            this.lblDt2Com.Size = new System.Drawing.Size(132, 13);
            this.lblDt2Com.TabIndex = 6;
            this.lblDt2Com.Text = "Data Inicial do Pagamento";
            // 
            // lblCodFor
            // 
            this.lblCodFor.AutoSize = true;
            this.lblCodFor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodFor.Location = new System.Drawing.Point(245, 4);
            this.lblCodFor.Name = "lblCodFor";
            this.lblCodFor.Size = new System.Drawing.Size(97, 13);
            this.lblCodFor.TabIndex = 7;
            this.lblCodFor.Text = "Código Fornecedor";
            // 
            // lblNomeFor
            // 
            this.lblNomeFor.AutoSize = true;
            this.lblNomeFor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeFor.Location = new System.Drawing.Point(322, 45);
            this.lblNomeFor.Name = "lblNomeFor";
            this.lblNomeFor.Size = new System.Drawing.Size(263, 13);
            this.lblNomeFor.TabIndex = 8;
            this.lblNomeFor.Text = "Informe o código do fornecedor ou clique em Localizar";
            // 
            // txtCodCom
            // 
            this.txtCodCom.Enabled = false;
            this.txtCodCom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodCom.Location = new System.Drawing.Point(9, 20);
            this.txtCodCom.Name = "txtCodCom";
            this.txtCodCom.Size = new System.Drawing.Size(54, 20);
            this.txtCodCom.TabIndex = 9;
            // 
            // txtNFeCom
            // 
            this.txtNFeCom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNFeCom.Location = new System.Drawing.Point(74, 20);
            this.txtNFeCom.Name = "txtNFeCom";
            this.txtNFeCom.Size = new System.Drawing.Size(70, 20);
            this.txtNFeCom.TabIndex = 10;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(158, 21);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(81, 20);
            this.dateTimePicker1.TabIndex = 11;
            // 
            // txtCodFor
            // 
            this.txtCodFor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodFor.Location = new System.Drawing.Point(248, 21);
            this.txtCodFor.Name = "txtCodFor";
            this.txtCodFor.Size = new System.Drawing.Size(65, 20);
            this.txtCodFor.TabIndex = 12;
            this.txtCodFor.Leave += new System.EventHandler(this.txtCodFor_Leave);
            // 
            // btnLocalizarFor
            // 
            this.btnLocalizarFor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLocalizarFor.Location = new System.Drawing.Point(319, 19);
            this.btnLocalizarFor.Name = "btnLocalizarFor";
            this.btnLocalizarFor.Size = new System.Drawing.Size(100, 23);
            this.btnLocalizarFor.TabIndex = 13;
            this.btnLocalizarFor.Text = "Localizar";
            this.btnLocalizarFor.UseVisualStyleBackColor = true;
            this.btnLocalizarFor.Click += new System.EventHandler(this.btnLocalizarFor_Click);
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(494, 281);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(131, 20);
            this.txtTotal.TabIndex = 14;
            // 
            // cmbPgto
            // 
            this.cmbPgto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPgto.FormattingEnabled = true;
            this.cmbPgto.Location = new System.Drawing.Point(12, 282);
            this.cmbPgto.Name = "cmbPgto";
            this.cmbPgto.Size = new System.Drawing.Size(159, 21);
            this.cmbPgto.TabIndex = 15;
            // 
            // cmbNParcelas
            // 
            this.cmbNParcelas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbNParcelas.FormattingEnabled = true;
            this.cmbNParcelas.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cmbNParcelas.Location = new System.Drawing.Point(199, 281);
            this.cmbNParcelas.Name = "cmbNParcelas";
            this.cmbNParcelas.Size = new System.Drawing.Size(100, 21);
            this.cmbNParcelas.TabIndex = 16;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(315, 281);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(129, 20);
            this.dateTimePicker2.TabIndex = 17;
            // 
            // dgvItens
            // 
            this.dgvItens.AllowUserToAddRows = false;
            this.dgvItens.AllowUserToDeleteRows = false;
            this.dgvItens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItens.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.proCod,
            this.forNome,
            this.forQtd,
            this.proValorTotal,
            this.proValorUni});
            this.dgvItens.Location = new System.Drawing.Point(12, 131);
            this.dgvItens.Name = "dgvItens";
            this.dgvItens.ReadOnly = true;
            this.dgvItens.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvItens.Size = new System.Drawing.Size(613, 131);
            this.dgvItens.TabIndex = 18;
            this.dgvItens.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvItens_CellDoubleClick);
            // 
            // proCod
            // 
            this.proCod.HeaderText = "Codigo";
            this.proCod.Name = "proCod";
            this.proCod.ReadOnly = true;
            this.proCod.Width = 60;
            // 
            // forNome
            // 
            this.forNome.HeaderText = "Nome";
            this.forNome.Name = "forNome";
            this.forNome.ReadOnly = true;
            this.forNome.Width = 220;
            // 
            // forQtd
            // 
            this.forQtd.HeaderText = "Quandidade";
            this.forQtd.Name = "forQtd";
            this.forQtd.ReadOnly = true;
            // 
            // proValorTotal
            // 
            this.proValorTotal.HeaderText = "ValorTotal";
            this.proValorTotal.Name = "proValorTotal";
            this.proValorTotal.ReadOnly = true;
            // 
            // proValorUni
            // 
            this.proValorUni.HeaderText = "ValorUnitario";
            this.proValorUni.Name = "proValorUni";
            this.proValorUni.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(616, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "_________________________________________________________________________________" +
    "______";
            // 
            // lblCodPro
            // 
            this.lblCodPro.AutoSize = true;
            this.lblCodPro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodPro.Location = new System.Drawing.Point(9, 88);
            this.lblCodPro.Name = "lblCodPro";
            this.lblCodPro.Size = new System.Drawing.Size(80, 13);
            this.lblCodPro.TabIndex = 20;
            this.lblCodPro.Text = "Código Produto";
            // 
            // txtCodPro
            // 
            this.txtCodPro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodPro.Location = new System.Drawing.Point(12, 104);
            this.txtCodPro.Name = "txtCodPro";
            this.txtCodPro.Size = new System.Drawing.Size(51, 20);
            this.txtCodPro.TabIndex = 21;
            this.txtCodPro.Leave += new System.EventHandler(this.txtCodPro_Leave);
            // 
            // btnLocalizarPro
            // 
            this.btnLocalizarPro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLocalizarPro.Location = new System.Drawing.Point(74, 102);
            this.btnLocalizarPro.Name = "btnLocalizarPro";
            this.btnLocalizarPro.Size = new System.Drawing.Size(100, 23);
            this.btnLocalizarPro.TabIndex = 22;
            this.btnLocalizarPro.Text = "Localizar";
            this.btnLocalizarPro.UseVisualStyleBackColor = true;
            this.btnLocalizarPro.Click += new System.EventHandler(this.btnLocalizarPro_Click);
            // 
            // lblNomePro
            // 
            this.lblNomePro.AutoSize = true;
            this.lblNomePro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomePro.Location = new System.Drawing.Point(180, 107);
            this.lblNomePro.Name = "lblNomePro";
            this.lblNomePro.Size = new System.Drawing.Size(248, 13);
            this.lblNomePro.TabIndex = 23;
            this.lblNomePro.Text = "Informe o código do produto ou clique em Localizar";
            // 
            // lblQtd
            // 
            this.lblQtd.AutoSize = true;
            this.lblQtd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQtd.Location = new System.Drawing.Point(436, 88);
            this.lblQtd.Name = "lblQtd";
            this.lblQtd.Size = new System.Drawing.Size(62, 13);
            this.lblQtd.TabIndex = 24;
            this.lblQtd.Text = "Quantidade";
            // 
            // txtQtd
            // 
            this.txtQtd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQtd.Location = new System.Drawing.Point(439, 104);
            this.txtQtd.Name = "txtQtd";
            this.txtQtd.Size = new System.Drawing.Size(54, 20);
            this.txtQtd.TabIndex = 25;
            // 
            // txtValorUni
            // 
            this.txtValorUni.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorUni.Location = new System.Drawing.Point(525, 104);
            this.txtValorUni.Name = "txtValorUni";
            this.txtValorUni.Size = new System.Drawing.Size(60, 20);
            this.txtValorUni.TabIndex = 26;
            // 
            // lblValorUni
            // 
            this.lblValorUni.AutoSize = true;
            this.lblValorUni.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorUni.Location = new System.Drawing.Point(504, 88);
            this.lblValorUni.Name = "lblValorUni";
            this.lblValorUni.Size = new System.Drawing.Size(70, 13);
            this.lblValorUni.TabIndex = 27;
            this.lblValorUni.Text = "Valor Unitário";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(593, 102);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(32, 23);
            this.btnAdd.TabIndex = 28;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblValorSifrao
            // 
            this.lblValorSifrao.AutoSize = true;
            this.lblValorSifrao.Location = new System.Drawing.Point(470, 284);
            this.lblValorSifrao.Name = "lblValorSifrao";
            this.lblValorSifrao.Size = new System.Drawing.Size(23, 13);
            this.lblValorSifrao.TabIndex = 29;
            this.lblValorSifrao.Text = "R$";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(499, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "R$";
            // 
            // frmMovimentacaoCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(640, 412);
            this.Name = "frmMovimentacaoCompra";
            this.Text = "Movimentação - Formulário de Compra";
            this.Load += new System.EventHandler(this.frmMovimentacaoCompra_Load);
            this.pnDados.ResumeLayout(false);
            this.pnDados.PerformLayout();
            this.pnButton.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblCodCom;
        private System.Windows.Forms.DataGridView dgvItens;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.ComboBox cmbNParcelas;
        private System.Windows.Forms.ComboBox cmbPgto;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Button btnLocalizarFor;
        private System.Windows.Forms.TextBox txtCodFor;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtNFeCom;
        private System.Windows.Forms.TextBox txtCodCom;
        private System.Windows.Forms.Label lblNomeFor;
        private System.Windows.Forms.Label lblCodFor;
        private System.Windows.Forms.Label lblDt2Com;
        private System.Windows.Forms.Label lblTpaCom;
        private System.Windows.Forms.Label lblNParcelas;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblDtCom;
        private System.Windows.Forms.Label lblNFeCom;
        private System.Windows.Forms.Button btnLocalizarPro;
        private System.Windows.Forms.TextBox txtCodPro;
        private System.Windows.Forms.Label lblCodPro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblValorUni;
        private System.Windows.Forms.TextBox txtValorUni;
        private System.Windows.Forms.TextBox txtQtd;
        private System.Windows.Forms.Label lblQtd;
        private System.Windows.Forms.Label lblNomePro;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn proCod;
        private System.Windows.Forms.DataGridViewTextBoxColumn forNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn forQtd;
        private System.Windows.Forms.DataGridViewTextBoxColumn proValorTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn proValorUni;
        private System.Windows.Forms.Label lblValorSifrao;
        private System.Windows.Forms.Label label2;
    }
}
