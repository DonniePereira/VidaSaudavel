namespace VidaSaudavel
{
    partial class PesoIdeal
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
            label1 = new Label();
            label2 = new Label();
            txtAltura = new TextBox();
            button1 = new Button();
            cmbSexo = new ComboBox();
            txtNome = new TextBox();
            label3 = new Label();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(72, 81);
            label1.Name = "label1";
            label1.Size = new Size(52, 21);
            label1.TabIndex = 0;
            label1.Text = "Altura";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(213, 81);
            label2.Name = "label2";
            label2.Size = new Size(43, 21);
            label2.TabIndex = 1;
            label2.Text = "Sexo";
            // 
            // txtAltura
            // 
            txtAltura.Location = new Point(37, 116);
            txtAltura.Name = "txtAltura";
            txtAltura.Size = new Size(107, 23);
            txtAltura.TabIndex = 2;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(37, 189);
            button1.Name = "button1";
            button1.Size = new Size(178, 58);
            button1.TabIndex = 4;
            button1.Text = "&Peso Ideal";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // cmbSexo
            // 
            cmbSexo.FormattingEnabled = true;
            cmbSexo.Items.AddRange(new object[] { "Feminino", "Masculino" });
            cmbSexo.Location = new Point(173, 116);
            cmbSexo.Name = "cmbSexo";
            cmbSexo.Size = new Size(121, 23);
            cmbSexo.TabIndex = 5;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(37, 43);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(257, 23);
            txtNome.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(139, 19);
            label3.Name = "label3";
            label3.Size = new Size(53, 21);
            label3.TabIndex = 7;
            label3.Text = "Nome";
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(37, 269);
            button2.Name = "button2";
            button2.Size = new Size(178, 58);
            button2.TabIndex = 8;
            button2.Text = "&Limpar";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Transparent;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.Location = new Point(37, 348);
            button3.Name = "button3";
            button3.Size = new Size(178, 58);
            button3.TabIndex = 9;
            button3.Text = "Sai&r";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // PesoIdeal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Como_Saber_tu_Peso_Ideal_segun_Altura_y_Edad;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label3);
            Controls.Add(txtNome);
            Controls.Add(cmbSexo);
            Controls.Add(button1);
            Controls.Add(txtAltura);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "PesoIdeal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PesoIdeal";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtAltura;
        private Button button1;
        private ComboBox cmbSexo;
        private TextBox txtNome;
        private Label label3;
        private Button button2;
        private Button button3;
    }
}