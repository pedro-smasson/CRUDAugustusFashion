
namespace Augustus_Fashion.View.Pedido
{
    partial class VendaPedido
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgvFuncionario = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSelecionado = new System.Windows.Forms.TextBox();
            this.btnAvancar = new System.Windows.Forms.Button();
            this.pbBuscar = new System.Windows.Forms.PictureBox();
            this.txtFuncionario = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hOMEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fECHARToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBuscar)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label1.Location = new System.Drawing.Point(39, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Funcionário:";
            // 
            // dgvFuncionario
            // 
            this.dgvFuncionario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFuncionario.BackgroundColor = System.Drawing.Color.White;
            this.dgvFuncionario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFuncionario.Location = new System.Drawing.Point(43, 138);
            this.dgvFuncionario.Name = "dgvFuncionario";
            this.dgvFuncionario.ReadOnly = true;
            this.dgvFuncionario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFuncionario.Size = new System.Drawing.Size(519, 162);
            this.dgvFuncionario.TabIndex = 4;
            this.dgvFuncionario.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFuncionario_CellDoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label2.Location = new System.Drawing.Point(193, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(207, 31);
            this.label2.TabIndex = 5;
            this.label2.Text = "FUNCIONÁRIO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(39, 327);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(188, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Funcionário Selecionado:";
            // 
            // txtSelecionado
            // 
            this.txtSelecionado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtSelecionado.Location = new System.Drawing.Point(233, 321);
            this.txtSelecionado.Name = "txtSelecionado";
            this.txtSelecionado.ReadOnly = true;
            this.txtSelecionado.Size = new System.Drawing.Size(202, 29);
            this.txtSelecionado.TabIndex = 7;
            this.txtSelecionado.TextChanged += new System.EventHandler(this.txtSelecionado_TextChanged);
            // 
            // btnAvancar
            // 
            this.btnAvancar.BackColor = System.Drawing.Color.LightGreen;
            this.btnAvancar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnAvancar.Location = new System.Drawing.Point(457, 316);
            this.btnAvancar.Name = "btnAvancar";
            this.btnAvancar.Size = new System.Drawing.Size(105, 39);
            this.btnAvancar.TabIndex = 8;
            this.btnAvancar.Text = "AVANÇAR";
            this.btnAvancar.UseVisualStyleBackColor = false;
            this.btnAvancar.Click += new System.EventHandler(this.btnAvancar_Click);
            // 
            // pbBuscar
            // 
            this.pbBuscar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pbBuscar.BackgroundImage = global::Augustus_Fashion.Properties.Resources.search;
            this.pbBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbBuscar.Location = new System.Drawing.Point(522, 106);
            this.pbBuscar.Name = "pbBuscar";
            this.pbBuscar.Size = new System.Drawing.Size(40, 26);
            this.pbBuscar.TabIndex = 3;
            this.pbBuscar.TabStop = false;
            this.pbBuscar.Click += new System.EventHandler(this.pbBuscar_Click);
            // 
            // txtFuncionario
            // 
            this.txtFuncionario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.75F);
            this.txtFuncionario.Location = new System.Drawing.Point(161, 106);
            this.txtFuncionario.Name = "txtFuncionario";
            this.txtFuncionario.Size = new System.Drawing.Size(334, 26);
            this.txtFuncionario.TabIndex = 14;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hOMEToolStripMenuItem,
            this.fECHARToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(607, 24);
            this.menuStrip1.TabIndex = 15;
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
            // 
            // VendaPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(607, 380);
            this.Controls.Add(this.txtFuncionario);
            this.Controls.Add(this.btnAvancar);
            this.Controls.Add(this.txtSelecionado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvFuncionario);
            this.Controls.Add(this.pbBuscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "VendaPedido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VENDA";
            this.Load += new System.EventHandler(this.VendaPedido_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBuscar)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbBuscar;
        private System.Windows.Forms.DataGridView dgvFuncionario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSelecionado;
        private System.Windows.Forms.Button btnAvancar;
        private System.Windows.Forms.TextBox txtFuncionario;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hOMEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fECHARToolStripMenuItem;
    }
}