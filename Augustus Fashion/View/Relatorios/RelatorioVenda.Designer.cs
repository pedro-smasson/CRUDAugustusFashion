
namespace Augustus_Fashion.View.Relatorios
{
    partial class RelatorioVenda
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
            this.dgvVenda = new System.Windows.Forms.DataGridView();
            this.cbFiltrosAvancados = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbFiltrosSimples = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hOMEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fECHARToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnFiltrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVenda)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvVenda
            // 
            this.dgvVenda.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVenda.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvVenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVenda.GridColor = System.Drawing.SystemColors.Control;
            this.dgvVenda.Location = new System.Drawing.Point(0, 113);
            this.dgvVenda.Name = "dgvVenda";
            this.dgvVenda.ReadOnly = true;
            this.dgvVenda.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVenda.Size = new System.Drawing.Size(758, 237);
            this.dgvVenda.TabIndex = 1;
            // 
            // cbFiltrosAvancados
            // 
            this.cbFiltrosAvancados.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFiltrosAvancados.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbFiltrosAvancados.FormattingEnabled = true;
            this.cbFiltrosAvancados.Items.AddRange(new object[] {
            "5 Produtos Mais Lucrativos",
            "5 Produtos Menos Lucrativos",
            "5 Vendas Mais Lucrativas",
            "5 Vendas Menos Lucrativas"});
            this.cbFiltrosAvancados.Location = new System.Drawing.Point(157, 79);
            this.cbFiltrosAvancados.Name = "cbFiltrosAvancados";
            this.cbFiltrosAvancados.Size = new System.Drawing.Size(254, 28);
            this.cbFiltrosAvancados.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(12, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Filtros Avançados:";
            // 
            // cbFiltrosSimples
            // 
            this.cbFiltrosSimples.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFiltrosSimples.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbFiltrosSimples.FormattingEnabled = true;
            this.cbFiltrosSimples.Items.AddRange(new object[] {
            "Produtos Mais Vendidos",
            "Produtos Menos Vendidos",
            "Produtos com Maior Estoque",
            "Produtos com Menor Estoque",
            "Vendas Mais Rentáveis",
            "Vendas Menos Rentáveis"});
            this.cbFiltrosSimples.Location = new System.Drawing.Point(157, 38);
            this.cbFiltrosSimples.Name = "cbFiltrosSimples";
            this.cbFiltrosSimples.Size = new System.Drawing.Size(254, 28);
            this.cbFiltrosSimples.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(12, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Filtros Simples:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hOMEToolStripMenuItem,
            this.fECHARToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(758, 24);
            this.menuStrip1.TabIndex = 11;
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
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.Snow;
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnLimpar.Location = new System.Drawing.Point(444, 74);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(87, 37);
            this.btnLimpar.TabIndex = 13;
            this.btnLimpar.Text = "LIMPAR";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.BackColor = System.Drawing.Color.PaleGreen;
            this.btnFiltrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnFiltrar.Location = new System.Drawing.Point(444, 33);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(87, 37);
            this.btnFiltrar.TabIndex = 12;
            this.btnFiltrar.Text = "FILTRAR";
            this.btnFiltrar.UseVisualStyleBackColor = false;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // RelatorioVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(758, 350);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.cbFiltrosAvancados);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbFiltrosSimples);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvVenda);
            this.MaximizeBox = false;
            this.Name = "RelatorioVenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Augustus Fashion - Relatório de Vendas e Produtos";
            this.Load += new System.EventHandler(this.RelatorioVenda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVenda)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvVenda;
        private System.Windows.Forms.ComboBox cbFiltrosAvancados;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbFiltrosSimples;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hOMEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fECHARToolStripMenuItem;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnFiltrar;
    }
}