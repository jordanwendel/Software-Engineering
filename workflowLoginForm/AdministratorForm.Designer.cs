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
            this.stockiestBtn = new System.Windows.Forms.Button();
            this.prodManagerBtn = new System.Windows.Forms.Button();
            this.delManagerBtn = new System.Windows.Forms.Button();
            this.repManagerBtn = new System.Windows.Forms.Button();
            this.qualAnalyzerBtn = new System.Windows.Forms.Button();
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
            this.Admin.Location = new System.Drawing.Point(93, 15);
            this.Admin.Name = "Admin";
            this.Admin.Size = new System.Drawing.Size(428, 50);
            this.Admin.TabIndex = 1;
            this.Admin.Text = "ADMIN PAGE";
            this.Admin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Logout
            // 
            this.Logout.Location = new System.Drawing.Point(509, 332);
            this.Logout.Margin = new System.Windows.Forms.Padding(2);
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(82, 24);
            this.Logout.TabIndex = 5;
            this.Logout.Text = "Logout";
            this.Logout.UseVisualStyleBackColor = true;
            this.Logout.Click += new System.EventHandler(this.Logout_Click);
            // 
            // stockiestBtn
            // 
            this.stockiestBtn.Location = new System.Drawing.Point(176, 167);
            this.stockiestBtn.Margin = new System.Windows.Forms.Padding(2);
            this.stockiestBtn.Name = "stockiestBtn";
            this.stockiestBtn.Size = new System.Drawing.Size(128, 27);
            this.stockiestBtn.TabIndex = 6;
            this.stockiestBtn.Text = "Stockiest";
            this.stockiestBtn.UseVisualStyleBackColor = true;
            this.stockiestBtn.Click += new System.EventHandler(this.stockiestBtn_Click);
            // 
            // prodManagerBtn
            // 
            this.prodManagerBtn.Location = new System.Drawing.Point(308, 167);
            this.prodManagerBtn.Margin = new System.Windows.Forms.Padding(2);
            this.prodManagerBtn.Name = "prodManagerBtn";
            this.prodManagerBtn.Size = new System.Drawing.Size(128, 27);
            this.prodManagerBtn.TabIndex = 7;
            this.prodManagerBtn.Text = "Product Manager";
            this.prodManagerBtn.UseVisualStyleBackColor = true;
            this.prodManagerBtn.Click += new System.EventHandler(this.prodManagerBtn_Click);
            // 
            // delManagerBtn
            // 
            this.delManagerBtn.Location = new System.Drawing.Point(108, 284);
            this.delManagerBtn.Margin = new System.Windows.Forms.Padding(2);
            this.delManagerBtn.Name = "delManagerBtn";
            this.delManagerBtn.Size = new System.Drawing.Size(128, 28);
            this.delManagerBtn.TabIndex = 8;
            this.delManagerBtn.Text = "Delivery Manager";
            this.delManagerBtn.UseVisualStyleBackColor = true;
            this.delManagerBtn.Click += new System.EventHandler(this.delManagerBtn_Click);
            // 
            // repManagerBtn
            // 
            this.repManagerBtn.Location = new System.Drawing.Point(242, 284);
            this.repManagerBtn.Margin = new System.Windows.Forms.Padding(2);
            this.repManagerBtn.Name = "repManagerBtn";
            this.repManagerBtn.Size = new System.Drawing.Size(128, 28);
            this.repManagerBtn.TabIndex = 9;
            this.repManagerBtn.Text = "Report Manager";
            this.repManagerBtn.UseVisualStyleBackColor = true;
            this.repManagerBtn.Click += new System.EventHandler(this.repManagerBtn_Click);
            // 
            // qualAnalyzerBtn
            // 
            this.qualAnalyzerBtn.Location = new System.Drawing.Point(374, 284);
            this.qualAnalyzerBtn.Margin = new System.Windows.Forms.Padding(2);
            this.qualAnalyzerBtn.Name = "qualAnalyzerBtn";
            this.qualAnalyzerBtn.Size = new System.Drawing.Size(128, 28);
            this.qualAnalyzerBtn.TabIndex = 10;
            this.qualAnalyzerBtn.Text = "Quality Analyzer";
            this.qualAnalyzerBtn.UseVisualStyleBackColor = true;
            this.qualAnalyzerBtn.Click += new System.EventHandler(this.qualAnalyzerBtn_Click);
            // 
            // Names
            // 
            this.Names.FormattingEnabled = true;
            this.Names.Location = new System.Drawing.Point(176, 79);
            this.Names.Margin = new System.Windows.Forms.Padding(2);
            this.Names.Name = "Names";
            this.Names.Size = new System.Drawing.Size(129, 95);
            this.Names.TabIndex = 11;
            // 
            // Names2
            // 
            this.Names2.FormattingEnabled = true;
            this.Names2.Location = new System.Drawing.Point(308, 79);
            this.Names2.Margin = new System.Windows.Forms.Padding(2);
            this.Names2.Name = "Names2";
            this.Names2.Size = new System.Drawing.Size(129, 95);
            this.Names2.TabIndex = 12;
            // 
            // Names3
            // 
            this.Names3.FormattingEnabled = true;
            this.Names3.Location = new System.Drawing.Point(108, 198);
            this.Names3.Margin = new System.Windows.Forms.Padding(2);
            this.Names3.Name = "Names3";
            this.Names3.Size = new System.Drawing.Size(129, 95);
            this.Names3.TabIndex = 13;
            // 
            // Names4
            // 
            this.Names4.FormattingEnabled = true;
            this.Names4.Location = new System.Drawing.Point(241, 198);
            this.Names4.Margin = new System.Windows.Forms.Padding(2);
            this.Names4.Name = "Names4";
            this.Names4.Size = new System.Drawing.Size(129, 95);
            this.Names4.TabIndex = 14;
            // 
            // Names5
            // 
            this.Names5.FormattingEnabled = true;
            this.Names5.Location = new System.Drawing.Point(374, 198);
            this.Names5.Margin = new System.Windows.Forms.Padding(2);
            this.Names5.Name = "Names5";
            this.Names5.Size = new System.Drawing.Size(129, 95);
            this.Names5.TabIndex = 15;
            // 
            // AdministratorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 367);
            this.Controls.Add(this.Names5);
            this.Controls.Add(this.Names4);
            this.Controls.Add(this.Names3);
            this.Controls.Add(this.Names2);
            this.Controls.Add(this.Names);
            this.Controls.Add(this.qualAnalyzerBtn);
            this.Controls.Add(this.repManagerBtn);
            this.Controls.Add(this.delManagerBtn);
            this.Controls.Add(this.prodManagerBtn);
            this.Controls.Add(this.stockiestBtn);
            this.Controls.Add(this.Logout);
            this.Controls.Add(this.Admin);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AdministratorForm";
            this.Text = "Admin";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Admin;
        private System.Windows.Forms.Button Logout;
        private System.Windows.Forms.Button stockiestBtn;
        private System.Windows.Forms.Button prodManagerBtn;
        private System.Windows.Forms.Button delManagerBtn;
        private System.Windows.Forms.Button repManagerBtn;
        private System.Windows.Forms.Button qualAnalyzerBtn;
        private System.Windows.Forms.ListBox Names;
        private System.Windows.Forms.ListBox Names2;
        private System.Windows.Forms.ListBox Names3;
        private System.Windows.Forms.ListBox Names4;
        private System.Windows.Forms.ListBox Names5;
    }
}

