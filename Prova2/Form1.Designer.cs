namespace Prova2
{
    partial class Form1
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
            this.lb_resul = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.cbx_unidade = new System.Windows.Forms.ComboBox();
            this.tx_lucro = new System.Windows.Forms.TextBox();
            this.tx_valor = new System.Windows.Forms.TextBox();
            this.tx_cd = new System.Windows.Forms.TextBox();
            this.tx_descricao = new System.Windows.Forms.TextBox();
            this.tx_confins = new System.Windows.Forms.TextBox();
            this.tx_icms = new System.Windows.Forms.TextBox();
            this.tx_pis = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lb_resul
            // 
            this.lb_resul.AutoSize = true;
            this.lb_resul.Location = new System.Drawing.Point(160, 390);
            this.lb_resul.Name = "lb_resul";
            this.lb_resul.Size = new System.Drawing.Size(54, 16);
            this.lb_resul.TabIndex = 41;
            this.lb_resul.Text = "lb_resul";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Lime;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(163, 425);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(174, 60);
            this.button1.TabIndex = 40;
            this.button1.Text = "Cadastrar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(249, -35);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(254, 29);
            this.label9.TabIndex = 39;
            this.label9.Text = "Cadastro de Produto";
            // 
            // cbx_unidade
            // 
            this.cbx_unidade.FormattingEnabled = true;
            this.cbx_unidade.Items.AddRange(new object[] {
            "UN",
            "LT",
            "KG"});
            this.cbx_unidade.Location = new System.Drawing.Point(524, 56);
            this.cbx_unidade.Name = "cbx_unidade";
            this.cbx_unidade.Size = new System.Drawing.Size(121, 24);
            this.cbx_unidade.TabIndex = 38;
            // 
            // tx_lucro
            // 
            this.tx_lucro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tx_lucro.Location = new System.Drawing.Point(237, 311);
            this.tx_lucro.Name = "tx_lucro";
            this.tx_lucro.Size = new System.Drawing.Size(100, 22);
            this.tx_lucro.TabIndex = 37;
            // 
            // tx_valor
            // 
            this.tx_valor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tx_valor.Location = new System.Drawing.Point(224, 220);
            this.tx_valor.Name = "tx_valor";
            this.tx_valor.Size = new System.Drawing.Size(100, 22);
            this.tx_valor.TabIndex = 36;
            // 
            // tx_cd
            // 
            this.tx_cd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tx_cd.Location = new System.Drawing.Point(246, 59);
            this.tx_cd.Name = "tx_cd";
            this.tx_cd.Size = new System.Drawing.Size(100, 22);
            this.tx_cd.TabIndex = 35;
            // 
            // tx_descricao
            // 
            this.tx_descricao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tx_descricao.Location = new System.Drawing.Point(274, 148);
            this.tx_descricao.Name = "tx_descricao";
            this.tx_descricao.Size = new System.Drawing.Size(100, 22);
            this.tx_descricao.TabIndex = 34;
            // 
            // tx_confins
            // 
            this.tx_confins.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tx_confins.Location = new System.Drawing.Point(542, 317);
            this.tx_confins.Name = "tx_confins";
            this.tx_confins.Size = new System.Drawing.Size(100, 22);
            this.tx_confins.TabIndex = 33;
            // 
            // tx_icms
            // 
            this.tx_icms.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tx_icms.Location = new System.Drawing.Point(499, 233);
            this.tx_icms.Name = "tx_icms";
            this.tx_icms.Size = new System.Drawing.Size(100, 22);
            this.tx_icms.TabIndex = 32;
            // 
            // tx_pis
            // 
            this.tx_pis.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tx_pis.Location = new System.Drawing.Point(480, 148);
            this.tx_pis.Name = "tx_pis";
            this.tx_pis.Size = new System.Drawing.Size(100, 22);
            this.tx_pis.TabIndex = 31;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(158, 308);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 25);
            this.label8.TabIndex = 30;
            this.label8.Text = "Lucro:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(429, 314);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 25);
            this.label7.TabIndex = 29;
            this.label7.Text = "CONFINS:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(429, 233);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 25);
            this.label5.TabIndex = 28;
            this.label5.Text = "ICMS:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(429, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 25);
            this.label4.TabIndex = 27;
            this.label4.Text = "PIS:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(158, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 25);
            this.label3.TabIndex = 26;
            this.label3.Text = "Valor:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(158, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 25);
            this.label2.TabIndex = 25;
            this.label2.Text = "Descrição:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(429, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 25);
            this.label6.TabIndex = 24;
            this.label6.Text = "Unidade:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(158, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 25);
            this.label1.TabIndex = 23;
            this.label1.Text = "Código:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 522);
            this.Controls.Add(this.lb_resul);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cbx_unidade);
            this.Controls.Add(this.tx_lucro);
            this.Controls.Add(this.tx_valor);
            this.Controls.Add(this.tx_cd);
            this.Controls.Add(this.tx_descricao);
            this.Controls.Add(this.tx_confins);
            this.Controls.Add(this.tx_icms);
            this.Controls.Add(this.tx_pis);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_resul;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbx_unidade;
        private System.Windows.Forms.TextBox tx_lucro;
        private System.Windows.Forms.TextBox tx_valor;
        private System.Windows.Forms.TextBox tx_cd;
        private System.Windows.Forms.TextBox tx_descricao;
        private System.Windows.Forms.TextBox tx_confins;
        private System.Windows.Forms.TextBox tx_icms;
        private System.Windows.Forms.TextBox tx_pis;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
    }
}

