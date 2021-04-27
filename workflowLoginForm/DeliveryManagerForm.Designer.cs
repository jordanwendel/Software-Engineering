namespace workflowLoginForm
{
    partial class DeliveryManagerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeliveryManagerForm));
            this.Admin = new System.Windows.Forms.Label();
            this.filterLbl = new System.Windows.Forms.Label();
            this.locationLbl = new System.Windows.Forms.Label();
            this.nameLbl = new System.Windows.Forms.Label();
            this.locationMenu = new System.Windows.Forms.ComboBox();
            this.addItemLbl = new System.Windows.Forms.Label();
            this.prodDataGridView = new System.Windows.Forms.DataGridView();
            this.addItemBtn = new System.Windows.Forms.Button();
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.quantityEquations = new System.Windows.Forms.ComboBox();
            this.cBoxQuality = new System.Windows.Forms.ComboBox();
            this.filterMenu = new System.Windows.Forms.ComboBox();
            this.cBoxLocation = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnFilter = new System.Windows.Forms.Button();
            this.txtFilterByItem = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewProductReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewMaterialsReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.goBackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewReportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnClear2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.prodDataGridView)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Admin
            // 
            this.Admin.Font = new System.Drawing.Font("Lucida Bright", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Admin.ForeColor = System.Drawing.Color.White;
            this.Admin.Location = new System.Drawing.Point(12, 9);
            this.Admin.Name = "Admin";
            this.Admin.Size = new System.Drawing.Size(334, 50);
            this.Admin.TabIndex = 2;
            this.Admin.Text = "Delivery Manager Page";
            this.Admin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Admin.Click += new System.EventHandler(this.Admin_Click);
            // 
            // filterLbl
            // 
            this.filterLbl.AutoSize = true;
            this.filterLbl.Font = new System.Drawing.Font("Lucida Bright", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filterLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.filterLbl.Location = new System.Drawing.Point(81, 296);
            this.filterLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.filterLbl.Name = "filterLbl";
            this.filterLbl.Size = new System.Drawing.Size(119, 22);
            this.filterLbl.TabIndex = 45;
            this.filterLbl.Text = "Filter Items";
            // 
            // locationLbl
            // 
            this.locationLbl.Font = new System.Drawing.Font("Lucida Bright", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locationLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.locationLbl.Location = new System.Drawing.Point(14, 178);
            this.locationLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.locationLbl.Name = "locationLbl";
            this.locationLbl.Size = new System.Drawing.Size(82, 28);
            this.locationLbl.TabIndex = 44;
            this.locationLbl.Text = "Location:";
            this.locationLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // nameLbl
            // 
            this.nameLbl.Font = new System.Drawing.Font("Lucida Bright", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.nameLbl.Location = new System.Drawing.Point(43, 154);
            this.nameLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(52, 28);
            this.nameLbl.TabIndex = 41;
            this.nameLbl.Text = "Item:";
            this.nameLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // locationMenu
            // 
            this.locationMenu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.locationMenu.FormattingEnabled = true;
            this.locationMenu.Items.AddRange(new object[] {
            "Manufacturing",
            "Sales"});
            this.locationMenu.Location = new System.Drawing.Point(104, 184);
            this.locationMenu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.locationMenu.Name = "locationMenu";
            this.locationMenu.Size = new System.Drawing.Size(130, 21);
            this.locationMenu.TabIndex = 1;
            // 
            // addItemLbl
            // 
            this.addItemLbl.AutoSize = true;
            this.addItemLbl.Font = new System.Drawing.Font("Lucida Bright", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addItemLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addItemLbl.Location = new System.Drawing.Point(81, 132);
            this.addItemLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.addItemLbl.Name = "addItemLbl";
            this.addItemLbl.Size = new System.Drawing.Size(137, 22);
            this.addItemLbl.TabIndex = 36;
            this.addItemLbl.Text = "Edit Location";
            // 
            // prodDataGridView
            // 
            this.prodDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.prodDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.prodDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.prodDataGridView.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.prodDataGridView.Location = new System.Drawing.Point(270, 62);
            this.prodDataGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.prodDataGridView.Name = "prodDataGridView";
            this.prodDataGridView.RowHeadersWidth = 51;
            this.prodDataGridView.Size = new System.Drawing.Size(622, 470);
            this.prodDataGridView.TabIndex = 34;
            this.prodDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.prodDataGridView_CellContentClick);
            // 
            // addItemBtn
            // 
            this.addItemBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(220)))), ((int)(((byte)(109)))));
            this.addItemBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addItemBtn.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addItemBtn.Location = new System.Drawing.Point(38, 219);
            this.addItemBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addItemBtn.Name = "addItemBtn";
            this.addItemBtn.Size = new System.Drawing.Size(90, 32);
            this.addItemBtn.TabIndex = 2;
            this.addItemBtn.Text = "Edit";
            this.addItemBtn.UseVisualStyleBackColor = false;
            this.addItemBtn.Click += new System.EventHandler(this.addItemBtn_Click);
            // 
            // txtItemName
            // 
            this.txtItemName.BackColor = System.Drawing.SystemColors.Control;
            this.txtItemName.Location = new System.Drawing.Point(104, 161);
            this.txtItemName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(130, 20);
            this.txtItemName.TabIndex = 0;
            // 
            // quantityEquations
            // 
            this.quantityEquations.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.quantityEquations.FormattingEnabled = true;
            this.quantityEquations.Items.AddRange(new object[] {
            "GREATER THAN",
            "LESS THAN",
            "EQUAL TO"});
            this.quantityEquations.Location = new System.Drawing.Point(111, 403);
            this.quantityEquations.Name = "quantityEquations";
            this.quantityEquations.Size = new System.Drawing.Size(97, 21);
            this.quantityEquations.TabIndex = 7;
            // 
            // cBoxQuality
            // 
            this.cBoxQuality.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxQuality.FormattingEnabled = true;
            this.cBoxQuality.Items.AddRange(new object[] {
            "Satisfactory",
            "Defective",
            "In Progress"});
            this.cBoxQuality.Location = new System.Drawing.Point(111, 381);
            this.cBoxQuality.Name = "cBoxQuality";
            this.cBoxQuality.Size = new System.Drawing.Size(123, 21);
            this.cBoxQuality.TabIndex = 6;
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
            this.filterMenu.Location = new System.Drawing.Point(110, 331);
            this.filterMenu.Name = "filterMenu";
            this.filterMenu.Size = new System.Drawing.Size(123, 21);
            this.filterMenu.TabIndex = 4;
            this.filterMenu.SelectedIndexChanged += new System.EventHandler(this.filterMenu_SelectedIndexChanged);
            // 
            // cBoxLocation
            // 
            this.cBoxLocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxLocation.FormattingEnabled = true;
            this.cBoxLocation.Items.AddRange(new object[] {
            "Sales",
            "Manufacturing",
            "Pending"});
            this.cBoxLocation.Location = new System.Drawing.Point(111, 427);
            this.cBoxLocation.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cBoxLocation.Name = "cBoxLocation";
            this.cBoxLocation.Size = new System.Drawing.Size(123, 21);
            this.cBoxLocation.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Lucida Bright", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(32, 427);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 23);
            this.label5.TabIndex = 73;
            this.label5.Text = "Location:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Lucida Bright", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(32, 403);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 23);
            this.label4.TabIndex = 72;
            this.label4.Text = "Quantity:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(213, 405);
            this.txtNum.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(21, 20);
            this.txtNum.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Lucida Bright", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(29, 381);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 23);
            this.label3.TabIndex = 70;
            this.label3.Text = "Quality:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Bright", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(35, 331);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 69;
            this.label2.Text = "Filter By:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnFilter
            // 
            this.btnFilter.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFilter.Location = new System.Drawing.Point(32, 463);
            this.btnFilter.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(103, 39);
            this.btnFilter.TabIndex = 10;
            this.btnFilter.Text = "FILTER";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // txtFilterByItem
            // 
            this.txtFilterByItem.BackColor = System.Drawing.SystemColors.Control;
            this.txtFilterByItem.Location = new System.Drawing.Point(111, 358);
            this.txtFilterByItem.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtFilterByItem.Name = "txtFilterByItem";
            this.txtFilterByItem.Size = new System.Drawing.Size(123, 20);
            this.txtFilterByItem.TabIndex = 5;
            this.txtFilterByItem.TextChanged += new System.EventHandler(this.txtFilterByItem_TextChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Lucida Bright", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(16, 355);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 23);
            this.label1.TabIndex = 66;
            this.label1.Text = "Item Name:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1189, 28);
            this.menuStrip1.TabIndex = 78;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewProductReportToolStripMenuItem,
            this.viewMaterialsReportToolStripMenuItem,
            this.goBackToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 24);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // viewProductReportToolStripMenuItem
            // 
            this.viewProductReportToolStripMenuItem.Name = "viewProductReportToolStripMenuItem";
            this.viewProductReportToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.viewProductReportToolStripMenuItem.Text = "View Product Report";
            // 
            // viewMaterialsReportToolStripMenuItem
            // 
            this.viewMaterialsReportToolStripMenuItem.Name = "viewMaterialsReportToolStripMenuItem";
            this.viewMaterialsReportToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.viewMaterialsReportToolStripMenuItem.Text = "View Materials Report";
            // 
            // goBackToolStripMenuItem
            // 
            this.goBackToolStripMenuItem.Name = "goBackToolStripMenuItem";
            this.goBackToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.goBackToolStripMenuItem.Text = "Go Back";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // menuStrip2
            // 
            this.menuStrip2.BackColor = System.Drawing.Color.LightGray;
            this.menuStrip2.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip2.Location = new System.Drawing.Point(728, 7);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip2.Size = new System.Drawing.Size(57, 24);
            this.menuStrip2.TabIndex = 80;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshToolStripMenuItem,
            this.toolStripMenuItem4,
            this.viewToolStripMenuItem,
            this.toolStripMenuItem5});
            this.toolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(51, 20);
            this.toolStripMenuItem1.Text = "Menu";
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.refreshToolStripMenuItem.Text = "Refresh";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(120, 22);
            this.toolStripMenuItem4.Text = "Go Back";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
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
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(120, 22);
            this.toolStripMenuItem5.Text = "Exit";
            this.toolStripMenuItem5.Click += new System.EventHandler(this.toolStripMenuItem5_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(140, 463);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(103, 39);
            this.btnClear.TabIndex = 11;
            this.btnClear.Text = "CLEAR";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnClear2
            // 
            this.btnClear2.BackColor = System.Drawing.Color.LightGray;
            this.btnClear2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear2.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear2.Location = new System.Drawing.Point(152, 219);
            this.btnClear2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnClear2.Name = "btnClear2";
            this.btnClear2.Size = new System.Drawing.Size(90, 32);
            this.btnClear2.TabIndex = 3;
            this.btnClear2.Text = "Clear";
            this.btnClear2.UseVisualStyleBackColor = false;
            this.btnClear2.Click += new System.EventHandler(this.btnClear2_Click);
            // 
            // DeliveryManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(898, 543);
            this.Controls.Add(this.btnClear2);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.menuStrip2);
            this.Controls.Add(this.quantityEquations);
            this.Controls.Add(this.cBoxQuality);
            this.Controls.Add(this.filterMenu);
            this.Controls.Add(this.cBoxLocation);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.txtFilterByItem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtItemName);
            this.Controls.Add(this.addItemBtn);
            this.Controls.Add(this.filterLbl);
            this.Controls.Add(this.locationLbl);
            this.Controls.Add(this.nameLbl);
            this.Controls.Add(this.locationMenu);
            this.Controls.Add(this.addItemLbl);
            this.Controls.Add(this.prodDataGridView);
            this.Controls.Add(this.Admin);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "DeliveryManagerForm";
            this.Text = "Delivery Manager";
            this.Load += new System.EventHandler(this.DeliveryManagerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.prodDataGridView)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Admin;
        private System.Windows.Forms.Label filterLbl;
        private System.Windows.Forms.Label locationLbl;
        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.ComboBox locationMenu;
        private System.Windows.Forms.Label addItemLbl;
        private System.Windows.Forms.DataGridView prodDataGridView;
        private System.Windows.Forms.Button addItemBtn;
        private System.Windows.Forms.TextBox txtItemName;
        private System.Windows.Forms.ComboBox quantityEquations;
        private System.Windows.Forms.ComboBox cBoxQuality;
        private System.Windows.Forms.ComboBox filterMenu;
        private System.Windows.Forms.ComboBox cBoxLocation;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.TextBox txtFilterByItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewProductReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewMaterialsReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem goBackToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewReportsToolStripMenuItem;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnClear2;
    }
}

