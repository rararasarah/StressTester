namespace StresTester
{
    partial class Menu1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu1));
            this.lblMenu11 = new System.Windows.Forms.Label();
            this.RTBstress1 = new System.Windows.Forms.RichTextBox();
            this.lblMenu12 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.RTBstress2 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // lblMenu11
            // 
            this.lblMenu11.AutoSize = true;
            this.lblMenu11.BackColor = System.Drawing.Color.FloralWhite;
            this.lblMenu11.Font = new System.Drawing.Font("bangkey", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.lblMenu11.ForeColor = System.Drawing.Color.Tomato;
            this.lblMenu11.Location = new System.Drawing.Point(19, 57);
            this.lblMenu11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMenu11.Name = "lblMenu11";
            this.lblMenu11.Size = new System.Drawing.Size(254, 67);
            this.lblMenu11.TabIndex = 0;
            this.lblMenu11.Text = "Apa itu stress?";
            // 
            // RTBstress1
            // 
            this.RTBstress1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RTBstress1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.RTBstress1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RTBstress1.Enabled = false;
            this.RTBstress1.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RTBstress1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.RTBstress1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.RTBstress1.Location = new System.Drawing.Point(31, 128);
            this.RTBstress1.Margin = new System.Windows.Forms.Padding(4);
            this.RTBstress1.Name = "RTBstress1";
            this.RTBstress1.Size = new System.Drawing.Size(429, 324);
            this.RTBstress1.TabIndex = 1;
            this.RTBstress1.Text = resources.GetString("RTBstress1.Text");
            // 
            // lblMenu12
            // 
            this.lblMenu12.AutoSize = true;
            this.lblMenu12.Font = new System.Drawing.Font("bangkey", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.lblMenu12.ForeColor = System.Drawing.Color.Tomato;
            this.lblMenu12.Location = new System.Drawing.Point(465, 57);
            this.lblMenu12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMenu12.Name = "lblMenu12";
            this.lblMenu12.Size = new System.Drawing.Size(265, 67);
            this.lblMenu12.TabIndex = 2;
            this.lblMenu12.Text = "Macam Stress";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBack.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnBack.Location = new System.Drawing.Point(59, 512);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(100, 28);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // RTBstress2
            // 
            this.RTBstress2.BackColor = System.Drawing.Color.AntiqueWhite;
            this.RTBstress2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RTBstress2.Enabled = false;
            this.RTBstress2.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RTBstress2.ForeColor = System.Drawing.Color.SaddleBrown;
            this.RTBstress2.Location = new System.Drawing.Point(490, 128);
            this.RTBstress2.Margin = new System.Windows.Forms.Padding(4);
            this.RTBstress2.Name = "RTBstress2";
            this.RTBstress2.Size = new System.Drawing.Size(470, 324);
            this.RTBstress2.TabIndex = 3;
            this.RTBstress2.Text = resources.GetString("RTBstress2.Text");
            // 
            // Menu1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(985, 553);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.RTBstress2);
            this.Controls.Add(this.lblMenu12);
            this.Controls.Add(this.RTBstress1);
            this.Controls.Add(this.lblMenu11);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Menu1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StressTester";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMenu11;
        private System.Windows.Forms.RichTextBox RTBstress1;
        private System.Windows.Forms.Label lblMenu12;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.RichTextBox RTBstress2;
    }
}