namespace StresTester
{
    partial class Menu2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu2));
            this.lblMenu2 = new System.Windows.Forms.Label();
            this.RTBtipestrress = new System.Windows.Forms.RichTextBox();
            this.btnBackk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMenu2
            // 
            this.lblMenu2.AutoSize = true;
            this.lblMenu2.Font = new System.Drawing.Font("bangkey", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.lblMenu2.ForeColor = System.Drawing.Color.Tomato;
            this.lblMenu2.Location = new System.Drawing.Point(13, 9);
            this.lblMenu2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMenu2.Name = "lblMenu2";
            this.lblMenu2.Size = new System.Drawing.Size(523, 67);
            this.lblMenu2.TabIndex = 0;
            this.lblMenu2.Text = "Tipe kepribadian yg rentan stress";
            // 
            // RTBtipestrress
            // 
            this.RTBtipestrress.BackColor = System.Drawing.Color.AntiqueWhite;
            this.RTBtipestrress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RTBtipestrress.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RTBtipestrress.ForeColor = System.Drawing.Color.SaddleBrown;
            this.RTBtipestrress.Location = new System.Drawing.Point(59, 80);
            this.RTBtipestrress.Margin = new System.Windows.Forms.Padding(4);
            this.RTBtipestrress.Name = "RTBtipestrress";
            this.RTBtipestrress.ReadOnly = true;
            this.RTBtipestrress.Size = new System.Drawing.Size(778, 405);
            this.RTBtipestrress.TabIndex = 1;
            this.RTBtipestrress.Text = resources.GetString("RTBtipestrress.Text");
            // 
            // btnBackk
            // 
            this.btnBackk.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBackk.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackk.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnBackk.Location = new System.Drawing.Point(59, 512);
            this.btnBackk.Margin = new System.Windows.Forms.Padding(4);
            this.btnBackk.Name = "btnBackk";
            this.btnBackk.Size = new System.Drawing.Size(100, 28);
            this.btnBackk.TabIndex = 2;
            this.btnBackk.Text = "Back";
            this.btnBackk.UseVisualStyleBackColor = true;
            this.btnBackk.Click += new System.EventHandler(this.btnBackk_Click);
            // 
            // Menu2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(982, 553);
            this.Controls.Add(this.btnBackk);
            this.Controls.Add(this.RTBtipestrress);
            this.Controls.Add(this.lblMenu2);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Menu2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StressTester";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMenu2;
        private System.Windows.Forms.RichTextBox RTBtipestrress;
        private System.Windows.Forms.Button btnBackk;
    }
}