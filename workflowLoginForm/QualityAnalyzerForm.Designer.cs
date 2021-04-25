namespace workflowLoginForm
{
    partial class QualityAnalyzerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QualityAnalyzerForm));
            this.addItemBtn = new System.Windows.Forms.Button();
            this.filterLbl = new System.Windows.Forms.Label();
            this.qualityLbl = new System.Windows.Forms.Label();
            this.nameLbl = new System.Windows.Forms.Label();
            this.qualityMenu = new System.Windows.Forms.ComboBox();
            this.addItemLbl = new System.Windows.Forms.Label();
            this.prodDataGridView = new System.Windows.Forms.DataGridView();
            this.Admin = new System.Windows.Forms.Label();
            this.ItemName = new System.Windows.Forms.TextBox();
            this.cBoxLocation = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnFilter = new System.Windows.Forms.Button();
            this.txtFilterByItem = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.quantityEquations = new System.Windows.Forms.TextBox();
            this.cBoxQuality = new System.Windows.Forms.ComboBox();
            this.filterMenu = new System.Windows.Forms.ComboBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.goBackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewReportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.prodDataGridView)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // addItemBtn
            // 
            this.addItemBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(220)))), ((int)(((byte)(109)))));
            this.addItemBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addItemBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addItemBtn.Location = new System.Drawing.Point(79, 236);
            this.addItemBtn.Margin = new System.Windows.Forms.Padding(2);
            this.addItemBtn.Name = "addItemBtn";
            this.addItemBtn.Size = new System.Drawing.Size(90, 32);
            this.addItemBtn.TabIndex = 46;
            this.addItemBtn.Text = "EDIT";
            this.addItemBtn.UseVisualStyleBackColor = false;
            this.addItemBtn.Click += new System.EventHandler(this.addItemBtn_Click);
            // 
            // filterLbl
            // 
            this.filterLbl.Font = new System.Drawing.Font("Impact", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filterLbl.ForeColor = System.Drawing.Color.White;
            this.filterLbl.Location = new System.Drawing.Point(49, 301);
            this.filterLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.filterLbl.Name = "filterLbl";
            this.filterLbl.Size = new System.Drawing.Size(167, 36);
            this.filterLbl.TabIndex = 45;
            this.filterLbl.Text = "Filter Items";
            this.filterLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.filterLbl.Click += new System.EventHandler(this.filterLbl_Click);
            // 
            // qualityLbl
            // 
            this.qualityLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qualityLbl.ForeColor = System.Drawing.Color.White;
            this.qualityLbl.Location = new System.Drawing.Point(30, 192);
            this.qualityLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.qualityLbl.Name = "qualityLbl";
            this.qualityLbl.Size = new System.Drawing.Size(68, 24);
            this.qualityLbl.TabIndex = 42;
            this.qualityLbl.Text = "Quality: ";
            this.qualityLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.qualityLbl.Click += new System.EventHandler(this.qualityLbl_Click);
            // 
            // nameLbl
            // 
            this.nameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLbl.ForeColor = System.Drawing.Color.White;
            this.nameLbl.Location = new System.Drawing.Point(46, 167);
            this.nameLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(46, 23);
            this.nameLbl.TabIndex = 41;
            this.nameLbl.Text = "Item:";
            this.nameLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // qualityMenu
            // 
            this.qualityMenu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.qualityMenu.FormattingEnabled = true;
            this.qualityMenu.Items.AddRange(new object[] {
            "Satisfactory",
            "Defective"});
            this.qualityMenu.Location = new System.Drawing.Point(109, 197);
            this.qualityMenu.Name = "qualityMenu";
            this.qualityMenu.Size = new System.Drawing.Size(119, 21);
            this.qualityMenu.TabIndex = 38;
            // 
            // addItemLbl
            // 
            this.addItemLbl.Font = new System.Drawing.Font("Impact", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addItemLbl.ForeColor = System.Drawing.Color.White;
            this.addItemLbl.Location = new System.Drawing.Point(44, 120);
            this.addItemLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.addItemLbl.Name = "addItemLbl";
            this.addItemLbl.Size = new System.Drawing.Size(172, 30);
            this.addItemLbl.TabIndex = 36;
            this.addItemLbl.Text = "Edit Quality";
            this.addItemLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // prodDataGridView
            // 
            this.prodDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.prodDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.prodDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.prodDataGridView.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.prodDataGridView.Location = new System.Drawing.Point(245, 74);
            this.prodDataGridView.Name = "prodDataGridView";
            this.prodDataGridView.RowHeadersWidth = 51;
            this.prodDataGridView.Size = new System.Drawing.Size(643, 458);
            this.prodDataGridView.TabIndex = 34;
            this.prodDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.prodDataGridView_CellContentClick);
            // 
            // Admin
            // 
            this.Admin.Font = new System.Drawing.Font("Impact", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Admin.ForeColor = System.Drawing.Color.White;
            this.Admin.Location = new System.Drawing.Point(3, 20);
            this.Admin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Admin.Name = "Admin";
            this.Admin.Size = new System.Drawing.Size(307, 41);
            this.Admin.TabIndex = 30;
            this.Admin.Text = "Quality Analyzer Page";
            this.Admin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Admin.Click += new System.EventHandler(this.Admin_Click_1);
            // 
            // ItemName
            // 
            this.ItemName.BackColor = System.Drawing.SystemColors.Control;
            this.ItemName.Location = new System.Drawing.Point(109, 171);
            this.ItemName.Margin = new System.Windows.Forms.Padding(2);
            this.ItemName.Name = "ItemName";
            this.ItemName.Size = new System.Drawing.Size(119, 20);
            this.ItemName.TabIndex = 47;
            // 
            // cBoxLocation
            // 
            this.cBoxLocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxLocation.FormattingEnabled = true;
            this.cBoxLocation.Items.AddRange(new object[] {
            "Sales",
            "Manufacturing"});
            this.cBoxLocation.Location = new System.Drawing.Point(104, 448);
            this.cBoxLocation.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cBoxLocation.Name = "cBoxLocation";
            this.cBoxLocation.Size = new System.Drawing.Size(123, 21);
            this.cBoxLocation.TabIndex = 61;
            this.cBoxLocation.SelectedIndexChanged += new System.EventHandler(this.cBoxLocation_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(24, 448);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 23);
            this.label5.TabIndex = 60;
            this.label5.Text = "Location:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(24, 425);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 23);
            this.label4.TabIndex = 59;
            this.label4.Text = "Quantity:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtNum
            // 
            this.txtNum.BackColor = System.Drawing.SystemColors.Control;
            this.txtNum.Location = new System.Drawing.Point(190, 427);
            this.txtNum.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(38, 20);
            this.txtNum.TabIndex = 58;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(22, 402);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 23);
            this.label3.TabIndex = 57;
            this.label3.Text = "Quality:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(31, 351);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 18);
            this.label2.TabIndex = 56;
            this.label2.Text = "Filter By:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnFilter
            // 
            this.btnFilter.BackColor = System.Drawing.Color.LightGray;
            this.btnFilter.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFilter.Location = new System.Drawing.Point(79, 489);
            this.btnFilter.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(90, 32);
            this.btnFilter.TabIndex = 55;
            this.btnFilter.Text = "FILTER";
            this.btnFilter.UseVisualStyleBackColor = false;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // txtFilterByItem
            // 
            this.txtFilterByItem.BackColor = System.Drawing.SystemColors.Control;
            this.txtFilterByItem.Location = new System.Drawing.Point(104, 379);
            this.txtFilterByItem.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtFilterByItem.Name = "txtFilterByItem";
            this.txtFilterByItem.Size = new System.Drawing.Size(123, 20);
            this.txtFilterByItem.TabIndex = 54;
            this.txtFilterByItem.TextChanged += new System.EventHandler(this.txtFilterByItem_TextChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(9, 376);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 23);
            this.label1.TabIndex = 53;
            this.label1.Text = "Item Name:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // quantityEquations
            // 
            this.quantityEquations.BackColor = System.Drawing.SystemColors.Control;
            this.quantityEquations.Location = new System.Drawing.Point(104, 425);
            this.quantityEquations.Margin = new System.Windows.Forms.Padding(2);
            this.quantityEquations.Name = "quantityEquations";
            this.quantityEquations.Size = new System.Drawing.Size(76, 20);
            this.quantityEquations.TabIndex = 63;
            // 
            // cBoxQuality
            // 
            this.cBoxQuality.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxQuality.FormattingEnabled = true;
            this.cBoxQuality.Items.AddRange(new object[] {
            "Qualified",
            "Defective"});
            this.cBoxQuality.Location = new System.Drawing.Point(104, 401);
            this.cBoxQuality.Margin = new System.Windows.Forms.Padding(2);
            this.cBoxQuality.Name = "cBoxQuality";
            this.cBoxQuality.Size = new System.Drawing.Size(123, 21);
            this.cBoxQuality.TabIndex = 64;
            // 
            // filterMenu
            // 
            this.filterMenu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.filterMenu.FormattingEnabled = true;
            this.filterMenu.Items.AddRange(new object[] {
            "Name",
            "Quality",
            "Quantity",
            "Location"});
            this.filterMenu.Location = new System.Drawing.Point(104, 351);
            this.filterMenu.Margin = new System.Windows.Forms.Padding(2);
            this.filterMenu.Name = "filterMenu";
            this.filterMenu.Size = new System.Drawing.Size(123, 21);
            this.filterMenu.TabIndex = 65;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1});
            this.toolStrip1.Location = new System.Drawing.Point(812, 7);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(55, 25);
            this.toolStrip1.TabIndex = 66;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.BackColor = System.Drawing.Color.LightGray;
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
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(52, 22);
            this.toolStripDropDownButton1.Text = "Menu";
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.refreshToolStripMenuItem.Text = "Refresh";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
            // 
            // goBackToolStripMenuItem
            // 
            this.goBackToolStripMenuItem.Name = "goBackToolStripMenuItem";
            this.goBackToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.goBackToolStripMenuItem.Text = "Go Back";
            this.goBackToolStripMenuItem.Click += new System.EventHandler(this.goBackToolStripMenuItem_Click_1);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewReportsToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // viewReportsToolStripMenuItem
            // 
            this.viewReportsToolStripMenuItem.Name = "viewReportsToolStripMenuItem";
            this.viewReportsToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.viewReportsToolStripMenuItem.Text = "View Reports";
            this.viewReportsToolStripMenuItem.Click += new System.EventHandler(this.viewReportsToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click_1);
            // 
            // QualityAnalyzerForm
            // 
            this.AcceptButton = this.btnFilter;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(898, 543);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.filterMenu);
            this.Controls.Add(this.cBoxQuality);
            this.Controls.Add(this.quantityEquations);
            this.Controls.Add(this.cBoxLocation);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.txtFilterByItem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ItemName);
            this.Controls.Add(this.addItemBtn);
            this.Controls.Add(this.filterLbl);
            this.Controls.Add(this.qualityLbl);
            this.Controls.Add(this.nameLbl);
            this.Controls.Add(this.qualityMenu);
            this.Controls.Add(this.addItemLbl);
            this.Controls.Add(this.prodDataGridView);
            this.Controls.Add(this.Admin);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "QualityAnalyzerForm";
            this.Text = "Quality Analyzer";
            this.Load += new System.EventHandler(this.QualityAnalyzerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.prodDataGridView)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addItemBtn;
        private System.Windows.Forms.Label filterLbl;
        private System.Windows.Forms.Label qualityLbl;
        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.ComboBox qualityMenu;
        private System.Windows.Forms.Label addItemLbl;
        private System.Windows.Forms.DataGridView prodDataGridView;
        private System.Windows.Forms.Label Admin;
        private System.Windows.Forms.TextBox ItemName;
        private System.Windows.Forms.ComboBox cBoxLocation;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.TextBox txtFilterByItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox quantityEquations;
        private System.Windows.Forms.ComboBox cBoxQuality;
        private System.Windows.Forms.ComboBox filterMenu;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem goBackToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewReportsToolStripMenuItem;
    }
}

