namespace HelloWorld
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
            this.lbl_f = new System.Windows.Forms.Label();
            this.lbl_c = new System.Windows.Forms.Label();
            this.lbl_k = new System.Windows.Forms.Label();
            this.txt_f = new System.Windows.Forms.TextBox();
            this.txt_c = new System.Windows.Forms.TextBox();
            this.txt_k = new System.Windows.Forms.TextBox();
            this.btn_f = new System.Windows.Forms.Button();
            this.btn_c = new System.Windows.Forms.Button();
            this.btn_k = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_f
            // 
            this.lbl_f.AutoSize = true;
            this.lbl_f.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_f.Location = new System.Drawing.Point(53, 122);
            this.lbl_f.Name = "lbl_f";
            this.lbl_f.Size = new System.Drawing.Size(88, 20);
            this.lbl_f.TabIndex = 0;
            this.lbl_f.Text = "Fahrenheit";
            // 
            // lbl_c
            // 
            this.lbl_c.AutoSize = true;
            this.lbl_c.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_c.Location = new System.Drawing.Point(72, 166);
            this.lbl_c.Name = "lbl_c";
            this.lbl_c.Size = new System.Drawing.Size(65, 20);
            this.lbl_c.TabIndex = 1;
            this.lbl_c.Text = "Celsius";
            // 
            // lbl_k
            // 
            this.lbl_k.AutoSize = true;
            this.lbl_k.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_k.Location = new System.Drawing.Point(80, 210);
            this.lbl_k.Name = "lbl_k";
            this.lbl_k.Size = new System.Drawing.Size(54, 20);
            this.lbl_k.TabIndex = 2;
            this.lbl_k.Text = "Kelvin";
            // 
            // txt_f
            // 
            this.txt_f.Location = new System.Drawing.Point(153, 124);
            this.txt_f.Name = "txt_f";
            this.txt_f.Size = new System.Drawing.Size(182, 22);
            this.txt_f.TabIndex = 3;
            this.txt_f.TextChanged += new System.EventHandler(this.txt_f_TextChanged);
            // 
            // txt_c
            // 
            this.txt_c.Location = new System.Drawing.Point(153, 166);
            this.txt_c.Name = "txt_c";
            this.txt_c.Size = new System.Drawing.Size(182, 22);
            this.txt_c.TabIndex = 4;
            // 
            // txt_k
            // 
            this.txt_k.Location = new System.Drawing.Point(153, 208);
            this.txt_k.Name = "txt_k";
            this.txt_k.Size = new System.Drawing.Size(182, 22);
            this.txt_k.TabIndex = 5;
            // 
            // btn_f
            // 
            this.btn_f.Location = new System.Drawing.Point(360, 123);
            this.btn_f.Name = "btn_f";
            this.btn_f.Size = new System.Drawing.Size(75, 23);
            this.btn_f.TabIndex = 6;
            this.btn_f.Text = "Convert";
            this.btn_f.UseVisualStyleBackColor = true;
            this.btn_f.Click += new System.EventHandler(this.btn_f_Click);
            // 
            // btn_c
            // 
            this.btn_c.Location = new System.Drawing.Point(358, 165);
            this.btn_c.Name = "btn_c";
            this.btn_c.Size = new System.Drawing.Size(75, 23);
            this.btn_c.TabIndex = 7;
            this.btn_c.Text = "Convert";
            this.btn_c.UseVisualStyleBackColor = true;
            this.btn_c.Click += new System.EventHandler(this.btn_c_Click);
            // 
            // btn_k
            // 
            this.btn_k.Location = new System.Drawing.Point(358, 207);
            this.btn_k.Name = "btn_k";
            this.btn_k.Size = new System.Drawing.Size(75, 23);
            this.btn_k.TabIndex = 8;
            this.btn_k.Text = "Convert";
            this.btn_k.UseVisualStyleBackColor = true;
            this.btn_k.Click += new System.EventHandler(this.btn_k_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 372);
            this.Controls.Add(this.btn_k);
            this.Controls.Add(this.btn_c);
            this.Controls.Add(this.btn_f);
            this.Controls.Add(this.txt_k);
            this.Controls.Add(this.txt_c);
            this.Controls.Add(this.txt_f);
            this.Controls.Add(this.lbl_k);
            this.Controls.Add(this.lbl_c);
            this.Controls.Add(this.lbl_f);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_f;
        private System.Windows.Forms.Label lbl_c;
        private System.Windows.Forms.Label lbl_k;
        private System.Windows.Forms.TextBox txt_f;
        private System.Windows.Forms.TextBox txt_c;
        private System.Windows.Forms.TextBox txt_k;
        private System.Windows.Forms.Button btn_f;
        private System.Windows.Forms.Button btn_c;
        private System.Windows.Forms.Button btn_k;
    }
}

