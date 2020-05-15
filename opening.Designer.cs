namespace StresTester
{
    partial class menu
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
            this.lbTitleAplikasi = new System.Windows.Forms.Label();
            this.tbNama = new System.Windows.Forms.TextBox();
            this.btnNext = new System.Windows.Forms.Button();
            this.lblTitleAplikasi2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbTitleAplikasi
            // 
            this.lbTitleAplikasi.AutoSize = true;
            this.lbTitleAplikasi.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitleAplikasi.Location = new System.Drawing.Point(90, 39);
            this.lbTitleAplikasi.Name = "lbTitleAplikasi";
            this.lbTitleAplikasi.Size = new System.Drawing.Size(81, 29);
            this.lbTitleAplikasi.TabIndex = 0;
            this.lbTitleAplikasi.Text = "Stress";
            // 
            // tbNama
            // 
            this.tbNama.Location = new System.Drawing.Point(38, 147);
            this.tbNama.Multiline = true;
            this.tbNama.Name = "tbNama";
            this.tbNama.Size = new System.Drawing.Size(139, 33);
            this.tbNama.TabIndex = 1;
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(183, 157);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 2;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            // 
            // lblTitleAplikasi2
            // 
            this.lblTitleAplikasi2.AutoSize = true;
            this.lblTitleAplikasi2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleAplikasi2.Location = new System.Drawing.Point(136, 68);
            this.lblTitleAplikasi2.Name = "lblTitleAplikasi2";
            this.lblTitleAplikasi2.Size = new System.Drawing.Size(75, 29);
            this.lblTitleAplikasi2.TabIndex = 3;
            this.lblTitleAplikasi2.Text = "Meter";
            // 
            // menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 290);
            this.Controls.Add(this.lblTitleAplikasi2);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.tbNama);
            this.Controls.Add(this.lbTitleAplikasi);
            this.Name = "menu";
            this.Text = "menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTitleAplikasi;
        private System.Windows.Forms.TextBox tbNama;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label lblTitleAplikasi2;
    }
}