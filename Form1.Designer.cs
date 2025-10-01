namespace WinFormsApp12
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            CreditoCheck = new CheckBox();
            BtnPrice = new TextBox();
            label1 = new Label();
            BtnName = new TextBox();
            label2 = new Label();
            BtnData = new TextBox();
            label3 = new Label();
            button1 = new Button();
            button2 = new Button();
            Saldo = new TextBox();
            label4 = new Label();
            Credito = new TextBox();
            label5 = new Label();
            label6 = new Label();
            DebitoBtn = new TextBox();
            Sair = new Button();
            Salvar = new Button();
            SuspendLayout();
            // 
            // CreditoCheck
            // 
            CreditoCheck.AutoSize = true;
            CreditoCheck.Location = new Point(237, 146);
            CreditoCheck.Name = "CreditoCheck";
            CreditoCheck.Size = new Size(65, 19);
            CreditoCheck.TabIndex = 0;
            CreditoCheck.Text = "Credito";
            CreditoCheck.UseVisualStyleBackColor = true;
            // 
            // BtnPrice
            // 
            BtnPrice.Location = new Point(103, 147);
            BtnPrice.Name = "BtnPrice";
            BtnPrice.Size = new Size(100, 23);
            BtnPrice.TabIndex = 1;
            BtnPrice.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(103, 129);
            label1.Name = "label1";
            label1.Size = new Size(33, 15);
            label1.TabIndex = 2;
            label1.Text = "Valor";
            // 
            // BtnName
            // 
            BtnName.Location = new Point(102, 201);
            BtnName.Name = "BtnName";
            BtnName.Size = new Size(100, 23);
            BtnName.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(103, 183);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 4;
            label2.Text = "Name";
            // 
            // BtnData
            // 
            BtnData.Location = new Point(102, 251);
            BtnData.Name = "BtnData";
            BtnData.Size = new Size(100, 23);
            BtnData.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(103, 236);
            label3.Name = "label3";
            label3.Size = new Size(31, 15);
            label3.TabIndex = 6;
            label3.Text = "Data";
            // 
            // button1
            // 
            button1.Location = new Point(12, 29);
            button1.Name = "button1";
            button1.Size = new Size(100, 23);
            button1.TabIndex = 7;
            button1.Text = "Gravar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(102, 291);
            button2.Name = "button2";
            button2.Size = new Size(100, 23);
            button2.TabIndex = 8;
            button2.Text = "Atualizar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Saldo
            // 
            Saldo.Location = new Point(344, 273);
            Saldo.Name = "Saldo";
            Saldo.Size = new Size(218, 23);
            Saldo.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(344, 246);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 10;
            label4.Text = "Saldo";
            // 
            // Credito
            // 
            Credito.Location = new Point(342, 189);
            Credito.Name = "Credito";
            Credito.Size = new Size(100, 23);
            Credito.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(344, 168);
            label5.Name = "label5";
            label5.Size = new Size(46, 15);
            label5.TabIndex = 12;
            label5.Text = "Credito";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(464, 168);
            label6.Name = "label6";
            label6.Size = new Size(42, 15);
            label6.TabIndex = 14;
            label6.Text = "Debito";
            // 
            // DebitoBtn
            // 
            DebitoBtn.Location = new Point(462, 189);
            DebitoBtn.Name = "DebitoBtn";
            DebitoBtn.Size = new Size(100, 23);
            DebitoBtn.TabIndex = 13;
            // 
            // Sair
            // 
            Sair.Location = new Point(102, 368);
            Sair.Name = "Sair";
            Sair.Size = new Size(100, 23);
            Sair.TabIndex = 15;
            Sair.Text = "Sair";
            Sair.UseVisualStyleBackColor = true;
            Sair.Click += button3_Click;
            // 
            // Salvar
            // 
            Salvar.Location = new Point(102, 330);
            Salvar.Name = "Salvar";
            Salvar.Size = new Size(100, 23);
            Salvar.TabIndex = 16;
            Salvar.Text = "Salvar";
            Salvar.UseVisualStyleBackColor = true;
            Salvar.Click += Salvar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Salvar);
            Controls.Add(Sair);
            Controls.Add(label6);
            Controls.Add(DebitoBtn);
            Controls.Add(label5);
            Controls.Add(Credito);
            Controls.Add(label4);
            Controls.Add(Saldo);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(BtnData);
            Controls.Add(label2);
            Controls.Add(BtnName);
            Controls.Add(label1);
            Controls.Add(BtnPrice);
            Controls.Add(CreditoCheck);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox CreditoCheck;
        private TextBox BtnPrice;
        private Label label1;
        private TextBox BtnName;
        private Label label2;
        private TextBox BtnData;
        private Label label3;
        private Button button1;
        private Button button2;
        private TextBox Saldo;
        private Label label4;
        private TextBox Credito;
        private Label label5;
        private Label label6;
        private TextBox DebitoBtn;
        private Button Sair;
        private Button Salvar;
    }
}
