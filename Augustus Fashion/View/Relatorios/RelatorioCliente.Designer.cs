
namespace Augustus_Fashion.View.Relatorios
{
    partial class RelatorioCliente
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
            this.dgvCliente = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.cbFiltrosSimples = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbFiltrosAvancados = new System.Windows.Forms.ComboBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hOMEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fECHARToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mtDataFinal = new System.Windows.Forms.MaskedTextBox();
            this.mtDataInicial = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnData = new System.Windows.Forms.Button();
            this.btnValor = new System.Windows.Forms.Button();
            this.txtValor1 = new System.Windows.Forms.TextBox();
            this.txtValor2 = new System.Windows.Forms.TextBox();
            this.btnBuscar2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvCliente
            // 
            this.dgvCliente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCliente.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCliente.GridColor = System.Drawing.SystemColors.Control;
            this.dgvCliente.Location = new System.Drawing.Point(0, 113);
            this.dgvCliente.Name = "dgvCliente";
            this.dgvCliente.ReadOnly = true;
            this.dgvCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCliente.Size = new System.Drawing.Size(758, 237);
            this.dgvCliente.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(12, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Filtros Simples:";
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.BackColor = System.Drawing.Color.PaleGreen;
            this.btnFiltrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnFiltrar.Location = new System.Drawing.Point(444, 33);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(87, 37);
            this.btnFiltrar.TabIndex = 3;
            this.btnFiltrar.Text = "FILTRAR";
            this.btnFiltrar.UseVisualStyleBackColor = false;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // cbFiltrosSimples
            // 
            this.cbFiltrosSimples.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFiltrosSimples.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbFiltrosSimples.FormattingEnabled = true;
            this.cbFiltrosSimples.Items.AddRange(new object[] {
            "Qtde Pedidos Crescente",
            "Qtde Pedidos Descrescente",
            "Total Liquido Crescente",
            "Total Liquido Decrescente",
            "Desconto Crescente",
            "Desconto Decrescente"});
            this.cbFiltrosSimples.Location = new System.Drawing.Point(157, 38);
            this.cbFiltrosSimples.Name = "cbFiltrosSimples";
            this.cbFiltrosSimples.Size = new System.Drawing.Size(254, 28);
            this.cbFiltrosSimples.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(12, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Filtros Avançados:";
            // 
            // cbFiltrosAvancados
            // 
            this.cbFiltrosAvancados.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFiltrosAvancados.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbFiltrosAvancados.FormattingEnabled = true;
            this.cbFiltrosAvancados.Items.AddRange(new object[] {
            "5 Clientes que Mais Compraram",
            "5 Clientes que Menos Compraram",
            "5 Clientes que Mais Gastaram",
            "5 Clientes que Menos Gastaram"});
            this.cbFiltrosAvancados.Location = new System.Drawing.Point(157, 79);
            this.cbFiltrosAvancados.Name = "cbFiltrosAvancados";
            this.cbFiltrosAvancados.Size = new System.Drawing.Size(254, 28);
            this.cbFiltrosAvancados.TabIndex = 6;
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.Snow;
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnLimpar.Location = new System.Drawing.Point(444, 74);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(87, 37);
            this.btnLimpar.TabIndex = 7;
            this.btnLimpar.Text = "LIMPAR";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hOMEToolStripMenuItem,
            this.fECHARToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(758, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hOMEToolStripMenuItem
            // 
            this.hOMEToolStripMenuItem.Name = "hOMEToolStripMenuItem";
            this.hOMEToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.hOMEToolStripMenuItem.Text = "HOME";
            this.hOMEToolStripMenuItem.Click += new System.EventHandler(this.hOMEToolStripMenuItem_Click);
            // 
            // fECHARToolStripMenuItem
            // 
            this.fECHARToolStripMenuItem.Name = "fECHARToolStripMenuItem";
            this.fECHARToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.fECHARToolStripMenuItem.Text = "FECHAR";
            this.fECHARToolStripMenuItem.Click += new System.EventHandler(this.fECHARToolStripMenuItem_Click);
            // 
            // mtDataFinal
            // 
            this.mtDataFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.mtDataFinal.Location = new System.Drawing.Point(658, 40);
            this.mtDataFinal.Mask = "00/00/0000";
            this.mtDataFinal.Name = "mtDataFinal";
            this.mtDataFinal.Size = new System.Drawing.Size(89, 26);
            this.mtDataFinal.TabIndex = 9;
            this.mtDataFinal.Visible = false;
            // 
            // mtDataInicial
            // 
            this.mtDataInicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.mtDataInicial.Location = new System.Drawing.Point(539, 40);
            this.mtDataInicial.Mask = "00/00/0000";
            this.mtDataInicial.Name = "mtDataInicial";
            this.mtDataInicial.Size = new System.Drawing.Size(89, 26);
            this.mtDataInicial.TabIndex = 11;
            this.mtDataInicial.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(634, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "e";
            this.label4.Visible = false;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.PapayaWhip;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnBuscar.Location = new System.Drawing.Point(600, 71);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(86, 35);
            this.btnBuscar.TabIndex = 13;
            this.btnBuscar.Text = "BUSCAR";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Visible = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnData
            // 
            this.btnData.BackColor = System.Drawing.Color.PapayaWhip;
            this.btnData.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnData.Location = new System.Drawing.Point(650, 48);
            this.btnData.Name = "btnData";
            this.btnData.Size = new System.Drawing.Size(107, 43);
            this.btnData.TabIndex = 14;
            this.btnData.Text = "ESPECIFICAR DATA";
            this.btnData.UseVisualStyleBackColor = false;
            this.btnData.Click += new System.EventHandler(this.btnData_Click);
            // 
            // btnValor
            // 
            this.btnValor.BackColor = System.Drawing.Color.LightYellow;
            this.btnValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnValor.Location = new System.Drawing.Point(537, 48);
            this.btnValor.Name = "btnValor";
            this.btnValor.Size = new System.Drawing.Size(107, 43);
            this.btnValor.TabIndex = 15;
            this.btnValor.Text = "ESPECIFICAR VALOR";
            this.btnValor.UseVisualStyleBackColor = false;
            this.btnValor.Click += new System.EventHandler(this.btnValor_Click);
            // 
            // txtValor1
            // 
            this.txtValor1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtValor1.Location = new System.Drawing.Point(539, 41);
            this.txtValor1.Multiline = true;
            this.txtValor1.Name = "txtValor1";
            this.txtValor1.Size = new System.Drawing.Size(89, 25);
            this.txtValor1.TabIndex = 16;
            this.txtValor1.Visible = false;
            // 
            // txtValor2
            // 
            this.txtValor2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtValor2.Location = new System.Drawing.Point(657, 41);
            this.txtValor2.Multiline = true;
            this.txtValor2.Name = "txtValor2";
            this.txtValor2.Size = new System.Drawing.Size(89, 25);
            this.txtValor2.TabIndex = 17;
            this.txtValor2.Visible = false;
            // 
            // btnBuscar2
            // 
            this.btnBuscar2.BackColor = System.Drawing.Color.PapayaWhip;
            this.btnBuscar2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnBuscar2.Location = new System.Drawing.Point(600, 72);
            this.btnBuscar2.Name = "btnBuscar2";
            this.btnBuscar2.Size = new System.Drawing.Size(86, 35);
            this.btnBuscar2.TabIndex = 18;
            this.btnBuscar2.Text = "BUSCAR";
            this.btnBuscar2.UseVisualStyleBackColor = false;
            this.btnBuscar2.Visible = false;
            this.btnBuscar2.Click += new System.EventHandler(this.btnBuscar2_Click);
            // 
            // RelatorioCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(758, 350);
            this.Controls.Add(this.btnData);
            this.Controls.Add(this.btnValor);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.cbFiltrosAvancados);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbFiltrosSimples);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.mtDataInicial);
            this.Controls.Add(this.mtDataFinal);
            this.Controls.Add(this.dgvCliente);
            this.Controls.Add(this.txtValor2);
            this.Controls.Add(this.txtValor1);
            this.Controls.Add(this.btnBuscar2);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "RelatorioCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RelatorioCliente";
            this.Load += new System.EventHandler(this.RelatorioCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.ComboBox cbFiltrosSimples;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbFiltrosAvancados;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hOMEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fECHARToolStripMenuItem;
        private System.Windows.Forms.MaskedTextBox mtDataFinal;
        private System.Windows.Forms.MaskedTextBox mtDataInicial;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnData;
        private System.Windows.Forms.Button btnValor;
        private System.Windows.Forms.TextBox txtValor1;
        private System.Windows.Forms.TextBox txtValor2;
        private System.Windows.Forms.Button btnBuscar2;
    }
}