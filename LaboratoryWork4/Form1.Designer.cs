namespace LaboratoryWork4
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.Argument = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Result3 = new System.Windows.Forms.TextBox();
            this.Result2 = new System.Windows.Forms.TextBox();
            this.Result1 = new System.Windows.Forms.TextBox();
            this.Calculate1 = new System.Windows.Forms.Button();
            this.Calculate2 = new System.Windows.Forms.Button();
            this.Calculate3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 17);
            this.label1.TabIndex = 21;
            this.label1.Text = "Введите значение аргумента:";
            // 
            // Argument
            // 
            this.Argument.Location = new System.Drawing.Point(257, 23);
            this.Argument.Name = "Argument";
            this.Argument.Size = new System.Drawing.Size(100, 22);
            this.Argument.TabIndex = 20;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(11, 232);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(225, 66);
            this.pictureBox3.TabIndex = 19;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 147);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(160, 79);
            this.pictureBox2.TabIndex = 18;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(11, 70);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(176, 71);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // Result3
            // 
            this.Result3.Location = new System.Drawing.Point(257, 250);
            this.Result3.Name = "Result3";
            this.Result3.Size = new System.Drawing.Size(276, 22);
            this.Result3.TabIndex = 16;
            // 
            // Result2
            // 
            this.Result2.Location = new System.Drawing.Point(257, 174);
            this.Result2.Name = "Result2";
            this.Result2.Size = new System.Drawing.Size(276, 22);
            this.Result2.TabIndex = 15;
            // 
            // Result1
            // 
            this.Result1.Location = new System.Drawing.Point(257, 97);
            this.Result1.Name = "Result1";
            this.Result1.Size = new System.Drawing.Size(276, 22);
            this.Result1.TabIndex = 14;
            // 
            // Calculate1
            // 
            this.Calculate1.Location = new System.Drawing.Point(539, 97);
            this.Calculate1.Name = "Calculate1";
            this.Calculate1.Size = new System.Drawing.Size(96, 23);
            this.Calculate1.TabIndex = 11;
            this.Calculate1.Text = "Вычислить";
            this.Calculate1.UseVisualStyleBackColor = true;
            this.Calculate1.Click += new System.EventHandler(this.Calculate1_Click);
            // 
            // Calculate2
            // 
            this.Calculate2.Location = new System.Drawing.Point(539, 174);
            this.Calculate2.Name = "Calculate2";
            this.Calculate2.Size = new System.Drawing.Size(96, 23);
            this.Calculate2.TabIndex = 22;
            this.Calculate2.Text = "Вычислить";
            this.Calculate2.UseVisualStyleBackColor = true;
            this.Calculate2.Click += new System.EventHandler(this.Calculate2_Click);
            // 
            // Calculate3
            // 
            this.Calculate3.Location = new System.Drawing.Point(539, 250);
            this.Calculate3.Name = "Calculate3";
            this.Calculate3.Size = new System.Drawing.Size(96, 23);
            this.Calculate3.TabIndex = 23;
            this.Calculate3.Text = "Вычислить";
            this.Calculate3.UseVisualStyleBackColor = true;
            this.Calculate3.Click += new System.EventHandler(this.Calculate3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 310);
            this.Controls.Add(this.Calculate3);
            this.Controls.Add(this.Calculate2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Argument);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Result3);
            this.Controls.Add(this.Result2);
            this.Controls.Add(this.Result1);
            this.Controls.Add(this.Calculate1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Argument;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox Result3;
        private System.Windows.Forms.TextBox Result2;
        private System.Windows.Forms.TextBox Result1;
        private System.Windows.Forms.Button Calculate1;
        private System.Windows.Forms.Button Calculate2;
        private System.Windows.Forms.Button Calculate3;
    }
}

