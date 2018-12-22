namespace Banco
{
    partial class Form1
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
            this.botaoDeposita = new System.Windows.Forms.Button();
            this.botaoSaca = new System.Windows.Forms.Button();
            this.TextoSaldo = new System.Windows.Forms.TextBox();
            this.TextoTitular = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TextoNumero = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.TextoValor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TextoSaldoTotal = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.comboIndice = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.botaoTransferenciaDestino = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.comboDestinoTransferencia = new System.Windows.Forms.ComboBox();
            this.botaoNovaConta = new System.Windows.Forms.Button();
            this.botaoImpostos = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // botaoDeposita
            // 
            this.botaoDeposita.Location = new System.Drawing.Point(17, 215);
            this.botaoDeposita.Name = "botaoDeposita";
            this.botaoDeposita.Size = new System.Drawing.Size(75, 23);
            this.botaoDeposita.TabIndex = 0;
            this.botaoDeposita.Text = "Depositar";
            this.botaoDeposita.UseVisualStyleBackColor = true;
            this.botaoDeposita.Click += new System.EventHandler(this.botaoDeposita_Click);
            // 
            // botaoSaca
            // 
            this.botaoSaca.Location = new System.Drawing.Point(130, 215);
            this.botaoSaca.Name = "botaoSaca";
            this.botaoSaca.Size = new System.Drawing.Size(100, 23);
            this.botaoSaca.TabIndex = 1;
            this.botaoSaca.Text = "Saca";
            this.botaoSaca.UseVisualStyleBackColor = true;
            this.botaoSaca.Click += new System.EventHandler(this.botaoSaca_Click);
            // 
            // TextoSaldo
            // 
            this.TextoSaldo.Location = new System.Drawing.Point(130, 123);
            this.TextoSaldo.Name = "TextoSaldo";
            this.TextoSaldo.Size = new System.Drawing.Size(100, 20);
            this.TextoSaldo.TabIndex = 2;
            // 
            // TextoTitular
            // 
            this.TextoTitular.Location = new System.Drawing.Point(130, 19);
            this.TextoTitular.Name = "TextoTitular";
            this.TextoTitular.Size = new System.Drawing.Size(100, 20);
            this.TextoTitular.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Titular";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Numero";
            // 
            // TextoNumero
            // 
            this.TextoNumero.Location = new System.Drawing.Point(130, 71);
            this.TextoNumero.Name = "TextoNumero";
            this.TextoNumero.Size = new System.Drawing.Size(100, 20);
            this.TextoNumero.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(250, 215);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Cadastrar cliente";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Saldo";
            // 
            // TextoValor
            // 
            this.TextoValor.Location = new System.Drawing.Point(130, 168);
            this.TextoValor.Name = "TextoValor";
            this.TextoValor.Size = new System.Drawing.Size(100, 20);
            this.TextoValor.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Valor";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TextoNumero);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.botaoDeposita);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.TextoValor);
            this.groupBox1.Controls.Add(this.botaoSaca);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TextoSaldo);
            this.groupBox1.Controls.Add(this.TextoTitular);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(63, 107);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(341, 263);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Conta";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TextoSaldoTotal);
            this.groupBox2.Location = new System.Drawing.Point(346, 1);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Totalizador de contas";
            // 
            // TextoSaldoTotal
            // 
            this.TextoSaldoTotal.Location = new System.Drawing.Point(37, 38);
            this.TextoSaldoTotal.Name = "TextoSaldoTotal";
            this.TextoSaldoTotal.Size = new System.Drawing.Size(100, 20);
            this.TextoSaldoTotal.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.comboIndice);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(63, 1);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(263, 90);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Busca de conta";
            // 
            // comboIndice
            // 
            this.comboIndice.FormattingEnabled = true;
            this.comboIndice.Location = new System.Drawing.Point(109, 32);
            this.comboIndice.Name = "comboIndice";
            this.comboIndice.Size = new System.Drawing.Size(121, 21);
            this.comboIndice.TabIndex = 3;
            this.comboIndice.SelectedIndexChanged += new System.EventHandler(this.comboIndice_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Escolha a conta";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.botaoTransferenciaDestino);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.comboDestinoTransferencia);
            this.groupBox4.Location = new System.Drawing.Point(426, 107);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(212, 117);
            this.groupBox4.TabIndex = 14;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Transferência";
            // 
            // botaoTransferenciaDestino
            // 
            this.botaoTransferenciaDestino.Location = new System.Drawing.Point(85, 78);
            this.botaoTransferenciaDestino.Name = "botaoTransferenciaDestino";
            this.botaoTransferenciaDestino.Size = new System.Drawing.Size(85, 23);
            this.botaoTransferenciaDestino.TabIndex = 15;
            this.botaoTransferenciaDestino.Text = "Transferir";
            this.botaoTransferenciaDestino.UseVisualStyleBackColor = true;
            this.botaoTransferenciaDestino.Click += new System.EventHandler(this.botaoTransferenciaDestino_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Conta destino";
            // 
            // comboDestinoTransferencia
            // 
            this.comboDestinoTransferencia.FormattingEnabled = true;
            this.comboDestinoTransferencia.Location = new System.Drawing.Point(85, 26);
            this.comboDestinoTransferencia.Name = "comboDestinoTransferencia";
            this.comboDestinoTransferencia.Size = new System.Drawing.Size(121, 21);
            this.comboDestinoTransferencia.TabIndex = 4;
            // 
            // botaoNovaConta
            // 
            this.botaoNovaConta.Location = new System.Drawing.Point(569, 346);
            this.botaoNovaConta.Name = "botaoNovaConta";
            this.botaoNovaConta.Size = new System.Drawing.Size(85, 23);
            this.botaoNovaConta.TabIndex = 16;
            this.botaoNovaConta.Text = "Nova Conta";
            this.botaoNovaConta.UseVisualStyleBackColor = true;
            this.botaoNovaConta.Click += new System.EventHandler(this.botaoNovaConta_Click);
            // 
            // botaoImpostos
            // 
            this.botaoImpostos.Location = new System.Drawing.Point(426, 346);
            this.botaoImpostos.Name = "botaoImpostos";
            this.botaoImpostos.Size = new System.Drawing.Size(107, 23);
            this.botaoImpostos.TabIndex = 17;
            this.botaoImpostos.Text = "Calcula impostos";
            this.botaoImpostos.UseVisualStyleBackColor = true;
            this.botaoImpostos.Click += new System.EventHandler(this.botaoImpostos_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 381);
            this.Controls.Add(this.botaoImpostos);
            this.Controls.Add(this.botaoNovaConta);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button botaoDeposita;
        private System.Windows.Forms.Button botaoSaca;
        private System.Windows.Forms.TextBox TextoSaldo;
        private System.Windows.Forms.TextBox TextoTitular;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TextoNumero;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TextoValor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox TextoSaldoTotal;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboIndice;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox comboDestinoTransferencia;
        private System.Windows.Forms.Button botaoTransferenciaDestino;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button botaoNovaConta;
        private System.Windows.Forms.Button botaoImpostos;
    }
}

