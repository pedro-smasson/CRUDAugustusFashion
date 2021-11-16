
namespace Augustus_Fashion.View.Pedido
{
    partial class VendaPedido3
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
            this.dgvProduto = new System.Windows.Forms.DataGridView();
            this.pbBuscar = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtProduto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.txtSelecionado = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvCarrinho = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.btnRemover = new System.Windows.Forms.Button();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPrecoVenda = new System.Windows.Forms.TextBox();
            this.nudQuantidade = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Preço = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDesconto = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBuscar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarrinho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantidade)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProduto
            // 
            this.dgvProduto.BackgroundColor = System.Drawing.Color.LavenderBlush;
            this.dgvProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduto.Location = new System.Drawing.Point(12, 157);
            this.dgvProduto.Name = "dgvProduto";
            this.dgvProduto.ReadOnly = true;
            this.dgvProduto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProduto.Size = new System.Drawing.Size(437, 162);
            this.dgvProduto.TabIndex = 16;
            this.dgvProduto.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProduto_CellDoubleClick);
            // 
            // pbBuscar
            // 
            this.pbBuscar.Image = global::Augustus_Fashion.Properties.Resources.search;
            this.pbBuscar.Location = new System.Drawing.Point(287, 87);
            this.pbBuscar.Name = "pbBuscar";
            this.pbBuscar.Size = new System.Drawing.Size(64, 64);
            this.pbBuscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbBuscar.TabIndex = 15;
            this.pbBuscar.TabStop = false;
            this.pbBuscar.Click += new System.EventHandler(this.pbBuscar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label1.Location = new System.Drawing.Point(73, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 26);
            this.label1.TabIndex = 14;
            this.label1.Text = "Produtos:";
            // 
            // txtProduto
            // 
            this.txtProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.txtProduto.Location = new System.Drawing.Point(78, 107);
            this.txtProduto.Name = "txtProduto";
            this.txtProduto.Size = new System.Drawing.Size(201, 32);
            this.txtProduto.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label2.Location = new System.Drawing.Point(123, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(615, 31);
            this.label2.TabIndex = 17;
            this.label2.Text = "VENDA: PASSO 3 - CARRINHO DE PRODUTOS";
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.Cornsilk;
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnVoltar.Location = new System.Drawing.Point(12, 550);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(105, 39);
            this.btnVoltar.TabIndex = 21;
            this.btnVoltar.Text = "VOLTAR";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.LightGreen;
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnSalvar.Location = new System.Drawing.Point(768, 12);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(105, 39);
            this.btnSalvar.TabIndex = 20;
            this.btnSalvar.Text = "SALVAR";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // txtSelecionado
            // 
            this.txtSelecionado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtSelecionado.Location = new System.Drawing.Point(218, 345);
            this.txtSelecionado.Name = "txtSelecionado";
            this.txtSelecionado.ReadOnly = true;
            this.txtSelecionado.Size = new System.Drawing.Size(195, 29);
            this.txtSelecionado.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label3.Location = new System.Drawing.Point(12, 347);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 25);
            this.label3.TabIndex = 18;
            this.label3.Text = "Produto Selecionado:";
            // 
            // dgvCarrinho
            // 
            this.dgvCarrinho.BackgroundColor = System.Drawing.Color.LavenderBlush;
            this.dgvCarrinho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCarrinho.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nome,
            this.Preço,
            this.Quantidade});
            this.dgvCarrinho.Location = new System.Drawing.Point(511, 157);
            this.dgvCarrinho.Name = "dgvCarrinho";
            this.dgvCarrinho.Size = new System.Drawing.Size(343, 162);
            this.dgvCarrinho.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label4.Location = new System.Drawing.Point(506, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 26);
            this.label4.TabIndex = 23;
            this.label4.Text = "Carrinho:";
            // 
            // btnRemover
            // 
            this.btnRemover.BackColor = System.Drawing.Color.Crimson;
            this.btnRemover.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnRemover.Location = new System.Drawing.Point(638, 345);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(105, 39);
            this.btnRemover.TabIndex = 24;
            this.btnRemover.Text = "REMOVER";
            this.btnRemover.UseVisualStyleBackColor = false;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.BackColor = System.Drawing.Color.LightGreen;
            this.btnAdicionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnAdicionar.Location = new System.Drawing.Point(760, 345);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(113, 39);
            this.btnAdicionar.TabIndex = 25;
            this.btnAdicionar.Text = "ADICIONAR";
            this.btnAdicionar.UseVisualStyleBackColor = false;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label5.Location = new System.Drawing.Point(12, 449);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 25);
            this.label5.TabIndex = 26;
            this.label5.Text = "Quantidade:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label6.Location = new System.Drawing.Point(12, 400);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(159, 25);
            this.label6.TabIndex = 27;
            this.label6.Text = "Preço de Venda:";
            // 
            // txtPrecoVenda
            // 
            this.txtPrecoVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtPrecoVenda.Location = new System.Drawing.Point(177, 398);
            this.txtPrecoVenda.Name = "txtPrecoVenda";
            this.txtPrecoVenda.ReadOnly = true;
            this.txtPrecoVenda.Size = new System.Drawing.Size(206, 29);
            this.txtPrecoVenda.TabIndex = 29;
            // 
            // nudQuantidade
            // 
            this.nudQuantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.nudQuantidade.Location = new System.Drawing.Point(138, 448);
            this.nudQuantidade.Name = "nudQuantidade";
            this.nudQuantidade.ReadOnly = true;
            this.nudQuantidade.Size = new System.Drawing.Size(120, 29);
            this.nudQuantidade.TabIndex = 30;
            this.nudQuantidade.ValueChanged += new System.EventHandler(this.nudQuantidade_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label7.Location = new System.Drawing.Point(12, 503);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(206, 25);
            this.label7.TabIndex = 31;
            this.label7.Text = "Forma de Pagamento:";
            // 
            // Nome
            // 
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            // 
            // Preço
            // 
            this.Preço.HeaderText = "Preço";
            this.Preço.Name = "Preço";
            this.Preço.ReadOnly = true;
            // 
            // Quantidade
            // 
            this.Quantidade.HeaderText = "Quantidade";
            this.Quantidade.Name = "Quantidade";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Cartão - Crédito",
            "Cartão - Débito",
            "Á Vista",
            "Á Prazo",
            "Cheque"});
            this.comboBox1.Location = new System.Drawing.Point(218, 501);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(165, 32);
            this.comboBox1.TabIndex = 32;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label8.Location = new System.Drawing.Point(273, 452);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 25);
            this.label8.TabIndex = 33;
            this.label8.Text = "Desconto:";
            // 
            // txtDesconto
            // 
            this.txtDesconto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtDesconto.Location = new System.Drawing.Point(380, 450);
            this.txtDesconto.Name = "txtDesconto";
            this.txtDesconto.Size = new System.Drawing.Size(68, 29);
            this.txtDesconto.TabIndex = 34;
            // 
            // VendaPedido3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(885, 601);
            this.Controls.Add(this.txtDesconto);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.nudQuantidade);
            this.Controls.Add(this.txtPrecoVenda);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvCarrinho);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txtSelecionado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvProduto);
            this.Controls.Add(this.pbBuscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtProduto);
            this.Name = "VendaPedido3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VendaPedido3";
            this.Load += new System.EventHandler(this.VendaPedido3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBuscar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarrinho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantidade)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProduto;
        private System.Windows.Forms.PictureBox pbBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtProduto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.TextBox txtSelecionado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvCarrinho;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPrecoVenda;
        private System.Windows.Forms.NumericUpDown nudQuantidade;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Preço;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantidade;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDesconto;
    }
}