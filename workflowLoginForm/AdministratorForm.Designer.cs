namespace workflowLoginForm
{
    partial class AdministratorForm
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
            this.Logout = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.Names = new System.Windows.Forms.ListBox();
            this.Names2 = new System.Windows.Forms.ListBox();
            this.Names3 = new System.Windows.Forms.ListBox();
            this.Names4 = new System.Windows.Forms.ListBox();
            this.Names5 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // Admin
            // 
            this.Admin.Font = new System.Drawing.Font("Tahoma", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Admin.Location = new System.Drawing.Point(124, 18);
            this.Admin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Admin.Name = "Admin";
            this.Admin.Size = new System.Drawing.Size(571, 62);
            this.Admin.TabIndex = 1;
            this.Admin.Text = "ADMIN PAGE";
            this.Admin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Admin.Click += new System.EventHandler(this.Admin_Click);
            // 
            // Logout
            // 
            this.Logout.Location = new System.Drawing.Point(679, 408);
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(109, 30);
            this.Logout.TabIndex = 5;
            this.Logout.Text = "Logout";
            this.Logout.UseVisualStyleBackColor = true;
            this.Logout.Click += new System.EventHandler(this.Logout_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(234, 205);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(171, 33);
            this.button1.TabIndex = 6;
            this.button1.Text = "Stockiest";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(411, 205);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(171, 33);
            this.button2.TabIndex = 7;
            this.button2.Text = "Product Manager";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(144, 350);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(171, 35);
            this.button3.TabIndex = 8;
            this.button3.Text = "Delivery Manager";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(322, 350);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(171, 35);
            this.button4.TabIndex = 9;
            this.button4.Text = "Report Manager";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(498, 350);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(171, 35);
            this.button5.TabIndex = 10;
            this.button5.Text = "Quality Analyzer";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // Names
            // 
            this.Names.FormattingEnabled = true;
            this.Names.ItemHeight = 16;
            this.Names.Location = new System.Drawing.Point(234, 97);
            this.Names.Name = "Names";
            this.Names.Size = new System.Drawing.Size(171, 116);
            this.Names.TabIndex = 11;
            this.Names.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged_1);
            // 
            // Names2
            // 
            this.Names2.FormattingEnabled = true;
            this.Names2.ItemHeight = 16;
            this.Names2.Location = new System.Drawing.Point(411, 97);
            this.Names2.Name = "Names2";
            this.Names2.Size = new System.Drawing.Size(171, 116);
            this.Names2.TabIndex = 12;
            // 
            // Names3
            // 
            this.Names3.FormattingEnabled = true;
            this.Names3.ItemHeight = 16;
            this.Names3.Location = new System.Drawing.Point(144, 244);
            this.Names3.Name = "Names3";
            this.Names3.Size = new System.Drawing.Size(171, 116);
            this.Names3.TabIndex = 13;
            // 
            // Names4
            // 
            this.Names4.FormattingEnabled = true;
            this.Names4.ItemHeight = 16;
            this.Names4.Location = new System.Drawing.Point(321, 244);
            this.Names4.Name = "Names4";
            this.Names4.Size = new System.Drawing.Size(171, 116);
            this.Names4.TabIndex = 14;
            // 
            // Names5
            // 
            this.Names5.FormattingEnabled = true;
            this.Names5.ItemHeight = 16;
            this.Names5.Location = new System.Drawing.Point(498, 244);
            this.Names5.Name = "Names5";
            this.Names5.Size = new System.Drawing.Size(171, 116);
            this.Names5.TabIndex = 15;
            // 
            // Administrator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 452);
            this.Controls.Add(this.Names5);
            this.Controls.Add(this.Names4);
            this.Controls.Add(this.Names3);
            this.Controls.Add(this.Names2);
            this.Controls.Add(this.Names);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Logout);
            this.Controls.Add(this.Admin);
            this.Name = "Administrator";
            this.Text = "Admin";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Admin;
        private System.Windows.Forms.Button Logout;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ListBox Names;
        private System.Windows.Forms.ListBox Names2;
        private System.Windows.Forms.ListBox Names3;
        private System.Windows.Forms.ListBox Names4;
        private System.Windows.Forms.ListBox Names5;
    }
}

