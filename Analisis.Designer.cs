namespace StresTester
{
    partial class Analisis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Analisis));
            this.lblSkors = new System.Windows.Forms.Label();
            this.lblFaktor = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnBackmenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSkors
            // 
            this.lblSkors.AutoSize = true;
            this.lblSkors.Font = new System.Drawing.Font("bangkey", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.lblSkors.ForeColor = System.Drawing.Color.Tomato;
            this.lblSkors.Location = new System.Drawing.Point(13, 9);
            this.lblSkors.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSkors.Name = "lblSkors";
            this.lblSkors.Size = new System.Drawing.Size(214, 55);
            this.lblSkors.TabIndex = 0;
            this.lblSkors.Text = "Klasifikasi Skor";
            // 
            // lblFaktor
            // 
            this.lblFaktor.AutoSize = true;
            this.lblFaktor.Font = new System.Drawing.Font("bangkey", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.lblFaktor.ForeColor = System.Drawing.Color.Tomato;
            this.lblFaktor.Location = new System.Drawing.Point(13, 232);
            this.lblFaktor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFaktor.Name = "lblFaktor";
            this.lblFaktor.Size = new System.Drawing.Size(466, 55);
            this.lblFaktor.TabIndex = 1;
            this.lblFaktor.Text = "Faktor yang Mempengaruhi Stress";
            this.lblFaktor.Click += new System.EventHandler(this.lblFaktor_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox1.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.textBox1.Location = new System.Drawing.Point(93, 68);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(500, 160);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "1.  Skor < 14 tidak ada stres\r\n2.  Skor 14-20 stres ringan\r\n3.  Skor 21-27 stres " +
    "sedang\r\n4.  Skor 28-41 stres berat\r\n5.  Skor 42-56 stres berat sekali";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.AntiqueWhite;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox2.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.Color.SaddleBrown;
            this.textBox2.Location = new System.Drawing.Point(93, 291);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(789, 166);
            this.textBox2.TabIndex = 3;
            this.textBox2.Text = resources.GetString("textBox2.Text");
            // 
            // btnBackmenu
            // 
            this.btnBackmenu.BackColor = System.Drawing.Color.Linen;
            this.btnBackmenu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBackmenu.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnBackmenu.Location = new System.Drawing.Point(605, 512);
            this.btnBackmenu.Margin = new System.Windows.Forms.Padding(4);
            this.btnBackmenu.Name = "btnBackmenu";
            this.btnBackmenu.Size = new System.Drawing.Size(124, 28);
            this.btnBackmenu.TabIndex = 5;
            this.btnBackmenu.Text = "Back to Menu";
            this.btnBackmenu.UseVisualStyleBackColor = false;
            this.btnBackmenu.Click += new System.EventHandler(this.btnBackmenu_Click);
            // 
            // Analisis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(982, 553);
            this.Controls.Add(this.btnBackmenu);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblFaktor);
            this.Controls.Add(this.lblSkors);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Analisis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StressMeter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSkors;
        private System.Windows.Forms.Label lblFaktor;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnBackmenu;
    }
}