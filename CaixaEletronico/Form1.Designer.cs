namespace CaixaEletronico
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.textoEndereco = new System.Windows.Forms.TextBox();
            this.edEndereco = new System.Windows.Forms.Label();
            this.textoIdade = new System.Windows.Forms.TextBox();
            this.edIdade = new System.Windows.Forms.Label();
            this.edCPF = new System.Windows.Forms.Label();
            this.textoCPF = new System.Windows.Forms.TextBox();
            this.edTitular = new System.Windows.Forms.Label();
            this.textoTitular = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.textoValor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBanco = new System.Windows.Forms.ComboBox();
            this.textoSaldoConta = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textoNumeroConta = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(421, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(96, 22);
            this.toolStripMenuItem1.Text = "Sair.";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(421, 279);
            this.tabControl1.TabIndex = 10;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.textoEndereco);
            this.tabPage1.Controls.Add(this.edEndereco);
            this.tabPage1.Controls.Add(this.textoIdade);
            this.tabPage1.Controls.Add(this.edIdade);
            this.tabPage1.Controls.Add(this.edCPF);
            this.tabPage1.Controls.Add(this.textoCPF);
            this.tabPage1.Controls.Add(this.edTitular);
            this.tabPage1.Controls.Add(this.textoTitular);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(413, 253);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Cadastro de Titular";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(307, 207);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "Cadastrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textoEndereco
            // 
            this.textoEndereco.Location = new System.Drawing.Point(85, 77);
            this.textoEndereco.Name = "textoEndereco";
            this.textoEndereco.Size = new System.Drawing.Size(297, 20);
            this.textoEndereco.TabIndex = 15;
            // 
            // edEndereco
            // 
            this.edEndereco.AutoSize = true;
            this.edEndereco.Location = new System.Drawing.Point(20, 80);
            this.edEndereco.Name = "edEndereco";
            this.edEndereco.Size = new System.Drawing.Size(59, 13);
            this.edEndereco.TabIndex = 14;
            this.edEndereco.Text = "Endereço: ";
            // 
            // textoIdade
            // 
            this.textoIdade.Location = new System.Drawing.Point(282, 51);
            this.textoIdade.Name = "textoIdade";
            this.textoIdade.Size = new System.Drawing.Size(100, 20);
            this.textoIdade.TabIndex = 13;
            // 
            // edIdade
            // 
            this.edIdade.AutoSize = true;
            this.edIdade.Location = new System.Drawing.Point(239, 54);
            this.edIdade.Name = "edIdade";
            this.edIdade.Size = new System.Drawing.Size(37, 13);
            this.edIdade.TabIndex = 12;
            this.edIdade.Text = "Idade:";
            // 
            // edCPF
            // 
            this.edCPF.AutoSize = true;
            this.edCPF.Location = new System.Drawing.Point(20, 54);
            this.edCPF.Name = "edCPF";
            this.edCPF.Size = new System.Drawing.Size(30, 13);
            this.edCPF.TabIndex = 11;
            this.edCPF.Text = "CPF:";
            // 
            // textoCPF
            // 
            this.textoCPF.Location = new System.Drawing.Point(56, 51);
            this.textoCPF.Name = "textoCPF";
            this.textoCPF.Size = new System.Drawing.Size(177, 20);
            this.textoCPF.TabIndex = 10;
            // 
            // edTitular
            // 
            this.edTitular.AutoSize = true;
            this.edTitular.Location = new System.Drawing.Point(20, 28);
            this.edTitular.Name = "edTitular";
            this.edTitular.Size = new System.Drawing.Size(84, 13);
            this.edTitular.TabIndex = 9;
            this.edTitular.Text = "Titular da conta:";
            // 
            // textoTitular
            // 
            this.textoTitular.Location = new System.Drawing.Point(110, 25);
            this.textoTitular.Name = "textoTitular";
            this.textoTitular.Size = new System.Drawing.Size(272, 20);
            this.textoTitular.TabIndex = 8;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.textoNumeroConta);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.textoSaldoConta);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.comboBanco);
            this.tabPage2.Controls.Add(this.button4);
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Controls.Add(this.textoValor);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(413, 253);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Operações.";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(272, 187);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(108, 23);
            this.button4.TabIndex = 4;
            this.button4.Text = "Saque";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(147, 187);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(108, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Deposita";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textoValor
            // 
            this.textoValor.Location = new System.Drawing.Point(123, 144);
            this.textoValor.Name = "textoValor";
            this.textoValor.Size = new System.Drawing.Size(140, 20);
            this.textoValor.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Valor da operação:  ";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(17, 187);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 23);
            this.button2.TabIndex = 0;
            this.button2.Text = "Saldo da conta";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboBanco
            // 
            this.comboBanco.FormattingEnabled = true;
            this.comboBanco.Location = new System.Drawing.Point(17, 17);
            this.comboBanco.Name = "comboBanco";
            this.comboBanco.Size = new System.Drawing.Size(363, 21);
            this.comboBanco.TabIndex = 5;
            this.comboBanco.SelectedIndexChanged += new System.EventHandler(this.comboBanco_SelectedIndexChanged);
            // 
            // textoSaldoConta
            // 
            this.textoSaldoConta.Location = new System.Drawing.Point(105, 54);
            this.textoSaldoConta.Name = "textoSaldoConta";
            this.textoSaldoConta.Size = new System.Drawing.Size(158, 20);
            this.textoSaldoConta.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Saldo da conta: ";
            // 
            // textoNumeroConta
            // 
            this.textoNumeroConta.Location = new System.Drawing.Point(109, 96);
            this.textoNumeroConta.Name = "textoNumeroConta";
            this.textoNumeroConta.Size = new System.Drawing.Size(154, 20);
            this.textoNumeroConta.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Número da conta: ";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(421, 304);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox textoEndereco;
        private System.Windows.Forms.Label edEndereco;
        private System.Windows.Forms.TextBox textoIdade;
        private System.Windows.Forms.Label edIdade;
        private System.Windows.Forms.Label edCPF;
        private System.Windows.Forms.TextBox textoCPF;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.Label edTitular;
        public System.Windows.Forms.TextBox textoTitular;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textoValor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textoNumeroConta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textoSaldoConta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBanco;
    }
}

