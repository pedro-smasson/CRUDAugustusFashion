
namespace Augustus_Fashion
{
    partial class cadastroCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cadastroCliente));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hOMEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FecharToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.groupBoxCliente = new System.Windows.Forms.GroupBox();
            this.enderecoCliente = new System.Windows.Forms.GroupBox();
            this.valorLimiteCliente = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.numeroCliente = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.celularCliente = new System.Windows.Forms.MaskedTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.estadoCliente = new System.Windows.Forms.ComboBox();
            this.complementoCliente = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cidadeCliente = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cepCliente = new System.Windows.Forms.MaskedTextBox();
            this.bairroCliente = new System.Windows.Forms.TextBox();
            this.ruaCliente = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.sexoCliente = new System.Windows.Forms.GroupBox();
            this.sexOtherCliente = new System.Windows.Forms.RadioButton();
            this.sexoFemCliente = new System.Windows.Forms.RadioButton();
            this.sexoMascCliente = new System.Windows.Forms.RadioButton();
            this.emailCliente = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cpfCliente = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nomeCliente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.datanascCliente = new System.Windows.Forms.DateTimePicker();
            this.menuStrip1.SuspendLayout();
            this.groupBoxCliente.SuspendLayout();
            this.enderecoCliente.SuspendLayout();
            this.sexoCliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.MediumPurple;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hOMEToolStripMenuItem,
            this.FecharToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(799, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hOMEToolStripMenuItem
            // 
            this.hOMEToolStripMenuItem.Name = "hOMEToolStripMenuItem";
            this.hOMEToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.hOMEToolStripMenuItem.Text = "HOME";
            this.hOMEToolStripMenuItem.Click += new System.EventHandler(this.hOMEToolStripMenuItem_Click);
            // 
            // FecharToolStripMenuItem
            // 
            this.FecharToolStripMenuItem.Name = "FecharToolStripMenuItem";
            this.FecharToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.FecharToolStripMenuItem.Text = "FECHAR";
            this.FecharToolStripMenuItem.Click += new System.EventHandler(this.FecharToolStripMenuItem_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnLimpar.Location = new System.Drawing.Point(407, 409);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(150, 50);
            this.btnLimpar.TabIndex = 16;
            this.btnLimpar.Text = "LIMPAR";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.LightGreen;
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnSalvar.Location = new System.Drawing.Point(227, 409);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(150, 50);
            this.btnSalvar.TabIndex = 15;
            this.btnSalvar.Text = "SALVAR";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // groupBoxCliente
            // 
            this.groupBoxCliente.Controls.Add(this.datanascCliente);
            this.groupBoxCliente.Controls.Add(this.enderecoCliente);
            this.groupBoxCliente.Controls.Add(this.sexoCliente);
            this.groupBoxCliente.Controls.Add(this.emailCliente);
            this.groupBoxCliente.Controls.Add(this.label4);
            this.groupBoxCliente.Controls.Add(this.label3);
            this.groupBoxCliente.Controls.Add(this.cpfCliente);
            this.groupBoxCliente.Controls.Add(this.label2);
            this.groupBoxCliente.Controls.Add(this.nomeCliente);
            this.groupBoxCliente.Controls.Add(this.label1);
            this.groupBoxCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.groupBoxCliente.Location = new System.Drawing.Point(12, 29);
            this.groupBoxCliente.Name = "groupBoxCliente";
            this.groupBoxCliente.Size = new System.Drawing.Size(776, 356);
            this.groupBoxCliente.TabIndex = 7;
            this.groupBoxCliente.TabStop = false;
            // 
            // enderecoCliente
            // 
            this.enderecoCliente.Controls.Add(this.valorLimiteCliente);
            this.enderecoCliente.Controls.Add(this.label13);
            this.enderecoCliente.Controls.Add(this.numeroCliente);
            this.enderecoCliente.Controls.Add(this.label12);
            this.enderecoCliente.Controls.Add(this.celularCliente);
            this.enderecoCliente.Controls.Add(this.label11);
            this.enderecoCliente.Controls.Add(this.estadoCliente);
            this.enderecoCliente.Controls.Add(this.complementoCliente);
            this.enderecoCliente.Controls.Add(this.label10);
            this.enderecoCliente.Controls.Add(this.cidadeCliente);
            this.enderecoCliente.Controls.Add(this.label9);
            this.enderecoCliente.Controls.Add(this.label8);
            this.enderecoCliente.Controls.Add(this.cepCliente);
            this.enderecoCliente.Controls.Add(this.bairroCliente);
            this.enderecoCliente.Controls.Add(this.ruaCliente);
            this.enderecoCliente.Controls.Add(this.label7);
            this.enderecoCliente.Controls.Add(this.label6);
            this.enderecoCliente.Controls.Add(this.label5);
            this.enderecoCliente.Location = new System.Drawing.Point(2, 147);
            this.enderecoCliente.Name = "enderecoCliente";
            this.enderecoCliente.Size = new System.Drawing.Size(768, 204);
            this.enderecoCliente.TabIndex = 9;
            this.enderecoCliente.TabStop = false;
            this.enderecoCliente.Text = "Endereço";
            // 
            // valorLimiteCliente
            // 
            this.valorLimiteCliente.Location = new System.Drawing.Point(613, 162);
            this.valorLimiteCliente.MaxLength = 50;
            this.valorLimiteCliente.Name = "valorLimiteCliente";
            this.valorLimiteCliente.Size = new System.Drawing.Size(143, 29);
            this.valorLimiteCliente.TabIndex = 14;
            this.valorLimiteCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.valorLimiteCliente_KeyPress);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(454, 165);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(153, 24);
            this.label13.TabIndex = 16;
            this.label13.Text = "Valor Limite (R$):";
            // 
            // numeroCliente
            // 
            this.numeroCliente.Location = new System.Drawing.Point(86, 162);
            this.numeroCliente.MaxLength = 5;
            this.numeroCliente.Name = "numeroCliente";
            this.numeroCliente.Size = new System.Drawing.Size(93, 29);
            this.numeroCliente.TabIndex = 9;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 165);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(84, 24);
            this.label12.TabIndex = 14;
            this.label12.Text = "Número:";
            // 
            // celularCliente
            // 
            this.celularCliente.Location = new System.Drawing.Point(281, 162);
            this.celularCliente.Mask = "00000000000";
            this.celularCliente.Name = "celularCliente";
            this.celularCliente.Size = new System.Drawing.Size(156, 29);
            this.celularCliente.TabIndex = 13;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(201, 165);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(74, 24);
            this.label11.TabIndex = 10;
            this.label11.Text = "Celular:";
            // 
            // estadoCliente
            // 
            this.estadoCliente.AutoCompleteCustomSource.AddRange(new string[] {
            "Acre/AC",
            "Alagoas/AL",
            "Amapá/AP",
            "Amazonas/AM",
            "Bahia/BA",
            "Ceará/CE",
            "Espírito Santo/ES",
            "Goiás/GO",
            "Maranhão/MA",
            "Mato Grosso/MT",
            "Mato Grosso do Sul/MS",
            "Minas Gerais/MG",
            "Pará/PA",
            "Paraíba/PB",
            "Paraná/PR",
            "Pernambuco/PE",
            "Piauí/PI",
            "Rio de Janeiro/RJ",
            "Rio Grande do Norte/RN",
            "Rio Grande do Sul/RS",
            "Rondônia/RO",
            "Roraima/RR",
            "Santa Catarina/SC",
            "São Paulo/SP",
            "Sergipe/SE",
            "Tocantins/TO",
            "Distrito Federal/DF"});
            this.estadoCliente.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.estadoCliente.FormattingEnabled = true;
            this.estadoCliente.IntegralHeight = false;
            this.estadoCliente.ItemHeight = 24;
            this.estadoCliente.Items.AddRange(new object[] {
            "Acre/AC",
            "Alagoas/AL",
            "Amapá/AP",
            "Amazonas/AM",
            "Bahia/BA",
            "Ceará/CE",
            "Espírito Santo/ES",
            "Goiás/GO",
            "Maranhão/MA",
            "Mato Grosso/MT",
            "Mato Grosso do Sul/MS",
            "Minas Gerais/MG",
            "Pará/PA",
            "Paraíba/PB",
            "Paraná/PR",
            "Pernambuco/PE",
            "Piauí/PI",
            "Rio de Janeiro/RJ",
            "Rio Grande do Norte/RN",
            "Rio Grande do Sul/RS",
            "Rondônia/RO",
            "Roraima/RR",
            "Santa Catarina/SC",
            "São Paulo/SP",
            "Sergipe/SE",
            "Tocantins/TO",
            "Distrito Federal/DF"});
            this.estadoCliente.Location = new System.Drawing.Point(563, 80);
            this.estadoCliente.MaxDropDownItems = 7;
            this.estadoCliente.Name = "estadoCliente";
            this.estadoCliente.Size = new System.Drawing.Size(193, 32);
            this.estadoCliente.TabIndex = 11;
            // 
            // complementoCliente
            // 
            this.complementoCliente.Location = new System.Drawing.Point(594, 121);
            this.complementoCliente.MaxLength = 32000;
            this.complementoCliente.Name = "complementoCliente";
            this.complementoCliente.Size = new System.Drawing.Size(162, 29);
            this.complementoCliente.TabIndex = 12;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(454, 124);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(134, 24);
            this.label10.TabIndex = 9;
            this.label10.Text = "Complemento:";
            // 
            // cidadeCliente
            // 
            this.cidadeCliente.Location = new System.Drawing.Point(535, 40);
            this.cidadeCliente.MaxLength = 30;
            this.cidadeCliente.Name = "cidadeCliente";
            this.cidadeCliente.Size = new System.Drawing.Size(221, 29);
            this.cidadeCliente.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(454, 83);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 24);
            this.label9.TabIndex = 7;
            this.label9.Text = "Estado/UF:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(454, 43);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 24);
            this.label8.TabIndex = 6;
            this.label8.Text = "Cidade:";
            // 
            // cepCliente
            // 
            this.cepCliente.Location = new System.Drawing.Point(72, 121);
            this.cepCliente.Mask = "00,000-000";
            this.cepCliente.Name = "cepCliente";
            this.cepCliente.Size = new System.Drawing.Size(365, 29);
            this.cepCliente.TabIndex = 8;
            // 
            // bairroCliente
            // 
            this.bairroCliente.Location = new System.Drawing.Point(72, 80);
            this.bairroCliente.MaxLength = 40;
            this.bairroCliente.Name = "bairroCliente";
            this.bairroCliente.Size = new System.Drawing.Size(365, 29);
            this.bairroCliente.TabIndex = 7;
            // 
            // ruaCliente
            // 
            this.ruaCliente.Location = new System.Drawing.Point(72, 40);
            this.ruaCliente.MaxLength = 30;
            this.ruaCliente.Name = "ruaCliente";
            this.ruaCliente.Size = new System.Drawing.Size(365, 29);
            this.ruaCliente.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label7.Location = new System.Drawing.Point(6, 124);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 24);
            this.label7.TabIndex = 2;
            this.label7.Text = "CEP:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label6.Location = new System.Drawing.Point(6, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 24);
            this.label6.TabIndex = 1;
            this.label6.Text = "Bairro:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label5.Location = new System.Drawing.Point(6, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 24);
            this.label5.TabIndex = 0;
            this.label5.Text = "Rua:";
            // 
            // sexoCliente
            // 
            this.sexoCliente.Controls.Add(this.sexOtherCliente);
            this.sexoCliente.Controls.Add(this.sexoFemCliente);
            this.sexoCliente.Controls.Add(this.sexoMascCliente);
            this.sexoCliente.Location = new System.Drawing.Point(638, 14);
            this.sexoCliente.Name = "sexoCliente";
            this.sexoCliente.Size = new System.Drawing.Size(132, 129);
            this.sexoCliente.TabIndex = 5;
            this.sexoCliente.TabStop = false;
            this.sexoCliente.Text = "Sexo";
            // 
            // sexOtherCliente
            // 
            this.sexOtherCliente.AutoSize = true;
            this.sexOtherCliente.Location = new System.Drawing.Point(7, 97);
            this.sexOtherCliente.Name = "sexOtherCliente";
            this.sexOtherCliente.Size = new System.Drawing.Size(75, 28);
            this.sexOtherCliente.TabIndex = 2;
            this.sexOtherCliente.TabStop = true;
            this.sexOtherCliente.Text = "Outro";
            this.sexOtherCliente.UseVisualStyleBackColor = true;
            // 
            // sexoFemCliente
            // 
            this.sexoFemCliente.AutoSize = true;
            this.sexoFemCliente.Location = new System.Drawing.Point(6, 62);
            this.sexoFemCliente.Name = "sexoFemCliente";
            this.sexoFemCliente.Size = new System.Drawing.Size(108, 28);
            this.sexoFemCliente.TabIndex = 1;
            this.sexoFemCliente.TabStop = true;
            this.sexoFemCliente.Text = "Feminino";
            this.sexoFemCliente.UseVisualStyleBackColor = true;
            // 
            // sexoMascCliente
            // 
            this.sexoMascCliente.AutoSize = true;
            this.sexoMascCliente.Location = new System.Drawing.Point(6, 28);
            this.sexoMascCliente.Name = "sexoMascCliente";
            this.sexoMascCliente.Size = new System.Drawing.Size(114, 28);
            this.sexoMascCliente.TabIndex = 0;
            this.sexoMascCliente.TabStop = true;
            this.sexoMascCliente.Text = "Masculino";
            this.sexoMascCliente.UseVisualStyleBackColor = true;
            // 
            // emailCliente
            // 
            this.emailCliente.Location = new System.Drawing.Point(10, 103);
            this.emailCliente.Name = "emailCliente";
            this.emailCliente.Size = new System.Drawing.Size(295, 29);
            this.emailCliente.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label4.Location = new System.Drawing.Point(6, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 22);
            this.label4.TabIndex = 6;
            this.label4.Text = "Email:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label3.Location = new System.Drawing.Point(402, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 22);
            this.label3.TabIndex = 5;
            this.label3.Text = "CPF:";
            // 
            // cpfCliente
            // 
            this.cpfCliente.Location = new System.Drawing.Point(406, 103);
            this.cpfCliente.Mask = "000,000,000-00";
            this.cpfCliente.Name = "cpfCliente";
            this.cpfCliente.Size = new System.Drawing.Size(136, 29);
            this.cpfCliente.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label2.Location = new System.Drawing.Point(402, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Data de Nascimento:";
            // 
            // nomeCliente
            // 
            this.nomeCliente.Location = new System.Drawing.Point(10, 39);
            this.nomeCliente.MaxLength = 50;
            this.nomeCliente.Name = "nomeCliente";
            this.nomeCliente.Size = new System.Drawing.Size(295, 29);
            this.nomeCliente.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label1.Location = new System.Drawing.Point(6, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome do Cliente: ";
            // 
            // datanascCliente
            // 
            this.datanascCliente.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datanascCliente.Location = new System.Drawing.Point(406, 42);
            this.datanascCliente.Name = "datanascCliente";
            this.datanascCliente.Size = new System.Drawing.Size(173, 29);
            this.datanascCliente.TabIndex = 10;
            // 
            // cadastroCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(799, 471);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.groupBoxCliente);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "cadastroCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Augustu\'s Fashion - Cadastrar Clientes";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBoxCliente.ResumeLayout(false);
            this.groupBoxCliente.PerformLayout();
            this.enderecoCliente.ResumeLayout(false);
            this.enderecoCliente.PerformLayout();
            this.sexoCliente.ResumeLayout(false);
            this.sexoCliente.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hOMEToolStripMenuItem;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.GroupBox groupBoxCliente;
        private System.Windows.Forms.GroupBox enderecoCliente;
        private System.Windows.Forms.ComboBox estadoCliente;
        private System.Windows.Forms.TextBox complementoCliente;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox cidadeCliente;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox cepCliente;
        private System.Windows.Forms.TextBox bairroCliente;
        private System.Windows.Forms.TextBox ruaCliente;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox sexoCliente;
        private System.Windows.Forms.RadioButton sexOtherCliente;
        private System.Windows.Forms.RadioButton sexoFemCliente;
        private System.Windows.Forms.RadioButton sexoMascCliente;
        private System.Windows.Forms.MaskedTextBox emailCliente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox cpfCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nomeCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.MaskedTextBox celularCliente;
        private System.Windows.Forms.TextBox numeroCliente;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ToolStripMenuItem FecharToolStripMenuItem;
        private System.Windows.Forms.TextBox valorLimiteCliente;
        private System.Windows.Forms.DateTimePicker datanascCliente;
    }
}

