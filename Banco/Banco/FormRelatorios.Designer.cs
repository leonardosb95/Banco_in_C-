namespace Banco
{
    partial class FormRelatorios
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
            this.listaResultado = new System.Windows.Forms.ListBox();
            this.botaoFiltraSaldo = new System.Windows.Forms.Button();
            this.botaoFiltraConta = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelSaldoTotal = new System.Windows.Forms.Label();
            this.labelMaiorSaldo = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listaResultado
            // 
            this.listaResultado.FormattingEnabled = true;
            this.listaResultado.Location = new System.Drawing.Point(12, 12);
            this.listaResultado.Name = "listaResultado";
            this.listaResultado.Size = new System.Drawing.Size(412, 95);
            this.listaResultado.TabIndex = 0;
            // 
            // botaoFiltraSaldo
            // 
            this.botaoFiltraSaldo.Location = new System.Drawing.Point(6, 132);
            this.botaoFiltraSaldo.Name = "botaoFiltraSaldo";
            this.botaoFiltraSaldo.Size = new System.Drawing.Size(93, 41);
            this.botaoFiltraSaldo.TabIndex = 1;
            this.botaoFiltraSaldo.Text = "Saldo menor que 5000";
            this.botaoFiltraSaldo.UseVisualStyleBackColor = true;
            this.botaoFiltraSaldo.Click += new System.EventHandler(this.botaoFiltraSaldo_Click);
            // 
            // botaoFiltraConta
            // 
            this.botaoFiltraConta.Location = new System.Drawing.Point(299, 132);
            this.botaoFiltraConta.Name = "botaoFiltraConta";
            this.botaoFiltraConta.Size = new System.Drawing.Size(95, 41);
            this.botaoFiltraConta.TabIndex = 2;
            this.botaoFiltraConta.Text = "Contas antigas com saldo maior que 1000";
            this.botaoFiltraConta.UseVisualStyleBackColor = true;
            this.botaoFiltraConta.Click += new System.EventHandler(this.botaoFiltraConta_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelMaiorSaldo);
            this.groupBox1.Controls.Add(this.labelSaldoTotal);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.botaoFiltraSaldo);
            this.groupBox1.Controls.Add(this.botaoFiltraConta);
            this.groupBox1.Location = new System.Drawing.Point(12, 130);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(412, 190);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Resumo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Saldo Total";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Maior Saldo";
            // 
            // labelSaldoTotal
            // 
            this.labelSaldoTotal.AutoSize = true;
            this.labelSaldoTotal.Location = new System.Drawing.Point(270, 25);
            this.labelSaldoTotal.Name = "labelSaldoTotal";
            this.labelSaldoTotal.Size = new System.Drawing.Size(16, 13);
            this.labelSaldoTotal.TabIndex = 5;
            this.labelSaldoTotal.Text = "...";
            // 
            // labelMaiorSaldo
            // 
            this.labelMaiorSaldo.AutoSize = true;
            this.labelMaiorSaldo.Location = new System.Drawing.Point(270, 84);
            this.labelMaiorSaldo.Name = "labelMaiorSaldo";
            this.labelMaiorSaldo.Size = new System.Drawing.Size(19, 13);
            this.labelMaiorSaldo.TabIndex = 6;
            this.labelMaiorSaldo.Text = "....";
            // 
            // FormRelatorios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 366);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listaResultado);
            this.Name = "FormRelatorios";
            this.Text = "FormRelatorios";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listaResultado;
        private System.Windows.Forms.Button botaoFiltraSaldo;
        private System.Windows.Forms.Button botaoFiltraConta;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelMaiorSaldo;
        private System.Windows.Forms.Label labelSaldoTotal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}