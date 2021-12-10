﻿
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
            this.cbOrdenarPor = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbFiltrarPor = new System.Windows.Forms.ComboBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hOMEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fECHARToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label6 = new System.Windows.Forms.Label();
            this.dudValorInicial = new System.Windows.Forms.DomainUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpDataFinal = new System.Windows.Forms.DateTimePicker();
            this.dtpDataInicial = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.cbCrescenteOuDecrescente = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dudCliente = new System.Windows.Forms.DomainUpDown();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvCliente
            // 
            this.dgvCliente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCliente.BackgroundColor = System.Drawing.Color.White;
            this.dgvCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCliente.GridColor = System.Drawing.SystemColors.Control;
            this.dgvCliente.Location = new System.Drawing.Point(25, 140);
            this.dgvCliente.Name = "dgvCliente";
            this.dgvCliente.ReadOnly = true;
            this.dgvCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCliente.Size = new System.Drawing.Size(517, 391);
            this.dgvCliente.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(570, 251);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ordenar Por:";
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.BackColor = System.Drawing.Color.PaleGreen;
            this.btnFiltrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnFiltrar.Location = new System.Drawing.Point(660, 486);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(73, 37);
            this.btnFiltrar.TabIndex = 3;
            this.btnFiltrar.Text = "FILTRAR";
            this.btnFiltrar.UseVisualStyleBackColor = false;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // cbOrdenarPor
            // 
            this.cbOrdenarPor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOrdenarPor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbOrdenarPor.FormattingEnabled = true;
            this.cbOrdenarPor.Items.AddRange(new object[] {
            "Quantidade",
            "Desconto",
            "Preço Líquido"});
            this.cbOrdenarPor.Location = new System.Drawing.Point(573, 272);
            this.cbOrdenarPor.Name = "cbOrdenarPor";
            this.cbOrdenarPor.Size = new System.Drawing.Size(152, 21);
            this.cbOrdenarPor.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(570, 364);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Filtrar Por:";
            // 
            // cbFiltrarPor
            // 
            this.cbFiltrarPor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFiltrarPor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFiltrarPor.FormattingEnabled = true;
            this.cbFiltrarPor.Items.AddRange(new object[] {
            "Quantidade",
            "Desconto",
            "Preço Líquido"});
            this.cbFiltrarPor.Location = new System.Drawing.Point(573, 385);
            this.cbFiltrarPor.Name = "cbFiltrarPor";
            this.cbFiltrarPor.Size = new System.Drawing.Size(96, 21);
            this.cbFiltrarPor.TabIndex = 6;
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.Snow;
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnLimpar.Location = new System.Drawing.Point(581, 486);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(73, 37);
            this.btnLimpar.TabIndex = 7;
            this.btnLimpar.Text = "LIMPAR";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.MediumPurple;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hOMEToolStripMenuItem,
            this.fECHARToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(146, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(251, 29);
            this.label6.TabIndex = 19;
            this.label6.Text = "Relatórios de Clientes";
            // 
            // dudValorInicial
            // 
            this.dudValorInicial.Location = new System.Drawing.Point(573, 324);
            this.dudValorInicial.Name = "dudValorInicial";
            this.dudValorInicial.Size = new System.Drawing.Size(154, 20);
            this.dudValorInicial.TabIndex = 20;
            this.dudValorInicial.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(568, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 18);
            this.label4.TabIndex = 24;
            this.label4.Text = "Data Final";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(568, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 18);
            this.label3.TabIndex = 23;
            this.label3.Text = "Data Inicial";
            // 
            // dtpDataFinal
            // 
            this.dtpDataFinal.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDataFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dtpDataFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataFinal.Location = new System.Drawing.Point(571, 216);
            this.dtpDataFinal.Name = "dtpDataFinal";
            this.dtpDataFinal.Size = new System.Drawing.Size(154, 23);
            this.dtpDataFinal.TabIndex = 22;
            // 
            // dtpDataInicial
            // 
            this.dtpDataInicial.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDataInicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dtpDataInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataInicial.Location = new System.Drawing.Point(571, 159);
            this.dtpDataInicial.Name = "dtpDataInicial";
            this.dtpDataInicial.Size = new System.Drawing.Size(154, 23);
            this.dtpDataInicial.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(572, 303);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 18);
            this.label5.TabIndex = 2;
            this.label5.Text = "A partir:";
            // 
            // cbCrescenteOuDecrescente
            // 
            this.cbCrescenteOuDecrescente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCrescenteOuDecrescente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCrescenteOuDecrescente.FormattingEnabled = true;
            this.cbCrescenteOuDecrescente.Items.AddRange(new object[] {
            "Crescente",
            "Decrescente"});
            this.cbCrescenteOuDecrescente.Location = new System.Drawing.Point(675, 385);
            this.cbCrescenteOuDecrescente.Name = "cbCrescenteOuDecrescente";
            this.cbCrescenteOuDecrescente.Size = new System.Drawing.Size(52, 21);
            this.cbCrescenteOuDecrescente.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(671, 364);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 18);
            this.label7.TabIndex = 5;
            this.label7.Text = "Ordem:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(572, 422);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 18);
            this.label8.TabIndex = 2;
            this.label8.Text = "Qtd Clientes:";
            // 
            // dudCliente
            // 
            this.dudCliente.Location = new System.Drawing.Point(573, 443);
            this.dudCliente.Name = "dudCliente";
            this.dudCliente.Size = new System.Drawing.Size(154, 20);
            this.dudCliente.TabIndex = 20;
            this.dudCliente.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(589, 69);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 29);
            this.label9.TabIndex = 19;
            this.label9.Text = "Filtros";
            // 
            // RelatorioCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpDataFinal);
            this.Controls.Add(this.dtpDataInicial);
            this.Controls.Add(this.dudCliente);
            this.Controls.Add(this.dudValorInicial);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.cbCrescenteOuDecrescente);
            this.Controls.Add(this.cbFiltrarPor);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbOrdenarPor);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.dgvCliente);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "RelatorioCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Augustus Fashion - Relatório de Clientes";
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
        private System.Windows.Forms.ComboBox cbOrdenarPor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbFiltrarPor;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hOMEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fECHARToolStripMenuItem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DomainUpDown dudValorInicial;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpDataFinal;
        private System.Windows.Forms.DateTimePicker dtpDataInicial;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbCrescenteOuDecrescente;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DomainUpDown dudCliente;
        private System.Windows.Forms.Label label9;
    }
}