
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCliente
            // 
            this.dgvCliente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCliente.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCliente.GridColor = System.Drawing.SystemColors.Control;
            this.dgvCliente.Location = new System.Drawing.Point(0, 79);
            this.dgvCliente.Name = "dgvCliente";
            this.dgvCliente.ReadOnly = true;
            this.dgvCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCliente.Size = new System.Drawing.Size(800, 271);
            this.dgvCliente.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Filtros Simples:";
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnFiltrar.Location = new System.Drawing.Point(681, 22);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(96, 37);
            this.btnFiltrar.TabIndex = 3;
            this.btnFiltrar.Text = "FILTRAR";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // cbFiltrosSimples
            // 
            this.cbFiltrosSimples.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFiltrosSimples.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbFiltrosSimples.FormattingEnabled = true;
            this.cbFiltrosSimples.Items.AddRange(new object[] {
            "Quantidade Crescente",
            "Quantidade Descrescente",
            "Total Liquido Crescente",
            "Total Liquido Decrescente",
            "Desconto Crescente",
            "Desconto Decrescente"});
            this.cbFiltrosSimples.Location = new System.Drawing.Point(134, 28);
            this.cbFiltrosSimples.Name = "cbFiltrosSimples";
            this.cbFiltrosSimples.Size = new System.Drawing.Size(156, 28);
            this.cbFiltrosSimples.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(306, 31);
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
            "Clientes que Mais Compraram",
            "Clientes que Menos Compraram",
            "5 Clientes que Mais Compraram",
            "5 Clientes que Menos Compraram"});
            this.cbFiltrosAvancados.Location = new System.Drawing.Point(451, 28);
            this.cbFiltrosAvancados.Name = "cbFiltrosAvancados";
            this.cbFiltrosAvancados.Size = new System.Drawing.Size(156, 28);
            this.cbFiltrosAvancados.TabIndex = 6;
            // 
            // RelatorioCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 350);
            this.Controls.Add(this.cbFiltrosAvancados);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbFiltrosSimples);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvCliente);
            this.MaximizeBox = false;
            this.Name = "RelatorioCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RelatorioCliente";
            this.Load += new System.EventHandler(this.RelatorioCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).EndInit();
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
    }
}