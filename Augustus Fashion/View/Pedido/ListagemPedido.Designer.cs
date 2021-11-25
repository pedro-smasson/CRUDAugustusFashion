
namespace Augustus_Fashion.View.Pedido
{
    partial class ListagemPedido
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
            this.dgvPedido = new System.Windows.Forms.DataGridView();
            this.txtBuscarNomeFuncionario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buscarId = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hOMEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cADASTROToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cLIENTESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fUNCIONÁRIOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cONSULTAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cLIENTESToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.fUNCIONÁRIOSToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.FecharToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtBuscarNomeCliente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedido)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvPedido
            // 
            this.dgvPedido.AllowUserToAddRows = false;
            this.dgvPedido.AllowUserToDeleteRows = false;
            this.dgvPedido.AllowUserToResizeColumns = false;
            this.dgvPedido.AllowUserToResizeRows = false;
            this.dgvPedido.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPedido.BackgroundColor = System.Drawing.Color.LavenderBlush;
            this.dgvPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPedido.Location = new System.Drawing.Point(0, 110);
            this.dgvPedido.MultiSelect = false;
            this.dgvPedido.Name = "dgvPedido";
            this.dgvPedido.ReadOnly = true;
            this.dgvPedido.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPedido.Size = new System.Drawing.Size(684, 185);
            this.dgvPedido.TabIndex = 9;
            this.dgvPedido.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPedido_CellDoubleClick);
            // 
            // txtBuscarNomeFuncionario
            // 
            this.txtBuscarNomeFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarNomeFuncionario.Location = new System.Drawing.Point(277, 33);
            this.txtBuscarNomeFuncionario.Name = "txtBuscarNomeFuncionario";
            this.txtBuscarNomeFuncionario.Size = new System.Drawing.Size(247, 31);
            this.txtBuscarNomeFuncionario.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label1.Location = new System.Drawing.Point(12, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 22);
            this.label1.TabIndex = 7;
            this.label1.Text = "Infome o Nome do Funcionário:";
            // 
            // buscarId
            // 
            this.buscarId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buscarId.Location = new System.Drawing.Point(547, 50);
            this.buscarId.Name = "buscarId";
            this.buscarId.Size = new System.Drawing.Size(125, 40);
            this.buscarId.TabIndex = 6;
            this.buscarId.Text = "BUSCAR";
            this.buscarId.UseVisualStyleBackColor = true;
            this.buscarId.Click += new System.EventHandler(this.buscarId_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hOMEToolStripMenuItem,
            this.cADASTROToolStripMenuItem,
            this.cONSULTAToolStripMenuItem,
            this.FecharToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(684, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hOMEToolStripMenuItem
            // 
            this.hOMEToolStripMenuItem.Name = "hOMEToolStripMenuItem";
            this.hOMEToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.hOMEToolStripMenuItem.Text = "HOME";
            this.hOMEToolStripMenuItem.Click += new System.EventHandler(this.hOMEToolStripMenuItem_Click);
            // 
            // cADASTROToolStripMenuItem
            // 
            this.cADASTROToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cLIENTESToolStripMenuItem,
            this.fUNCIONÁRIOSToolStripMenuItem});
            this.cADASTROToolStripMenuItem.Name = "cADASTROToolStripMenuItem";
            this.cADASTROToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.cADASTROToolStripMenuItem.Text = "CADASTRO";
            // 
            // cLIENTESToolStripMenuItem
            // 
            this.cLIENTESToolStripMenuItem.Name = "cLIENTESToolStripMenuItem";
            this.cLIENTESToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.cLIENTESToolStripMenuItem.Text = "CLIENTES";
            // 
            // fUNCIONÁRIOSToolStripMenuItem
            // 
            this.fUNCIONÁRIOSToolStripMenuItem.Name = "fUNCIONÁRIOSToolStripMenuItem";
            this.fUNCIONÁRIOSToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.fUNCIONÁRIOSToolStripMenuItem.Text = "FUNCIONÁRIOS";
            // 
            // cONSULTAToolStripMenuItem
            // 
            this.cONSULTAToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cLIENTESToolStripMenuItem1,
            this.fUNCIONÁRIOSToolStripMenuItem1});
            this.cONSULTAToolStripMenuItem.Name = "cONSULTAToolStripMenuItem";
            this.cONSULTAToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.cONSULTAToolStripMenuItem.Text = "LISTAR";
            // 
            // cLIENTESToolStripMenuItem1
            // 
            this.cLIENTESToolStripMenuItem1.Name = "cLIENTESToolStripMenuItem1";
            this.cLIENTESToolStripMenuItem1.Size = new System.Drawing.Size(159, 22);
            this.cLIENTESToolStripMenuItem1.Text = "CLIENTES";
            // 
            // fUNCIONÁRIOSToolStripMenuItem1
            // 
            this.fUNCIONÁRIOSToolStripMenuItem1.Name = "fUNCIONÁRIOSToolStripMenuItem1";
            this.fUNCIONÁRIOSToolStripMenuItem1.Size = new System.Drawing.Size(159, 22);
            this.fUNCIONÁRIOSToolStripMenuItem1.Text = "FUNCIONÁRIOS";
            // 
            // FecharToolStripMenuItem
            // 
            this.FecharToolStripMenuItem.Name = "FecharToolStripMenuItem";
            this.FecharToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.FecharToolStripMenuItem.Text = "FECHAR";
            // 
            // txtBuscarNomeCliente
            // 
            this.txtBuscarNomeCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarNomeCliente.Location = new System.Drawing.Point(239, 70);
            this.txtBuscarNomeCliente.Name = "txtBuscarNomeCliente";
            this.txtBuscarNomeCliente.Size = new System.Drawing.Size(285, 31);
            this.txtBuscarNomeCliente.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label2.Location = new System.Drawing.Point(12, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(221, 22);
            this.label2.TabIndex = 12;
            this.label2.Text = "Infome o Nome do Cliente:";
            // 
            // ListagemPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(684, 296);
            this.Controls.Add(this.txtBuscarNomeCliente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.dgvPedido);
            this.Controls.Add(this.txtBuscarNomeFuncionario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buscarId);
            this.Name = "ListagemPedido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LISTAR PEDIDO";
            this.Load += new System.EventHandler(this.ListagemPedido_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedido)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPedido;
        private System.Windows.Forms.TextBox txtBuscarNomeFuncionario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buscarId;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hOMEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cADASTROToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cLIENTESToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fUNCIONÁRIOSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cONSULTAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cLIENTESToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem fUNCIONÁRIOSToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem FecharToolStripMenuItem;
        private System.Windows.Forms.TextBox txtBuscarNomeCliente;
        private System.Windows.Forms.Label label2;
    }
}