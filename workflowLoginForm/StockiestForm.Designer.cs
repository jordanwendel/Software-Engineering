namespace workflowLoginForm
{
    partial class StockiestForm
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
            this.Stockiest = new System.Windows.Forms.Label();
            this.Logout = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Stockiest
            // 
            this.Stockiest.Font = new System.Drawing.Font("Tahoma", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Stockiest.Location = new System.Drawing.Point(38, 49);
            this.Stockiest.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Stockiest.Name = "Stockiest";
            this.Stockiest.Size = new System.Drawing.Size(571, 62);
            this.Stockiest.TabIndex = 2;
            this.Stockiest.Text = "STOCKIEST PAGE";
            this.Stockiest.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Logout
            // 
            this.Logout.Location = new System.Drawing.Point(134, 222);
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(188, 63);
            this.Logout.TabIndex = 5;
            this.Logout.Text = "Logout";
            this.Logout.UseVisualStyleBackColor = true;
            this.Logout.Click += new System.EventHandler(this.Logout_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(385, 222);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 63);
            this.button1.TabIndex = 6;
            this.button1.Text = "To Materials Database Form";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 360);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Logout);
            this.Controls.Add(this.Stockiest);
            this.Name = "Stock";
            this.Text = "Stockiest";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Stockiest;
        private System.Windows.Forms.Button Logout;
        private System.Windows.Forms.Button button1;
    }
}

