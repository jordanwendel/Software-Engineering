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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdministratorForm));
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
            this.registerBtn = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.viewProductReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewMaterialReoprtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.goBackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Admin
            // 
            this.Admin.Font = new System.Drawing.Font("Impact", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Admin.ForeColor = System.Drawing.Color.White;
            this.Admin.Location = new System.Drawing.Point(135, 33);
            this.Admin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Admin.Name = "Admin";
            this.Admin.Size = new System.Drawing.Size(571, 62);
            this.Admin.TabIndex = 1;
            this.Admin.Text = "Task Manager";
            this.Admin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Logout
            // 
            this.Logout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(57)))), ((int)(((byte)(52)))));
            this.Logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logout.Location = new System.Drawing.Point(15, 401);
            this.Logout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(133, 37);
            this.Logout.TabIndex = 5;
            this.Logout.Text = "LOG OUT";
            this.Logout.UseVisualStyleBackColor = false;
            this.Logout.Click += new System.EventHandler(this.Logout_Click);
            // 
            // stockiestBtn
            // 
            this.stockiestBtn.Location = new System.Drawing.Point(235, 206);
            this.stockiestBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.stockiestBtn.Name = "stockiestBtn";
            this.stockiestBtn.Size = new System.Drawing.Size(171, 33);
            this.stockiestBtn.TabIndex = 6;
            this.stockiestBtn.Text = "Stockiest";
            this.stockiestBtn.UseVisualStyleBackColor = true;
            this.stockiestBtn.Click += new System.EventHandler(this.stockiestBtn_Click);
            // 
            // prodManagerBtn
            // 
            this.prodManagerBtn.Location = new System.Drawing.Point(411, 206);
            this.prodManagerBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.prodManagerBtn.Name = "prodManagerBtn";
            this.prodManagerBtn.Size = new System.Drawing.Size(171, 33);
            this.prodManagerBtn.TabIndex = 7;
            this.prodManagerBtn.Text = "Product Manager";
            this.prodManagerBtn.UseVisualStyleBackColor = true;
            this.prodManagerBtn.Click += new System.EventHandler(this.prodManagerBtn_Click);
            // 
            // delManagerBtn
            // 
            this.delManagerBtn.Location = new System.Drawing.Point(144, 350);
            this.delManagerBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.delManagerBtn.Name = "delManagerBtn";
            this.delManagerBtn.Size = new System.Drawing.Size(171, 34);
            this.delManagerBtn.TabIndex = 8;
            this.delManagerBtn.Text = "Delivery Manager";
            this.delManagerBtn.UseVisualStyleBackColor = true;
            this.delManagerBtn.Click += new System.EventHandler(this.delManagerBtn_Click);
            // 
            // repManagerBtn
            // 
            this.repManagerBtn.Location = new System.Drawing.Point(323, 350);
            this.repManagerBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.repManagerBtn.Name = "repManagerBtn";
            this.repManagerBtn.Size = new System.Drawing.Size(171, 34);
            this.repManagerBtn.TabIndex = 9;
            this.repManagerBtn.Text = "Report Manager";
            this.repManagerBtn.UseVisualStyleBackColor = true;
            this.repManagerBtn.Click += new System.EventHandler(this.repManagerBtn_Click);
            // 
            // qualAnalyzerBtn
            // 
            this.qualAnalyzerBtn.Location = new System.Drawing.Point(499, 350);
            this.qualAnalyzerBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.qualAnalyzerBtn.Name = "qualAnalyzerBtn";
            this.qualAnalyzerBtn.Size = new System.Drawing.Size(171, 34);
            this.qualAnalyzerBtn.TabIndex = 10;
            this.qualAnalyzerBtn.Text = "Quality Analyzer";
            this.qualAnalyzerBtn.UseVisualStyleBackColor = true;
            this.qualAnalyzerBtn.Click += new System.EventHandler(this.qualAnalyzerBtn_Click);
            // 
            // stockiestNames
            // 
            this.stockiestNames.FormattingEnabled = true;
            this.stockiestNames.ItemHeight = 16;
            this.stockiestNames.Location = new System.Drawing.Point(235, 97);
            this.stockiestNames.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.stockiestNames.Name = "stockiestNames";
            this.stockiestNames.Size = new System.Drawing.Size(171, 116);
            this.stockiestNames.TabIndex = 11;
            // 
            // productManagerNames
            // 
            this.productManagerNames.FormattingEnabled = true;
            this.productManagerNames.ItemHeight = 16;
            this.productManagerNames.Location = new System.Drawing.Point(411, 97);
            this.productManagerNames.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.productManagerNames.Name = "productManagerNames";
            this.productManagerNames.Size = new System.Drawing.Size(171, 116);
            this.productManagerNames.TabIndex = 12;
            // 
            // deliveryManagerNames
            // 
            this.deliveryManagerNames.FormattingEnabled = true;
            this.deliveryManagerNames.ItemHeight = 16;
            this.deliveryManagerNames.Location = new System.Drawing.Point(144, 244);
            this.deliveryManagerNames.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.deliveryManagerNames.Name = "deliveryManagerNames";
            this.deliveryManagerNames.Size = new System.Drawing.Size(171, 116);
            this.deliveryManagerNames.TabIndex = 13;
            // 
            // reportManagerNames
            // 
            this.reportManagerNames.FormattingEnabled = true;
            this.reportManagerNames.ItemHeight = 16;
            this.reportManagerNames.Location = new System.Drawing.Point(321, 244);
            this.reportManagerNames.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.reportManagerNames.Name = "reportManagerNames";
            this.reportManagerNames.Size = new System.Drawing.Size(171, 116);
            this.reportManagerNames.TabIndex = 14;
            // 
            // qualityAnalyzerNames
            // 
            this.qualityAnalyzerNames.FormattingEnabled = true;
            this.qualityAnalyzerNames.ItemHeight = 16;
            this.qualityAnalyzerNames.Location = new System.Drawing.Point(499, 244);
            this.qualityAnalyzerNames.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.qualityAnalyzerNames.Name = "qualityAnalyzerNames";
            this.qualityAnalyzerNames.Size = new System.Drawing.Size(171, 116);
            this.qualityAnalyzerNames.TabIndex = 15;
            // 
            // registerBtn
            // 
            this.registerBtn.BackColor = System.Drawing.Color.LightGray;
            this.registerBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.registerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registerBtn.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerBtn.ForeColor = System.Drawing.Color.Black;
            this.registerBtn.Location = new System.Drawing.Point(279, 396);
            this.registerBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.registerBtn.Name = "registerBtn";
            this.registerBtn.Size = new System.Drawing.Size(243, 42);
            this.registerBtn.TabIndex = 16;
            this.registerBtn.Text = "REGISTER NEW USER";
            this.registerBtn.UseVisualStyleBackColor = false;
            this.registerBtn.Click += new System.EventHandler(this.registerBtn_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(835, 27);
            this.toolStrip1.TabIndex = 17;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewProductReportToolStripMenuItem,
            this.viewMaterialReoprtToolStripMenuItem,
            this.goBackToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(60, 24);
            this.toolStripDropDownButton1.Text = "Menu";
            // 
            // viewProductReportToolStripMenuItem
            // 
            this.viewProductReportToolStripMenuItem.Name = "viewProductReportToolStripMenuItem";
            this.viewProductReportToolStripMenuItem.Size = new System.Drawing.Size(232, 26);
            this.viewProductReportToolStripMenuItem.Text = "View Product Report";
            // 
            // viewMaterialReoprtToolStripMenuItem
            // 
            this.viewMaterialReoprtToolStripMenuItem.Name = "viewMaterialReoprtToolStripMenuItem";
            this.viewMaterialReoprtToolStripMenuItem.Size = new System.Drawing.Size(232, 26);
            this.viewMaterialReoprtToolStripMenuItem.Text = "View Material Reoprt";
            // 
            // goBackToolStripMenuItem
            // 
            this.goBackToolStripMenuItem.Name = "goBackToolStripMenuItem";
            this.goBackToolStripMenuItem.Size = new System.Drawing.Size(232, 26);
            this.goBackToolStripMenuItem.Text = "Go Back";
            this.goBackToolStripMenuItem.Click += new System.EventHandler(this.goBackToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(232, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // AdministratorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(835, 452);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.registerBtn);
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
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AdministratorForm";
            this.Text = "Admin Form";
            this.Load += new System.EventHandler(this.AdministratorForm_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Button registerBtn;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem viewProductReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewMaterialReoprtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem goBackToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}

