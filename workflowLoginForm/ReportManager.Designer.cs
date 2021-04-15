
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
            this.prodCsvBtn = new System.Windows.Forms.Button();
            this.csvStatusStrip = new System.Windows.Forms.StatusStrip();
            this.csvStatusLbl = new System.Windows.Forms.ToolStripStatusLabel();
            this.rawMatCsvSave = new System.Windows.Forms.SaveFileDialog();
            this.cBoxProductRep = new System.Windows.Forms.ComboBox();
            this.productCsvSave = new System.Windows.Forms.SaveFileDialog();
            this.csvStatusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // RawMatbtn
            // 
            this.RawMatbtn.Location = new System.Drawing.Point(172, 44);
            this.RawMatbtn.Name = "RawMatbtn";
            this.RawMatbtn.Size = new System.Drawing.Size(240, 90);
            this.RawMatbtn.TabIndex = 0;
            this.RawMatbtn.Text = "View Raw Materials Report";
            this.RawMatbtn.UseVisualStyleBackColor = true;
            this.RawMatbtn.Click += new System.EventHandler(this.RawMatbtn_Click);
            // 
            // Productbtn
            // 
            this.Productbtn.Location = new System.Drawing.Point(446, 44);
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
            this.RawMatCSVbtn.Text = "Generate Raw Material CSV";
            this.RawMatCSVbtn.UseVisualStyleBackColor = true;
            this.RawMatCSVbtn.Click += new System.EventHandler(this.RawMatCSVbtn_Click);
            // 
            // prodCsvBtn
            // 
            this.prodCsvBtn.Location = new System.Drawing.Point(446, 213);
            this.prodCsvBtn.Name = "prodCsvBtn";
            this.prodCsvBtn.Size = new System.Drawing.Size(240, 40);
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
            this.cBoxProductRep.Location = new System.Drawing.Point(446, 183);
            this.cBoxProductRep.Name = "cBoxProductRep";
            this.cBoxProductRep.Size = new System.Drawing.Size(240, 24);
            this.cBoxProductRep.TabIndex = 5;
            // 
            // ReportManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cBoxProductRep);
            this.Controls.Add(this.csvStatusStrip);
            this.Controls.Add(this.prodCsvBtn);
            this.Controls.Add(this.RawMatCSVbtn);
            this.Controls.Add(this.Productbtn);
            this.Controls.Add(this.RawMatbtn);
            this.Name = "ReportManager";
            this.Text = "ReportManager";
            this.csvStatusStrip.ResumeLayout(false);
            this.csvStatusStrip.PerformLayout();
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
    }
}