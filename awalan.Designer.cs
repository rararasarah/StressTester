namespace StresTester
{
    partial class awalan
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
            this.lblTitle1 = new System.Windows.Forms.Label();
            this.lblTitle2 = new System.Windows.Forms.Label();
            this.tbNama = new System.Windows.Forms.TextBox();
            this.btnNext = new System.Windows.Forms.Button();
            this.lblNanya = new System.Windows.Forms.Label();
            this.tbUmur = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rb1 = new System.Windows.Forms.RadioButton();
            this.rb2 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // lblTitle1
            // 
            this.lblTitle1.AutoSize = true;
            this.lblTitle1.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle1.Font = new System.Drawing.Font("Le Sofia", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle1.ForeColor = System.Drawing.Color.Tomato;
            this.lblTitle1.Location = new System.Drawing.Point(286, 42);
            this.lblTitle1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle1.Name = "lblTitle1";
            this.lblTitle1.Size = new System.Drawing.Size(217, 92);
            this.lblTitle1.TabIndex = 0;
            this.lblTitle1.Text = "Stress";
            this.lblTitle1.Click += new System.EventHandler(this.lblTitle1_Click);
            // 
            // lblTitle2
            // 
            this.lblTitle2.AutoSize = true;
            this.lblTitle2.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle2.Font = new System.Drawing.Font("Le Sofia", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle2.ForeColor = System.Drawing.Color.Tomato;
            this.lblTitle2.Location = new System.Drawing.Point(437, 107);
            this.lblTitle2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle2.Name = "lblTitle2";
            this.lblTitle2.Size = new System.Drawing.Size(247, 92);
            this.lblTitle2.TabIndex = 1;
            this.lblTitle2.Text = "Tester";
            // 
            // tbNama
            // 
            this.tbNama.BackColor = System.Drawing.Color.LightSalmon;
            this.tbNama.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbNama.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNama.ForeColor = System.Drawing.Color.SeaShell;
            this.tbNama.Location = new System.Drawing.Point(302, 316);
            this.tbNama.Margin = new System.Windows.Forms.Padding(4);
            this.tbNama.Multiline = true;
            this.tbNama.Name = "tbNama";
            this.tbNama.Size = new System.Drawing.Size(333, 32);
            this.tbNama.TabIndex = 2;
            this.tbNama.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbNama.TextChanged += new System.EventHandler(this.tbNama_TextChanged);
            // 
            // btnNext
            // 
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNext.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnNext.Location = new System.Drawing.Point(427, 512);
            this.btnNext.Margin = new System.Windows.Forms.Padding(4);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(100, 28);
            this.btnNext.TabIndex = 3;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // lblNanya
            // 
            this.lblNanya.AutoSize = true;
            this.lblNanya.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblNanya.Location = new System.Drawing.Point(299, 295);
            this.lblNanya.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNanya.Name = "lblNanya";
            this.lblNanya.Size = new System.Drawing.Size(158, 17);
            this.lblNanya.TabIndex = 4;
            this.lblNanya.Text = "Masukkan Nama Anda :";
            // 
            // tbUmur
            // 
            this.tbUmur.BackColor = System.Drawing.Color.LightSalmon;
            this.tbUmur.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbUmur.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUmur.ForeColor = System.Drawing.Color.SeaShell;
            this.tbUmur.Location = new System.Drawing.Point(302, 432);
            this.tbUmur.Margin = new System.Windows.Forms.Padding(4);
            this.tbUmur.Multiline = true;
            this.tbUmur.Name = "tbUmur";
            this.tbUmur.Size = new System.Drawing.Size(333, 32);
            this.tbUmur.TabIndex = 6;
            this.tbUmur.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label1.Location = new System.Drawing.Point(299, 354);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Masukkan Jenis Kelamin Anda :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label2.Location = new System.Drawing.Point(299, 411);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Masukkan Umur Anda :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Grabstein Sans CE", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label3.Location = new System.Drawing.Point(283, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(369, 26);
            this.label3.TabIndex = 9;
            this.label3.Text = "Ketahui Tingkat Stressmu dan Temukan Solusinya";
            // 
            // rb1
            // 
            this.rb1.AutoSize = true;
            this.rb1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.rb1.Location = new System.Drawing.Point(359, 383);
            this.rb1.Name = "rb1";
            this.rb1.Size = new System.Drawing.Size(81, 21);
            this.rb1.TabIndex = 10;
            this.rb1.TabStop = true;
            this.rb1.Text = "Laki-laki";
            this.rb1.UseVisualStyleBackColor = true;
            this.rb1.CheckedChanged += new System.EventHandler(this.rb1_CheckedChanged);
            // 
            // rb2
            // 
            this.rb2.AutoSize = true;
            this.rb2.ForeColor = System.Drawing.Color.SaddleBrown;
            this.rb2.Location = new System.Drawing.Point(481, 383);
            this.rb2.Name = "rb2";
            this.rb2.Size = new System.Drawing.Size(102, 21);
            this.rb2.TabIndex = 11;
            this.rb2.TabStop = true;
            this.rb2.Text = "Perempuan";
            this.rb2.UseVisualStyleBackColor = true;
            this.rb2.CheckedChanged += new System.EventHandler(this.rb2_CheckedChanged);
            // 
            // awalan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(982, 553);
            this.Controls.Add(this.rb2);
            this.Controls.Add(this.rb1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbUmur);
            this.Controls.Add(this.lblNanya);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.tbNama);
            this.Controls.Add(this.lblTitle2);
            this.Controls.Add(this.lblTitle1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "awalan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StressTester";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle1;
        private System.Windows.Forms.Label lblTitle2;
        private System.Windows.Forms.TextBox tbNama;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label lblNanya;
        private System.Windows.Forms.TextBox tbUmur;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rb1;
        private System.Windows.Forms.RadioButton rb2;
    }
}