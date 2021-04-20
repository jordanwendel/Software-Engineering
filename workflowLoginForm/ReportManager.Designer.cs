
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportManager));
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
            this.goBackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.csvStatusStrip.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // RawMatbtn
            // 
            this.RawMatbtn.Location = new System.Drawing.Point(408, 102);
            this.RawMatbtn.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.RawMatbtn.Name = "RawMatbtn";
            this.RawMatbtn.Size = new System.Drawing.Size(570, 208);
            this.RawMatbtn.TabIndex = 0;
            this.RawMatbtn.Text = "View Raw Materials Report";
            this.RawMatbtn.UseVisualStyleBackColor = true;
            this.RawMatbtn.Click += new System.EventHandler(this.RawMatbtn_Click);
            // 
            // Productbtn
            // 
            this.Productbtn.Location = new System.Drawing.Point(1059, 102);
            this.Productbtn.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.Productbtn.Name = "Productbtn";
            this.Productbtn.Size = new System.Drawing.Size(570, 208);
            this.Productbtn.TabIndex = 1;
            this.Productbtn.Text = "View Product Report";
            this.Productbtn.UseVisualStyleBackColor = true;
            this.Productbtn.Click += new System.EventHandler(this.Productbtn_Click);
            // 
            // RawMatCSVbtn
            // 
            this.RawMatCSVbtn.Location = new System.Drawing.Point(408, 493);
            this.RawMatCSVbtn.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.RawMatCSVbtn.Name = "RawMatCSVbtn";
            this.RawMatCSVbtn.Size = new System.Drawing.Size(570, 92);
            this.RawMatCSVbtn.TabIndex = 2;
            this.RawMatCSVbtn.Text = "Generate Raw Material CSV";
            this.RawMatCSVbtn.UseVisualStyleBackColor = true;
            this.RawMatCSVbtn.Click += new System.EventHandler(this.RawMatCSVbtn_Click);
            // 
            // prodCsvBtn
            // 
            this.prodCsvBtn.Location = new System.Drawing.Point(1059, 493);
            this.prodCsvBtn.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.prodCsvBtn.Name = "prodCsvBtn";
            this.prodCsvBtn.Size = new System.Drawing.Size(570, 92);
            this.prodCsvBtn.TabIndex = 3;
            this.prodCsvBtn.Text = "Generate Product CSV";
            this.prodCsvBtn.UseVisualStyleBackColor = true;
            this.prodCsvBtn.Click += new System.EventHandler(this.prodCsvBtn_Click);
            // 
            // csvStatusStrip
            // 
            this.csvStatusStrip.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.csvStatusStrip.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.csvStatusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.csvStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.csvStatusLbl});
            this.csvStatusStrip.Location = new System.Drawing.Point(0, 1019);
            this.csvStatusStrip.Name = "csvStatusStrip";
            this.csvStatusStrip.Padding = new System.Windows.Forms.Padding(2, 0, 33, 0);
            this.csvStatusStrip.Size = new System.Drawing.Size(1900, 22);
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
            this.rawMatCsvSave.FileName = "rawMaterialsReport.csv";
            this.rawMatCsvSave.Filter = "csv files (*.csv)|*.csv|All files (*.*)|*.*";
            this.rawMatCsvSave.InitialDirectory = "C:\\";
            // 
            // cBoxProductRep
            // 
            this.cBoxProductRep.FormattingEnabled = true;
            this.cBoxProductRep.Items.AddRange(new object[] {
            "In Progress",
            "Qualified",
            "Defective",
            "All Products"});
            this.cBoxProductRep.Location = new System.Drawing.Point(1059, 423);
            this.cBoxProductRep.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.cBoxProductRep.Name = "cBoxProductRep";
            this.cBoxProductRep.Size = new System.Drawing.Size(564, 45);
            this.cBoxProductRep.TabIndex = 5;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStrip1.Size = new System.Drawing.Size(1900, 27);
            this.toolStrip1.TabIndex = 66;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.goBackToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(60, 24);
            this.toolStripDropDownButton1.Text = "Menu";
            // 
            // goBackToolStripMenuItem
            // 
            this.goBackToolStripMenuItem.Name = "goBackToolStripMenuItem";
            this.goBackToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.goBackToolStripMenuItem.Text = "Go Back";
            this.goBackToolStripMenuItem.Click += new System.EventHandler(this.goBackToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // ReportManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1900, 1041);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.cBoxProductRep);
            this.Controls.Add(this.csvStatusStrip);
            this.Controls.Add(this.prodCsvBtn);
            this.Controls.Add(this.RawMatCSVbtn);
            this.Controls.Add(this.Productbtn);
            this.Controls.Add(this.RawMatbtn);
            this.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.Name = "ReportManager";
            this.Text = "ReportManager";
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
        private System.Windows.Forms.SaveFileDialog rawMatCsvSave;
        private System.Windows.Forms.ComboBox cBoxProductRep;
        private System.Windows.Forms.SaveFileDialog productCsvSave;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem goBackToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}