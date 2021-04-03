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
            this.stockiestNames = new System.Windows.Forms.ListBox();
            this.productManagerNames = new System.Windows.Forms.ListBox();
            this.deliveryManagerNames = new System.Windows.Forms.ListBox();
            this.reportManagerNames = new System.Windows.Forms.ListBox();
            this.qualityAnalyzerNames = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // Admin
            // 
            this.Admin.Font = new System.Drawing.Font("Impact", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Admin.ForeColor = System.Drawing.Color.White;
            this.Admin.Location = new System.Drawing.Point(100, 9);
            this.Admin.Name = "Admin";
            this.Admin.Size = new System.Drawing.Size(428, 50);
            this.Admin.TabIndex = 1;
            this.Admin.Text = "Task Manager";
            this.Admin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Logout
            // 
            this.Logout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(57)))), ((int)(((byte)(52)))));
            this.Logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logout.Location = new System.Drawing.Point(11, 326);
            this.Logout.Margin = new System.Windows.Forms.Padding(2);
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(100, 30);
            this.Logout.TabIndex = 5;
            this.Logout.Text = "LOG OUT";
            this.Logout.UseVisualStyleBackColor = false;
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
            // stockiestNames
            // 
            this.stockiestNames.FormattingEnabled = true;
            this.stockiestNames.Location = new System.Drawing.Point(176, 79);
            this.stockiestNames.Margin = new System.Windows.Forms.Padding(2);
            this.stockiestNames.Name = "stockiestNames";
            this.stockiestNames.Size = new System.Drawing.Size(129, 95);
            this.stockiestNames.TabIndex = 11;
            // 
            // productManagerNames
            // 
            this.productManagerNames.FormattingEnabled = true;
            this.productManagerNames.Location = new System.Drawing.Point(308, 79);
            this.productManagerNames.Margin = new System.Windows.Forms.Padding(2);
            this.productManagerNames.Name = "productManagerNames";
            this.productManagerNames.Size = new System.Drawing.Size(129, 95);
            this.productManagerNames.TabIndex = 12;
            // 
            // deliveryManagerNames
            // 
            this.deliveryManagerNames.FormattingEnabled = true;
            this.deliveryManagerNames.Location = new System.Drawing.Point(108, 198);
            this.deliveryManagerNames.Margin = new System.Windows.Forms.Padding(2);
            this.deliveryManagerNames.Name = "deliveryManagerNames";
            this.deliveryManagerNames.Size = new System.Drawing.Size(129, 95);
            this.deliveryManagerNames.TabIndex = 13;
            // 
            // reportManagerNames
            // 
            this.reportManagerNames.FormattingEnabled = true;
            this.reportManagerNames.Location = new System.Drawing.Point(241, 198);
            this.reportManagerNames.Margin = new System.Windows.Forms.Padding(2);
            this.reportManagerNames.Name = "reportManagerNames";
            this.reportManagerNames.Size = new System.Drawing.Size(129, 95);
            this.reportManagerNames.TabIndex = 14;
            // 
            // qualityAnalyzerNames
            // 
            this.qualityAnalyzerNames.FormattingEnabled = true;
            this.qualityAnalyzerNames.Location = new System.Drawing.Point(374, 198);
            this.qualityAnalyzerNames.Margin = new System.Windows.Forms.Padding(2);
            this.qualityAnalyzerNames.Name = "qualityAnalyzerNames";
            this.qualityAnalyzerNames.Size = new System.Drawing.Size(129, 95);
            this.qualityAnalyzerNames.TabIndex = 15;
            // 
            // AdministratorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(626, 367);
            this.Controls.Add(this.qualityAnalyzerNames);
            this.Controls.Add(this.reportManagerNames);
            this.Controls.Add(this.deliveryManagerNames);
            this.Controls.Add(this.productManagerNames);
            this.Controls.Add(this.stockiestNames);
            this.Controls.Add(this.qualAnalyzerBtn);
            this.Controls.Add(this.repManagerBtn);
            this.Controls.Add(this.delManagerBtn);
            this.Controls.Add(this.prodManagerBtn);
            this.Controls.Add(this.stockiestBtn);
            this.Controls.Add(this.Logout);
            this.Controls.Add(this.Admin);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AdministratorForm";
            this.Text = "Admin Form";
            this.Load += new System.EventHandler(this.AdministratorForm_Load);
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
        private System.Windows.Forms.ListBox stockiestNames;
        private System.Windows.Forms.ListBox productManagerNames;
        private System.Windows.Forms.ListBox deliveryManagerNames;
        private System.Windows.Forms.ListBox reportManagerNames;
        private System.Windows.Forms.ListBox qualityAnalyzerNames;
    }
}

