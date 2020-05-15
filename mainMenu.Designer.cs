namespace StresTester
{
    partial class mainMenu
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
            this.btnMenu1 = new System.Windows.Forms.Button();
            this.btnMenu2 = new System.Windows.Forms.Button();
            this.btnMenu3 = new System.Windows.Forms.Button();
            this.lblMenu = new System.Windows.Forms.Label();
            this.BackBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMenu1
            // 
            this.btnMenu1.BackColor = System.Drawing.Color.MistyRose;
            this.btnMenu1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMenu1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnMenu1.Location = new System.Drawing.Point(388, 194);
            this.btnMenu1.Margin = new System.Windows.Forms.Padding(4);
            this.btnMenu1.Name = "btnMenu1";
            this.btnMenu1.Size = new System.Drawing.Size(221, 51);
            this.btnMenu1.TabIndex = 0;
            this.btnMenu1.Text = "Stress?";
            this.btnMenu1.UseVisualStyleBackColor = false;
            this.btnMenu1.Click += new System.EventHandler(this.btnMenu1_Click);
            // 
            // btnMenu2
            // 
            this.btnMenu2.BackColor = System.Drawing.Color.MistyRose;
            this.btnMenu2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMenu2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu2.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnMenu2.Location = new System.Drawing.Point(388, 265);
            this.btnMenu2.Margin = new System.Windows.Forms.Padding(4);
            this.btnMenu2.Name = "btnMenu2";
            this.btnMenu2.Size = new System.Drawing.Size(221, 51);
            this.btnMenu2.TabIndex = 1;
            this.btnMenu2.Text = "Siapa yang rentan stress?";
            this.btnMenu2.UseVisualStyleBackColor = false;
            this.btnMenu2.Click += new System.EventHandler(this.btnMenu2_Click);
            // 
            // btnMenu3
            // 
            this.btnMenu3.BackColor = System.Drawing.Color.MistyRose;
            this.btnMenu3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMenu3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu3.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnMenu3.Location = new System.Drawing.Point(388, 333);
            this.btnMenu3.Margin = new System.Windows.Forms.Padding(4);
            this.btnMenu3.Name = "btnMenu3";
            this.btnMenu3.Size = new System.Drawing.Size(221, 51);
            this.btnMenu3.TabIndex = 2;
            this.btnMenu3.Text = "Stressmeter";
            this.btnMenu3.UseVisualStyleBackColor = false;
            this.btnMenu3.Click += new System.EventHandler(this.btnMenu3_Click);
            // 
            // lblMenu
            // 
            this.lblMenu.AutoSize = true;
            this.lblMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenu.ForeColor = System.Drawing.Color.Tomato;
            this.lblMenu.Location = new System.Drawing.Point(400, 94);
            this.lblMenu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(177, 55);
            this.lblMenu.TabIndex = 3;
            this.lblMenu.Text = "Menu :";
            // 
            // BackBtn
            // 
            this.BackBtn.BackColor = System.Drawing.Color.Linen;
            this.BackBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BackBtn.ForeColor = System.Drawing.Color.SaddleBrown;
            this.BackBtn.Location = new System.Drawing.Point(463, 443);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(75, 23);
            this.BackBtn.TabIndex = 4;
            this.BackBtn.Text = "Back";
            this.BackBtn.UseVisualStyleBackColor = false;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // mainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(982, 553);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.lblMenu);
            this.Controls.Add(this.btnMenu3);
            this.Controls.Add(this.btnMenu2);
            this.Controls.Add(this.btnMenu1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "mainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StressTester";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMenu1;
        private System.Windows.Forms.Button btnMenu2;
        private System.Windows.Forms.Button btnMenu3;
        private System.Windows.Forms.Label lblMenu;
        private System.Windows.Forms.Button BackBtn;
    }
}