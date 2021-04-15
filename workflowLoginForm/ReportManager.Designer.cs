
namespace workflowLoginForm
{
    partial class ReportManager
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
            this.RawMatbtn = new System.Windows.Forms.Button();
            this.Productbtn = new System.Windows.Forms.Button();
            this.RawMatCSVbtn = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RawMatbtn
            // 
            this.RawMatbtn.Location = new System.Drawing.Point(172, 104);
            this.RawMatbtn.Name = "RawMatbtn";
            this.RawMatbtn.Size = new System.Drawing.Size(240, 90);
            this.RawMatbtn.TabIndex = 0;
            this.RawMatbtn.Text = "View Raw Materials Report";
            this.RawMatbtn.UseVisualStyleBackColor = true;
            this.RawMatbtn.Click += new System.EventHandler(this.RawMatbtn_Click);
            // 
            // Productbtn
            // 
            this.Productbtn.Location = new System.Drawing.Point(446, 104);
            this.Productbtn.Name = "Productbtn";
            this.Productbtn.Size = new System.Drawing.Size(240, 90);
            this.Productbtn.TabIndex = 1;
            this.Productbtn.Text = "View Product Report";
            this.Productbtn.UseVisualStyleBackColor = true;
            this.Productbtn.Click += new System.EventHandler(this.Productbtn_Click);
            // 
            // RawMatCSVbtn
            // 
            this.RawMatCSVbtn.Location = new System.Drawing.Point(172, 213);
            this.RawMatCSVbtn.Name = "RawMatCSVbtn";
            this.RawMatCSVbtn.Size = new System.Drawing.Size(240, 40);
            this.RawMatCSVbtn.TabIndex = 2;
            this.RawMatCSVbtn.Text = "Generate CSV";
            this.RawMatCSVbtn.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(446, 213);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(240, 40);
            this.button4.TabIndex = 3;
            this.button4.Text = "Generate CSV";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // ReportManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.RawMatCSVbtn);
            this.Controls.Add(this.Productbtn);
            this.Controls.Add(this.RawMatbtn);
            this.Name = "ReportManager";
            this.Text = "ReportManager";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button RawMatbtn;
        private System.Windows.Forms.Button Productbtn;
        private System.Windows.Forms.Button RawMatCSVbtn;
        private System.Windows.Forms.Button button4;
    }
}