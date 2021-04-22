
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
            this.RawMatbtn = new System.Windows.Forms.Button();
            this.Productbtn = new System.Windows.Forms.Button();
            this.RawMatCSVbtn = new System.Windows.Forms.Button();
            this.prodCsvBtn = new System.Windows.Forms.Button();
            this.csvStatusStrip = new System.Windows.Forms.StatusStrip();
            this.csvStatusLbl = new System.Windows.Forms.ToolStripStatusLabel();
            this.rawMatCsvSave = new System.Windows.Forms.SaveFileDialog();
            this.cBoxProductRep = new System.Windows.Forms.ComboBox();
            this.productCsvSave = new System.Windows.Forms.SaveFileDialog();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.viewReportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.goBackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblReportManager = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.csvStatusStrip.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // RawMatbtn
            // 
            this.RawMatbtn.BackColor = System.Drawing.Color.LightGray;
            this.RawMatbtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.RawMatbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RawMatbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RawMatbtn.Location = new System.Drawing.Point(118, 189);
            this.RawMatbtn.Name = "RawMatbtn";
            this.RawMatbtn.Size = new System.Drawing.Size(150, 50);
            this.RawMatbtn.TabIndex = 0;
            this.RawMatbtn.Text = "VIEW REPORT";
            this.RawMatbtn.UseVisualStyleBackColor = false;
            this.RawMatbtn.Click += new System.EventHandler(this.RawMatbtn_Click);
            // 
            // Productbtn
            // 
            this.Productbtn.BackColor = System.Drawing.Color.LightGray;
            this.Productbtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Productbtn.FlatAppearance.BorderSize = 2;
            this.Productbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Productbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Productbtn.Location = new System.Drawing.Point(527, 189);
            this.Productbtn.Name = "Productbtn";
            this.Productbtn.Size = new System.Drawing.Size(150, 50);
            this.Productbtn.TabIndex = 1;
            this.Productbtn.Text = "VIEW REPORT";
            this.Productbtn.UseVisualStyleBackColor = false;
            this.Productbtn.Click += new System.EventHandler(this.Productbtn_Click);
            // 
            // RawMatCSVbtn
            // 
            this.RawMatCSVbtn.BackColor = System.Drawing.Color.LightGray;
            this.RawMatCSVbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RawMatCSVbtn.Location = new System.Drawing.Point(88, 373);
            this.RawMatCSVbtn.Name = "RawMatCSVbtn";
            this.RawMatCSVbtn.Size = new System.Drawing.Size(200, 40);
            this.RawMatCSVbtn.TabIndex = 2;
            this.RawMatCSVbtn.Text = "GENERATE REPORT CSV";
            this.RawMatCSVbtn.UseVisualStyleBackColor = false;
            this.RawMatCSVbtn.Click += new System.EventHandler(this.RawMatCSVbtn_Click);
            // 
            // prodCsvBtn
            // 
            this.prodCsvBtn.BackColor = System.Drawing.Color.LightGray;
            this.prodCsvBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.prodCsvBtn.Location = new System.Drawing.Point(499, 373);
            this.prodCsvBtn.Name = "prodCsvBtn";
            this.prodCsvBtn.Size = new System.Drawing.Size(200, 40);
            this.prodCsvBtn.TabIndex = 3;
            this.prodCsvBtn.Text = "GENERATE REPORT CSV";
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
            this.csvStatusStrip.Location = new System.Drawing.Point(0, 428);
            this.csvStatusStrip.Name = "csvStatusStrip";
            this.csvStatusStrip.Size = new System.Drawing.Size(800, 22);
            this.csvStatusStrip.TabIndex = 4;
            this.csvStatusStrip.Text = "statusStrip1";
            // 
            // csvStatusLbl
            // 
            this.csvStatusLbl.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.csvStatusLbl.ForeColor = System.Drawing.SystemColors.Control;
            this.csvStatusLbl.Name = "csvStatusLbl";
            this.csvStatusLbl.Size = new System.Drawing.Size(0, 16);
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
            this.cBoxProductRep.Location = new System.Drawing.Point(499, 319);
            this.cBoxProductRep.Name = "cBoxProductRep";
            this.cBoxProductRep.Size = new System.Drawing.Size(200, 24);
            this.cBoxProductRep.TabIndex = 5;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1});
            this.toolStrip1.Location = new System.Drawing.Point(695, 9);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(66, 27);
            this.toolStrip1.TabIndex = 66;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripDropDownButton1.BackColor = System.Drawing.Color.LightGray;
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewReportsToolStripMenuItem,
            this.goBackToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.toolStripDropDownButton1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(63, 24);
            this.toolStripDropDownButton1.Text = "Menu";
            // 
            // viewReportsToolStripMenuItem
            // 
            this.viewReportsToolStripMenuItem.Name = "viewReportsToolStripMenuItem";
            this.viewReportsToolStripMenuItem.Size = new System.Drawing.Size(185, 26);
            this.viewReportsToolStripMenuItem.Text = "View Reports";
            this.viewReportsToolStripMenuItem.Click += new System.EventHandler(this.viewReportsToolStripMenuItem_Click);
            // 
            // goBackToolStripMenuItem
            // 
            this.goBackToolStripMenuItem.Name = "goBackToolStripMenuItem";
            this.goBackToolStripMenuItem.Size = new System.Drawing.Size(185, 26);
            this.goBackToolStripMenuItem.Text = "Go Back";
            this.goBackToolStripMenuItem.Click += new System.EventHandler(this.goBackToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(185, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // lblReportManager
            // 
            this.lblReportManager.AutoSize = true;
            this.lblReportManager.Font = new System.Drawing.Font("Impact", 26.25F);
            this.lblReportManager.ForeColor = System.Drawing.Color.White;
            this.lblReportManager.Location = new System.Drawing.Point(211, 33);
            this.lblReportManager.Name = "lblReportManager";
            this.lblReportManager.Size = new System.Drawing.Size(417, 54);
            this.lblReportManager.TabIndex = 67;
            this.lblReportManager.Text = "Report Manager Page ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(113, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 29);
            this.label1.TabIndex = 68;
            this.label1.Text = "Material Report";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Impact", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(522, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 29);
            this.label2.TabIndex = 69;
            this.label2.Text = "Product Report";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(505, 291);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 25);
            this.label3.TabIndex = 70;
            this.label3.Text = "Select Product Type:";
            // 
            // ReportManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblReportManager);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.cBoxProductRep);
            this.Controls.Add(this.csvStatusStrip);
            this.Controls.Add(this.prodCsvBtn);
            this.Controls.Add(this.RawMatCSVbtn);
            this.Controls.Add(this.Productbtn);
            this.Controls.Add(this.RawMatbtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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

        private System.Windows.Forms.Button RawMatbtn;
        private System.Windows.Forms.Button Productbtn;
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
        private System.Windows.Forms.ToolStripMenuItem viewReportsToolStripMenuItem;
    }
}