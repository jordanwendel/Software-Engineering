namespace QualityAnalyzer
{
    partial class QualityAnalyzer
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
            this.Admin = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Admin
            // 
            this.Admin.Font = new System.Drawing.Font("Tahoma", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Admin.Location = new System.Drawing.Point(115, 194);
            this.Admin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Admin.Name = "Admin";
            this.Admin.Size = new System.Drawing.Size(571, 62);
            this.Admin.TabIndex = 2;
            this.Admin.Text = "QUALITY ANALYZER PAGE";
            this.Admin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Admin.Click += new System.EventHandler(this.Admin_Click);
            // 
            // QualityAnalyzer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Admin);
            this.Name = "QualityAnalyzer";
            this.Text = "QualityAnalyzer";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Admin;
    }
}

