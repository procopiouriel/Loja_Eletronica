namespace Loja_de_Eletronicos
{
    partial class Cadastrar_Produto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cadastrar_Produto));
            but_salvar = new Button();
            label1 = new Label();
            box_valor = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            box_df = new MaskedTextBox();
            tx_qtd = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            button1 = new Button();
            label11 = new Label();
            label12 = new Label();
            button2 = new Button();
            label13 = new Label();
            txt_nome = new TextBox();
            txt_id = new TextBox();
            SuspendLayout();
            // 
            // but_salvar
            // 
            but_salvar.BackColor = Color.LightGreen;
            but_salvar.FlatStyle = FlatStyle.Popup;
            but_salvar.Font = new Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point);
            but_salvar.ForeColor = SystemColors.ActiveCaptionText;
            but_salvar.Location = new Point(98, 243);
            but_salvar.Margin = new Padding(3, 2, 3, 2);
            but_salvar.Name = "but_salvar";
            but_salvar.Size = new Size(127, 34);
            but_salvar.TabIndex = 0;
            but_salvar.Text = "Salvar";
            but_salvar.UseVisualStyleBackColor = false;
            but_salvar.Click += but_salvar_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(41, 89);
            label1.Name = "label1";
            label1.Size = new Size(0, 25);
            label1.TabIndex = 1;
            // 
            // box_valor
            // 
            box_valor.BackColor = SystemColors.InactiveCaption;
            box_valor.BorderStyle = BorderStyle.FixedSingle;
            box_valor.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            box_valor.Location = new Point(136, 205);
            box_valor.Margin = new Padding(3, 2, 3, 2);
            box_valor.Name = "box_valor";
            box_valor.Size = new Size(246, 23);
            box_valor.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(41, 153);
            label2.Name = "label2";
            label2.Size = new Size(0, 25);
            label2.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(41, 121);
            label3.Name = "label3";
            label3.Size = new Size(0, 25);
            label3.TabIndex = 5;
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(194, 155);
            label4.Name = "label4";
            label4.Size = new Size(0, 25);
            label4.TabIndex = 7;
            // 
            // box_df
            // 
            box_df.BackColor = SystemColors.InactiveCaption;
            box_df.BorderStyle = BorderStyle.FixedSingle;
            box_df.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            box_df.Location = new Point(241, 103);
            box_df.Margin = new Padding(3, 2, 3, 2);
            box_df.Mask = "00/00/0000";
            box_df.Name = "box_df";
            box_df.Size = new Size(96, 23);
            box_df.TabIndex = 9;
            box_df.ValidatingType = typeof(DateTime);
            // 
            // tx_qtd
            // 
            tx_qtd.BackColor = SystemColors.InactiveCaption;
            tx_qtd.BorderStyle = BorderStyle.FixedSingle;
            tx_qtd.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tx_qtd.Location = new Point(192, 136);
            tx_qtd.Margin = new Padding(3, 2, 3, 2);
            tx_qtd.Name = "tx_qtd";
            tx_qtd.Size = new Size(60, 23);
            tx_qtd.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(136, 92);
            label5.Name = "label5";
            label5.Size = new Size(0, 25);
            label5.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.LightSteelBlue;
            label6.Location = new Point(69, 205);
            label6.Name = "label6";
            label6.Size = new Size(64, 19);
            label6.TabIndex = 13;
            label6.Text = "Valor:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.LightSteelBlue;
            label8.Location = new Point(69, 136);
            label8.Name = "label8";
            label8.Size = new Size(111, 19);
            label8.TabIndex = 15;
            label8.Text = "Quantidade:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = Color.LightSteelBlue;
            label9.Location = new Point(69, 104);
            label9.Name = "label9";
            label9.Size = new Size(30, 19);
            label9.TabIndex = 16;
            label9.Text = "Id:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label10.ForeColor = Color.LightSteelBlue;
            label10.Location = new Point(178, 103);
            label10.Name = "label10";
            label10.Size = new Size(54, 19);
            label10.TabIndex = 17;
            label10.Text = "Data:";
            // 
            // button1
            // 
            button1.BackColor = Color.LightCoral;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Stencil", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(255, 242);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(127, 34);
            button1.TabIndex = 18;
            button1.Text = "Cancelar\r\n";
            button1.UseVisualStyleBackColor = false;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(139, 158);
            label11.Margin = new Padding(2, 0, 2, 0);
            label11.Name = "label11";
            label11.Size = new Size(0, 15);
            label11.TabIndex = 19;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.Transparent;
            label12.Font = new Font("Stencil", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label12.ForeColor = Color.LightSteelBlue;
            label12.Location = new Point(88, 54);
            label12.Name = "label12";
            label12.Size = new Size(263, 29);
            label12.TabIndex = 20;
            label12.Text = "CADASTRAR PRODUTO";
            // 
            // button2
            // 
            button2.BackColor = SystemColors.AppWorkspace;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(178, 287);
            button2.Margin = new Padding(2);
            button2.Name = "button2";
            button2.Size = new Size(127, 34);
            button2.TabIndex = 21;
            button2.Text = "menu";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click_1;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.Transparent;
            label13.Font = new Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label13.ForeColor = Color.LightSteelBlue;
            label13.Location = new Point(66, 170);
            label13.Name = "label13";
            label13.Size = new Size(57, 19);
            label13.TabIndex = 22;
            label13.Text = "Nome:";
            // 
            // txt_nome
            // 
            txt_nome.BackColor = SystemColors.InactiveCaption;
            txt_nome.BorderStyle = BorderStyle.FixedSingle;
            txt_nome.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txt_nome.Location = new Point(132, 170);
            txt_nome.Margin = new Padding(3, 2, 3, 2);
            txt_nome.Name = "txt_nome";
            txt_nome.Size = new Size(250, 23);
            txt_nome.TabIndex = 23;
            // 
            // txt_id
            // 
            txt_id.BackColor = SystemColors.InactiveCaption;
            txt_id.BorderStyle = BorderStyle.FixedSingle;
            txt_id.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txt_id.Location = new Point(98, 100);
            txt_id.Margin = new Padding(3, 2, 3, 2);
            txt_id.Name = "txt_id";
            txt_id.Size = new Size(60, 23);
            txt_id.TabIndex = 24;
            // 
            // Cadastrar_Produto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(453, 362);
            Controls.Add(txt_id);
            Controls.Add(txt_nome);
            Controls.Add(label13);
            Controls.Add(button2);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(button1);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label6);
            Controls.Add(tx_qtd);
            Controls.Add(label5);
            Controls.Add(box_df);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(box_valor);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(but_salvar);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Cadastrar_Produto";
            Text = "Cadastrar_Produto";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button but_salvar;
        private Label label1;
        private TextBox box_valor;
        private Label label2;
        private Label label3;
        private Label label4;
        private MaskedTextBox box_df;
        private TextBox tx_qtd;
        private Label label5;
        private Label label6;
        private Label label8;
        private Label label9;
        private Label label10;
        private Button button1;
        private Label label11;
        private Label label12;
        private Button button2;
        private Label label13;
        private TextBox txt_nome;
        private TextBox txt_id;
    }
}