﻿
namespace Augustus_Fashion.View.Telas_Centrais
{
    partial class TelaCliente
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
            this.label9 = new System.Windows.Forms.Label();
            this.pctLista = new System.Windows.Forms.PictureBox();
            this.pctCadastro = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pctLista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctCadastro)).BeginInit();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Cambria", 28F);
            this.label9.ForeColor = System.Drawing.Color.Blue;
            this.label9.Location = new System.Drawing.Point(80, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(314, 44);
            this.label9.TabIndex = 19;
            this.label9.Text = "Augustu\'s Fashion";
            // 
            // pctLista
            // 
            this.pctLista.Image = global::Augustus_Fashion.Properties.Resources.listar;
            this.pctLista.Location = new System.Drawing.Point(283, 102);
            this.pctLista.Name = "pctLista";
            this.pctLista.Size = new System.Drawing.Size(128, 128);
            this.pctLista.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pctLista.TabIndex = 21;
            this.pctLista.TabStop = false;
            this.pctLista.Click += new System.EventHandler(this.pctLista_Click);
            // 
            // pctCadastro
            // 
            this.pctCadastro.Image = global::Augustus_Fashion.Properties.Resources.cadastrar;
            this.pctCadastro.Location = new System.Drawing.Point(60, 102);
            this.pctCadastro.Name = "pctCadastro";
            this.pctCadastro.Size = new System.Drawing.Size(128, 128);
            this.pctCadastro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pctCadastro.TabIndex = 20;
            this.pctCadastro.TabStop = false;
            this.pctCadastro.Click += new System.EventHandler(this.pctCadastro_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(20, 249);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 24);
            this.label1.TabIndex = 22;
            this.label1.Text = "CADASTRAR CLIENTE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label2.Location = new System.Drawing.Point(269, 249);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 24);
            this.label2.TabIndex = 23;
            this.label2.Text = "LISTAR CLIENTE";
            // 
            // TelaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(464, 305);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pctLista);
            this.Controls.Add(this.pctCadastro);
            this.Controls.Add(this.label9);
            this.MaximizeBox = false;
            this.Name = "TelaCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TelaCliente";
            ((System.ComponentModel.ISupportInitialize)(this.pctLista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctCadastro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pctCadastro;
        private System.Windows.Forms.PictureBox pctLista;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}