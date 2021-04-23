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
            this.stockiestBtn = new System.Windows.Forms.Button();
            this.prodManagerBtn = new System.Windows.Forms.Button();
            this.delManagerBtn = new System.Windows.Forms.Button();
            this.repManagerBtn = new System.Windows.Forms.Button();
            this.qualAnalyzerBtn = new System.Windows.Forms.Button();
            this.registerBtn = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.goBackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewReportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.edituserbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Admin
            // 
            this.Admin.Font = new System.Drawing.Font("Impact", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Admin.ForeColor = System.Drawing.Color.White;
            this.Admin.Location = new System.Drawing.Point(170, 46);
            this.Admin.Name = "Admin";
            this.Admin.Size = new System.Drawing.Size(428, 50);
            this.Admin.TabIndex = 1;
            this.Admin.Text = "Administrator Page";
            this.Admin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // stockiestBtn
            // 
            this.stockiestBtn.BackColor = System.Drawing.Color.LightGray;
            this.stockiestBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stockiestBtn.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stockiestBtn.Location = new System.Drawing.Point(34, 210);
            this.stockiestBtn.Margin = new System.Windows.Forms.Padding(2);
            this.stockiestBtn.Name = "stockiestBtn";
            this.stockiestBtn.Size = new System.Drawing.Size(153, 44);
            this.stockiestBtn.TabIndex = 6;
            this.stockiestBtn.Text = "STOCKIEST";
            this.stockiestBtn.UseVisualStyleBackColor = false;
            this.stockiestBtn.Click += new System.EventHandler(this.stockiestBtn_Click);
            // 
            // prodManagerBtn
            // 
            this.prodManagerBtn.BackColor = System.Drawing.Color.LightGray;
            this.prodManagerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.prodManagerBtn.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prodManagerBtn.Location = new System.Drawing.Point(238, 211);
            this.prodManagerBtn.Margin = new System.Windows.Forms.Padding(2);
            this.prodManagerBtn.Name = "prodManagerBtn";
            this.prodManagerBtn.Size = new System.Drawing.Size(153, 44);
            this.prodManagerBtn.TabIndex = 7;
            this.prodManagerBtn.Text = "PRODUCT MANAGER";
            this.prodManagerBtn.UseVisualStyleBackColor = false;
            this.prodManagerBtn.Click += new System.EventHandler(this.prodManagerBtn_Click);
            // 
            // delManagerBtn
            // 
            this.delManagerBtn.BackColor = System.Drawing.Color.LightGray;
            this.delManagerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delManagerBtn.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delManagerBtn.Location = new System.Drawing.Point(238, 288);
            this.delManagerBtn.Margin = new System.Windows.Forms.Padding(2);
            this.delManagerBtn.Name = "delManagerBtn";
            this.delManagerBtn.Size = new System.Drawing.Size(153, 44);
            this.delManagerBtn.TabIndex = 8;
            this.delManagerBtn.Text = "DELIVERY MANAGER";
            this.delManagerBtn.UseVisualStyleBackColor = false;
            this.delManagerBtn.Click += new System.EventHandler(this.delManagerBtn_Click);
            // 
            // repManagerBtn
            // 
            this.repManagerBtn.BackColor = System.Drawing.Color.LightGray;
            this.repManagerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.repManagerBtn.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.repManagerBtn.Location = new System.Drawing.Point(134, 362);
            this.repManagerBtn.Margin = new System.Windows.Forms.Padding(2);
            this.repManagerBtn.Name = "repManagerBtn";
            this.repManagerBtn.Size = new System.Drawing.Size(153, 46);
            this.repManagerBtn.TabIndex = 9;
            this.repManagerBtn.Text = "REPORT MANAGER";
            this.repManagerBtn.UseVisualStyleBackColor = false;
            this.repManagerBtn.Click += new System.EventHandler(this.repManagerBtn_Click);
            // 
            // qualAnalyzerBtn
            // 
            this.qualAnalyzerBtn.BackColor = System.Drawing.Color.LightGray;
            this.qualAnalyzerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.qualAnalyzerBtn.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qualAnalyzerBtn.Location = new System.Drawing.Point(34, 288);
            this.qualAnalyzerBtn.Margin = new System.Windows.Forms.Padding(2);
            this.qualAnalyzerBtn.Name = "qualAnalyzerBtn";
            this.qualAnalyzerBtn.Size = new System.Drawing.Size(153, 46);
            this.qualAnalyzerBtn.TabIndex = 10;
            this.qualAnalyzerBtn.Text = "QUALITY ANALYZER";
            this.qualAnalyzerBtn.UseVisualStyleBackColor = false;
            this.qualAnalyzerBtn.Click += new System.EventHandler(this.qualAnalyzerBtn_Click);
            // 
            // registerBtn
            // 
            this.registerBtn.BackColor = System.Drawing.Color.LightGray;
            this.registerBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.registerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registerBtn.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerBtn.ForeColor = System.Drawing.Color.Black;
            this.registerBtn.Location = new System.Drawing.Point(478, 210);
            this.registerBtn.Name = "registerBtn";
            this.registerBtn.Size = new System.Drawing.Size(166, 44);
            this.registerBtn.TabIndex = 16;
            this.registerBtn.Text = "REGISTER NEW USER";
            this.registerBtn.UseVisualStyleBackColor = false;
            this.registerBtn.Click += new System.EventHandler(this.registerBtn_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.LightGray;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1});
            this.toolStrip1.Location = new System.Drawing.Point(653, 7);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(86, 25);
            this.toolStrip1.TabIndex = 17;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshToolStripMenuItem,
            this.goBackToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.toolStripDropDownButton1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(52, 22);
            this.toolStripDropDownButton1.Text = "Menu";
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.refreshToolStripMenuItem.Text = "Refresh";
            // 
            // goBackToolStripMenuItem
            // 
            this.goBackToolStripMenuItem.Name = "goBackToolStripMenuItem";
            this.goBackToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.goBackToolStripMenuItem.Text = "Go Back";
            this.goBackToolStripMenuItem.Click += new System.EventHandler(this.goBackToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewReportsToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // viewReportsToolStripMenuItem
            // 
            this.viewReportsToolStripMenuItem.Name = "viewReportsToolStripMenuItem";
            this.viewReportsToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.viewReportsToolStripMenuItem.Text = "View Reports";
            this.viewReportsToolStripMenuItem.Click += new System.EventHandler(this.viewReportsToolStripMenuItem_Click);
            // 
            // edituserbtn
            // 
            this.edituserbtn.BackColor = System.Drawing.Color.LightGray;
            this.edituserbtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.edituserbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.edituserbtn.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edituserbtn.ForeColor = System.Drawing.Color.Black;
            this.edituserbtn.Location = new System.Drawing.Point(478, 288);
            this.edituserbtn.Name = "edituserbtn";
            this.edituserbtn.Size = new System.Drawing.Size(166, 46);
            this.edituserbtn.TabIndex = 18;
            this.edituserbtn.Text = "EDIT USER INFORMATION";
            this.edituserbtn.UseVisualStyleBackColor = false;
            this.edituserbtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Impact", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(89, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 50);
            this.label1.TabIndex = 19;
            this.label1.Text = "Go to:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Impact", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(443, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(244, 50);
            this.label2.TabIndex = 20;
            this.label2.Text = "Admin Functions";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AdministratorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(736, 449);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.edituserbtn);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.registerBtn);
            this.Controls.Add(this.qualAnalyzerBtn);
            this.Controls.Add(this.repManagerBtn);
            this.Controls.Add(this.delManagerBtn);
            this.Controls.Add(this.prodManagerBtn);
            this.Controls.Add(this.stockiestBtn);
            this.Controls.Add(this.Admin);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AdministratorForm";
            this.Text = "Administrator Control";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Admin;
        private System.Windows.Forms.Button stockiestBtn;
        private System.Windows.Forms.Button prodManagerBtn;
        private System.Windows.Forms.Button delManagerBtn;
        private System.Windows.Forms.Button repManagerBtn;
        private System.Windows.Forms.Button qualAnalyzerBtn;
        private System.Windows.Forms.Button registerBtn;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem goBackToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.Button edituserbtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewReportsToolStripMenuItem;
    }
}

