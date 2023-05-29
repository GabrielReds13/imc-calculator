namespace IMCCalc
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Btn_calculate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Txt_result = new System.Windows.Forms.Label();
            this.Txt_name = new System.Windows.Forms.TextBox();
            this.Txt_age = new System.Windows.Forms.TextBox();
            this.Txt_height = new System.Windows.Forms.TextBox();
            this.Txt_weight = new System.Windows.Forms.TextBox();
            this.Txt_cpf = new System.Windows.Forms.MaskedTextBox();
            this.Select_sex = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::IMCCalc.Properties.Resources.Fitness;
            this.pictureBox1.Location = new System.Drawing.Point(187, -6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(346, 286);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Btn_calculate
            // 
            this.Btn_calculate.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.Btn_calculate.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_calculate.ForeColor = System.Drawing.Color.White;
            this.Btn_calculate.Location = new System.Drawing.Point(23, 198);
            this.Btn_calculate.Name = "Btn_calculate";
            this.Btn_calculate.Size = new System.Drawing.Size(248, 32);
            this.Btn_calculate.TabIndex = 1;
            this.Btn_calculate.Text = "Calculate";
            this.Btn_calculate.UseVisualStyleBackColor = false;
            this.Btn_calculate.Click += new System.EventHandler(this.Btn_calculate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "CPF:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(146, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Sex:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Weight:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(109, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Height:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(198, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 16);
            this.label6.TabIndex = 7;
            this.label6.Text = "Age:";
            // 
            // Txt_result
            // 
            this.Txt_result.AutoSize = true;
            this.Txt_result.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_result.Location = new System.Drawing.Point(21, 245);
            this.Txt_result.Name = "Txt_result";
            this.Txt_result.Size = new System.Drawing.Size(76, 15);
            this.Txt_result.TabIndex = 8;
            this.Txt_result.Text = "Lorem ipsum.";
            // 
            // Txt_name
            // 
            this.Txt_name.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_name.Location = new System.Drawing.Point(23, 71);
            this.Txt_name.Name = "Txt_name";
            this.Txt_name.Size = new System.Drawing.Size(247, 21);
            this.Txt_name.TabIndex = 9;
            // 
            // Txt_age
            // 
            this.Txt_age.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_age.Location = new System.Drawing.Point(201, 162);
            this.Txt_age.Name = "Txt_age";
            this.Txt_age.Size = new System.Drawing.Size(69, 21);
            this.Txt_age.TabIndex = 10;
            // 
            // Txt_height
            // 
            this.Txt_height.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_height.Location = new System.Drawing.Point(112, 162);
            this.Txt_height.Name = "Txt_height";
            this.Txt_height.Size = new System.Drawing.Size(69, 21);
            this.Txt_height.TabIndex = 11;
            // 
            // Txt_weight
            // 
            this.Txt_weight.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_weight.Location = new System.Drawing.Point(23, 162);
            this.Txt_weight.Name = "Txt_weight";
            this.Txt_weight.Size = new System.Drawing.Size(69, 21);
            this.Txt_weight.TabIndex = 12;
            // 
            // Txt_cpf
            // 
            this.Txt_cpf.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_cpf.Location = new System.Drawing.Point(23, 111);
            this.Txt_cpf.Mask = "000,000,000-00";
            this.Txt_cpf.Name = "Txt_cpf";
            this.Txt_cpf.Size = new System.Drawing.Size(120, 21);
            this.Txt_cpf.TabIndex = 13;
            // 
            // Select_sex
            // 
            this.Select_sex.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Select_sex.FormattingEnabled = true;
            this.Select_sex.Items.AddRange(new object[] {
            "Man",
            "Woman",
            "Other"});
            this.Select_sex.Location = new System.Drawing.Point(149, 111);
            this.Select_sex.Name = "Select_sex";
            this.Select_sex.Size = new System.Drawing.Size(121, 24);
            this.Select_sex.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(64, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(165, 25);
            this.label8.TabIndex = 15;
            this.label8.Text = "IMC Calculator";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 272);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Select_sex);
            this.Controls.Add(this.Txt_cpf);
            this.Controls.Add(this.Txt_weight);
            this.Controls.Add(this.Txt_height);
            this.Controls.Add(this.Txt_age);
            this.Controls.Add(this.Txt_name);
            this.Controls.Add(this.Txt_result);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btn_calculate);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Btn_calculate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label Txt_result;
        private System.Windows.Forms.TextBox Txt_name;
        private System.Windows.Forms.TextBox Txt_age;
        private System.Windows.Forms.TextBox Txt_height;
        private System.Windows.Forms.TextBox Txt_weight;
        private System.Windows.Forms.MaskedTextBox Txt_cpf;
        private System.Windows.Forms.ComboBox Select_sex;
        private System.Windows.Forms.Label label8;
    }
}

