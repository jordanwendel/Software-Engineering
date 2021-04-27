
namespace workflowLoginForm
{
    partial class ReportManagerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportManagerForm));
            this.RawMatCSVbtn = new System.Windows.Forms.Button();
            this.prodCsvBtn = new System.Windows.Forms.Button();
            this.csvStatusStrip = new System.Windows.Forms.StatusStrip();
            this.csvStatusLbl = new System.Windows.Forms.ToolStripStatusLabel();
            this.rawMatCsvSave = new System.Windows.Forms.SaveFileDialog();
            this.cBoxProductRep = new System.Windows.Forms.ComboBox();
            this.productCsvSave = new System.Windows.Forms.SaveFileDialog();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.goBackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewReportsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblReportManager = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.RawMatBtn = new System.Windows.Forms.Button();
            this.Productbtn = new System.Windows.Forms.Button();
            this.csvStatusStrip.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // RawMatCSVbtn
            // 
            this.RawMatCSVbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(220)))), ((int)(((byte)(109)))));
            this.RawMatCSVbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RawMatCSVbtn.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RawMatCSVbtn.Location = new System.Drawing.Point(32, 301);
            this.RawMatCSVbtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RawMatCSVbtn.Name = "RawMatCSVbtn";
            this.RawMatCSVbtn.Size = new System.Drawing.Size(228, 41);
            this.RawMatCSVbtn.TabIndex = 1;
            this.RawMatCSVbtn.Text = "Generate Material Report CSV";
            this.RawMatCSVbtn.UseVisualStyleBackColor = false;
            this.RawMatCSVbtn.Click += new System.EventHandler(this.RawMatCSVbtn_Click);
            // 
            // prodCsvBtn
            // 
            this.prodCsvBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(220)))), ((int)(((byte)(109)))));
            this.prodCsvBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.prodCsvBtn.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prodCsvBtn.Location = new System.Drawing.Point(340, 301);
            this.prodCsvBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.prodCsvBtn.Name = "prodCsvBtn";
            this.prodCsvBtn.Size = new System.Drawing.Size(228, 41);
            this.prodCsvBtn.TabIndex = 4;
            this.prodCsvBtn.Text = "Generate Product Report CSV";
            this.prodCsvBtn.UseVisualStyleBackColor = false;
            this.prodCsvBtn.Click += new System.EventHandler(this.prodCsvBtn_Click);
            // 
            // csvStatusStrip
            // 
            this.csvStatusStrip.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.csvStatusStrip.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.csvStatusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.csvStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.csvStatusLbl});
            this.csvStatusStrip.Location = new System.Drawing.Point(0, 344);
            this.csvStatusStrip.Name = "csvStatusStrip";
            this.csvStatusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 10, 0);
            this.csvStatusStrip.Size = new System.Drawing.Size(600, 22);
            this.csvStatusStrip.TabIndex = 4;
            this.csvStatusStrip.Text = "statusStrip1";
            // 
            // csvStatusLbl
            // 
            this.csvStatusLbl.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.csvStatusLbl.ForeColor = System.Drawing.SystemColors.Control;
            this.csvStatusLbl.Name = "csvStatusLbl";
            this.csvStatusLbl.Size = new System.Drawing.Size(0, 17);
            // 
            // rawMatCsvSave
            // 
            this.rawMatCsvSave.DefaultExt = "csv";
            // 
            // cBoxProductRep
            // 
            this.cBoxProductRep.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxProductRep.FormattingEnabled = true;
            this.cBoxProductRep.Items.AddRange(new object[] {
            "In Progress",
            "Qualified",
            "Defective",
            "All Products"});
            this.cBoxProductRep.Location = new System.Drawing.Point(374, 258);
            this.cBoxProductRep.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cBoxProductRep.Name = "cBoxProductRep";
            this.cBoxProductRep.Size = new System.Drawing.Size(166, 21);
            this.cBoxProductRep.TabIndex = 3;
            this.cBoxProductRep.SelectedIndexChanged += new System.EventHandler(this.cBoxProductRep_SelectedIndexChanged);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1});
            this.toolStrip1.Location = new System.Drawing.Point(521, 7);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(55, 25);
            this.toolStrip1.TabIndex = 66;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripDropDownButton1.BackColor = System.Drawing.Color.LightGray;
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.goBackToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.toolStripDropDownButton1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(52, 22);
            this.toolStripDropDownButton1.Text = "Menu";
            this.toolStripDropDownButton1.Click += new System.EventHandler(this.toolStripDropDownButton1_Click);
            // 
            // goBackToolStripMenuItem
            // 
            this.goBackToolStripMenuItem.Name = "goBackToolStripMenuItem";
            this.goBackToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.goBackToolStripMenuItem.Text = "Go Back";
            this.goBackToolStripMenuItem.Click += new System.EventHandler(this.goBackToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewReportsToolStripMenuItem1});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // viewReportsToolStripMenuItem1
            // 
            this.viewReportsToolStripMenuItem1.Name = "viewReportsToolStripMenuItem1";
            this.viewReportsToolStripMenuItem1.Size = new System.Drawing.Size(149, 22);
            this.viewReportsToolStripMenuItem1.Text = "View Reports";
            this.viewReportsToolStripMenuItem1.Click += new System.EventHandler(this.viewReportsToolStripMenuItem1_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // lblReportManager
            // 
            this.lblReportManager.AutoSize = true;
            this.lblReportManager.Font = new System.Drawing.Font("Lucida Bright", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReportManager.ForeColor = System.Drawing.Color.White;
            this.lblReportManager.Location = new System.Drawing.Point(160, 27);
            this.lblReportManager.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblReportManager.Name = "lblReportManager";
            this.lblReportManager.Size = new System.Drawing.Size(300, 40);
            this.lblReportManager.TabIndex = 67;
            this.lblReportManager.Text = "Report Manager";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Bright", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(72, 110);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 22);
            this.label1.TabIndex = 68;
            this.label1.Text = "Material Report";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Bright", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(382, 110);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 22);
            this.label2.TabIndex = 69;
            this.label2.Text = "Product Report";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(341, 236);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(238, 18);
            this.label3.TabIndex = 70;
            this.label3.Text = "Choose Products To Export:";
            // 
            // RawMatBtn
            // 
            this.RawMatBtn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.RawMatBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RawMatBtn.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RawMatBtn.Location = new System.Drawing.Point(99, 134);
            this.RawMatBtn.Margin = new System.Windows.Forms.Padding(2);
            this.RawMatBtn.Name = "RawMatBtn";
            this.RawMatBtn.Size = new System.Drawing.Size(103, 39);
            this.RawMatBtn.TabIndex = 71;
            this.RawMatBtn.Text = "View";
            this.RawMatBtn.UseVisualStyleBackColor = false;
            // 
            // Productbtn
            // 
            this.Productbtn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Productbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Productbtn.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Productbtn.Location = new System.Drawing.Point(405, 134);
            this.Productbtn.Margin = new System.Windows.Forms.Padding(2);
            this.Productbtn.Name = "Productbtn";
            this.Productbtn.Size = new System.Drawing.Size(103, 39);
            this.Productbtn.TabIndex = 72;
            this.Productbtn.Text = "View";
            this.Productbtn.UseVisualStyleBackColor = false;
            // 
            // ReportManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.Productbtn);
            this.Controls.Add(this.RawMatBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblReportManager);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.cBoxProductRep);
            this.Controls.Add(this.csvStatusStrip);
            this.Controls.Add(this.prodCsvBtn);
            this.Controls.Add(this.RawMatCSVbtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ReportManagerForm";
            this.Text = "Report Manager";
            this.csvStatusStrip.ResumeLayout(false);
            this.csvStatusStrip.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button RawMatCSVbtn;
        private System.Windows.Forms.Button prodCsvBtn;
        private System.Windows.Forms.StatusStrip csvStatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel csvStatusLbl;
        private System.Windows.Forms.ComboBox cBoxProductRep;
        private System.Windows.Forms.SaveFileDialog productCsvSave;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem goBackToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        public System.Windows.Forms.SaveFileDialog rawMatCsvSave;
        private System.Windows.Forms.Label lblReportManager;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewReportsToolStripMenuItem1;
        private System.Windows.Forms.Button RawMatBtn;
        private System.Windows.Forms.Button Productbtn;
    }
}