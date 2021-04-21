namespace workflowLoginForm
{
    public partial class ProductManagerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductManagerForm));
            this.Admin = new System.Windows.Forms.Label();
            this.prodDataGridView = new System.Windows.Forms.DataGridView();
            this.addItemLbl = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.nameLbl = new System.Windows.Forms.Label();
            this.quantityLbl = new System.Windows.Forms.Label();
            this.filterLbl = new System.Windows.Forms.Label();
            this.addItemBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFilterByItem = new System.Windows.Forms.TextBox();
            this.btnFilter = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cBoxLocation = new System.Windows.Forms.ComboBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.filterMenu = new System.Windows.Forms.ComboBox();
            this.cBoxQuality = new System.Windows.Forms.ComboBox();
            this.quantityEquations = new System.Windows.Forms.ComboBox();
            this.stsStripDisplayInfo = new System.Windows.Forms.StatusStrip();
            this.stsStripLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.removeItemBtn = new System.Windows.Forms.Button();
            this.itemsView = new System.Windows.Forms.ListView();
            this.rawMatsView = new System.Windows.Forms.ListView();
            this.confirmChangesBtn = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewProductReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewMaterialsReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.goBackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.switchToProductTableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.switchToMaterialsTableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.prodDataGridView)).BeginInit();
            this.stsStripDisplayInfo.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Admin
            // 
            this.Admin.Font = new System.Drawing.Font("Impact", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Admin.ForeColor = System.Drawing.Color.White;
            this.Admin.Location = new System.Drawing.Point(14, 9);
            this.Admin.Name = "Admin";
            this.Admin.Size = new System.Drawing.Size(431, 62);
            this.Admin.TabIndex = 2;
            this.Admin.Text = "Product Manager Page";
            this.Admin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // prodDataGridView
            // 
            this.prodDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.prodDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.prodDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.prodDataGridView.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.prodDataGridView.Location = new System.Drawing.Point(397, 75);
            this.prodDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.prodDataGridView.Name = "prodDataGridView";
            this.prodDataGridView.RowHeadersWidth = 51;
            this.prodDataGridView.Size = new System.Drawing.Size(787, 559);
            this.prodDataGridView.TabIndex = 12;
            this.prodDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.prodDataGridView_CellContentClick);
            // 
            // addItemLbl
            // 
            this.addItemLbl.Font = new System.Drawing.Font("Impact", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addItemLbl.ForeColor = System.Drawing.Color.White;
            this.addItemLbl.Location = new System.Drawing.Point(49, 96);
            this.addItemLbl.Name = "addItemLbl";
            this.addItemLbl.Size = new System.Drawing.Size(288, 37);
            this.addItemLbl.TabIndex = 19;
            this.addItemLbl.Text = "Add Product";
            this.addItemLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(126, 176);
            this.txtQuantity.Margin = new System.Windows.Forms.Padding(4);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(172, 22);
            this.txtQuantity.TabIndex = 22;
            // 
            // nameLbl
            // 
            this.nameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLbl.ForeColor = System.Drawing.Color.White;
            this.nameLbl.Location = new System.Drawing.Point(50, 140);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(61, 28);
            this.nameLbl.TabIndex = 24;
            this.nameLbl.Text = "Item:";
            this.nameLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // quantityLbl
            // 
            this.quantityLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityLbl.ForeColor = System.Drawing.Color.White;
            this.quantityLbl.Location = new System.Drawing.Point(15, 169);
            this.quantityLbl.Name = "quantityLbl";
            this.quantityLbl.Size = new System.Drawing.Size(103, 28);
            this.quantityLbl.TabIndex = 26;
            this.quantityLbl.Text = "Quantity:";
            this.quantityLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // filterLbl
            // 
            this.filterLbl.Font = new System.Drawing.Font("Impact", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filterLbl.ForeColor = System.Drawing.Color.White;
            this.filterLbl.Location = new System.Drawing.Point(84, 408);
            this.filterLbl.Name = "filterLbl";
            this.filterLbl.Size = new System.Drawing.Size(203, 44);
            this.filterLbl.TabIndex = 28;
            this.filterLbl.Text = "Filter Items";
            this.filterLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // addItemBtn
            // 
            this.addItemBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(220)))), ((int)(((byte)(109)))));
            this.addItemBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addItemBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addItemBtn.Location = new System.Drawing.Point(134, 220);
            this.addItemBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addItemBtn.Name = "addItemBtn";
            this.addItemBtn.Size = new System.Drawing.Size(134, 34);
            this.addItemBtn.TabIndex = 29;
            this.addItemBtn.Text = "ADD ";
            this.addItemBtn.UseVisualStyleBackColor = false;
            this.addItemBtn.Click += new System.EventHandler(this.addItemBtn_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(-1, 497);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 28);
            this.label1.TabIndex = 32;
            this.label1.Text = "Item Name:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtFilterByItem
            // 
            this.txtFilterByItem.Location = new System.Drawing.Point(126, 501);
            this.txtFilterByItem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFilterByItem.Name = "txtFilterByItem";
            this.txtFilterByItem.Size = new System.Drawing.Size(163, 22);
            this.txtFilterByItem.TabIndex = 33;
            this.txtFilterByItem.TextChanged += new System.EventHandler(this.txtFilterByItem_TextChanged);
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(303, 509);
            this.btnFilter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(87, 48);
            this.btnFilter.TabIndex = 34;
            this.btnFilter.Text = "Filter";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(24, 467);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 24);
            this.label2.TabIndex = 37;
            this.label2.Text = "Filter By:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(16, 529);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 28);
            this.label3.TabIndex = 41;
            this.label3.Text = "Quality:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(262, 559);
            this.txtNum.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(27, 22);
            this.txtNum.TabIndex = 44;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(19, 557);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 28);
            this.label4.TabIndex = 45;
            this.label4.Text = "Quantity:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(19, 586);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 28);
            this.label5.TabIndex = 46;
            this.label5.Text = "Location:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cBoxLocation
            // 
            this.cBoxLocation.FormattingEnabled = true;
            this.cBoxLocation.Items.AddRange(new object[] {
            "Sales",
            "Manufacturing"});
            this.cBoxLocation.Location = new System.Drawing.Point(126, 586);
            this.cBoxLocation.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cBoxLocation.Name = "cBoxLocation";
            this.cBoxLocation.Size = new System.Drawing.Size(163, 24);
            this.cBoxLocation.TabIndex = 47;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(126, 145);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(172, 22);
            this.txtName.TabIndex = 48;
            // 
            // filterMenu
            // 
            this.filterMenu.FormattingEnabled = true;
            this.filterMenu.Items.AddRange(new object[] {
            "Name",
            "Quality",
            "Quantity",
            "Location"});
            this.filterMenu.Location = new System.Drawing.Point(124, 467);
            this.filterMenu.Margin = new System.Windows.Forms.Padding(4);
            this.filterMenu.Name = "filterMenu";
            this.filterMenu.Size = new System.Drawing.Size(163, 24);
            this.filterMenu.TabIndex = 49;
            this.filterMenu.Text = "Click to Expand...";
            this.filterMenu.SelectedIndexChanged += new System.EventHandler(this.filterMenu_SelectedIndexChanged);
            // 
            // cBoxQuality
            // 
            this.cBoxQuality.FormattingEnabled = true;
            this.cBoxQuality.Items.AddRange(new object[] {
            "Satisfactory",
            "Defective",
            "In Progress"});
            this.cBoxQuality.Location = new System.Drawing.Point(126, 529);
            this.cBoxQuality.Margin = new System.Windows.Forms.Padding(4);
            this.cBoxQuality.Name = "cBoxQuality";
            this.cBoxQuality.Size = new System.Drawing.Size(163, 24);
            this.cBoxQuality.TabIndex = 50;
            // 
            // quantityEquations
            // 
            this.quantityEquations.FormattingEnabled = true;
            this.quantityEquations.Items.AddRange(new object[] {
            "GREATER THAN",
            "LESS THAN",
            "EQUAL TO"});
            this.quantityEquations.Location = new System.Drawing.Point(126, 557);
            this.quantityEquations.Margin = new System.Windows.Forms.Padding(4);
            this.quantityEquations.Name = "quantityEquations";
            this.quantityEquations.Size = new System.Drawing.Size(128, 24);
            this.quantityEquations.TabIndex = 51;
            // 
            // stsStripDisplayInfo
            // 
            this.stsStripDisplayInfo.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.stsStripDisplayInfo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stsStripLabel});
            this.stsStripDisplayInfo.Location = new System.Drawing.Point(0, 644);
            this.stsStripDisplayInfo.Name = "stsStripDisplayInfo";
            this.stsStripDisplayInfo.Padding = new System.Windows.Forms.Padding(1, 0, 13, 0);
            this.stsStripDisplayInfo.Size = new System.Drawing.Size(1193, 22);
            this.stsStripDisplayInfo.TabIndex = 53;
            // 
            // stsStripLabel
            // 
            this.stsStripLabel.BackColor = System.Drawing.Color.White;
            this.stsStripLabel.Name = "stsStripLabel";
            this.stsStripLabel.Size = new System.Drawing.Size(0, 16);
            // 
            // removeItemBtn
            // 
            this.removeItemBtn.BackColor = System.Drawing.Color.Firebrick;
            this.removeItemBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeItemBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeItemBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.removeItemBtn.Location = new System.Drawing.Point(134, 220);
            this.removeItemBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.removeItemBtn.Name = "removeItemBtn";
            this.removeItemBtn.Size = new System.Drawing.Size(134, 34);
            this.removeItemBtn.TabIndex = 54;
            this.removeItemBtn.Text = "REMOVE";
            this.removeItemBtn.UseVisualStyleBackColor = false;
            this.removeItemBtn.Click += new System.EventHandler(this.removeItemBtn_Click);
            // 
            // itemsView
            // 
            this.itemsView.HideSelection = false;
            this.itemsView.Location = new System.Drawing.Point(3, 258);
            this.itemsView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.itemsView.Name = "itemsView";
            this.itemsView.Size = new System.Drawing.Size(192, 116);
            this.itemsView.TabIndex = 55;
            this.itemsView.UseCompatibleStateImageBehavior = false;
            this.itemsView.View = System.Windows.Forms.View.SmallIcon;
            // 
            // rawMatsView
            // 
            this.rawMatsView.HideSelection = false;
            this.rawMatsView.Location = new System.Drawing.Point(201, 258);
            this.rawMatsView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rawMatsView.Name = "rawMatsView";
            this.rawMatsView.Size = new System.Drawing.Size(189, 116);
            this.rawMatsView.TabIndex = 56;
            this.rawMatsView.UseCompatibleStateImageBehavior = false;
            this.rawMatsView.View = System.Windows.Forms.View.SmallIcon;
            // 
            // confirmChangesBtn
            // 
            this.confirmChangesBtn.Location = new System.Drawing.Point(303, 391);
            this.confirmChangesBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.confirmChangesBtn.Name = "confirmChangesBtn";
            this.confirmChangesBtn.Size = new System.Drawing.Size(87, 38);
            this.confirmChangesBtn.TabIndex = 57;
            this.confirmChangesBtn.Text = "Confirm";
            this.confirmChangesBtn.UseVisualStyleBackColor = true;
            this.confirmChangesBtn.Click += new System.EventHandler(this.confirmChangesBtn_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1193, 28);
            this.menuStrip1.TabIndex = 79;
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
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(60, 24);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // viewProductReportToolStripMenuItem
            // 
            this.viewProductReportToolStripMenuItem.Name = "viewProductReportToolStripMenuItem";
            this.viewProductReportToolStripMenuItem.Size = new System.Drawing.Size(238, 26);
            this.viewProductReportToolStripMenuItem.Text = "View Product Report";
            // 
            // viewMaterialsReportToolStripMenuItem
            // 
            this.viewMaterialsReportToolStripMenuItem.Name = "viewMaterialsReportToolStripMenuItem";
            this.viewMaterialsReportToolStripMenuItem.Size = new System.Drawing.Size(238, 26);
            this.viewMaterialsReportToolStripMenuItem.Text = "View Materials Report";
            // 
            // goBackToolStripMenuItem
            // 
            this.goBackToolStripMenuItem.Name = "goBackToolStripMenuItem";
            this.goBackToolStripMenuItem.Size = new System.Drawing.Size(238, 26);
            this.goBackToolStripMenuItem.Text = "Go Back";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(238, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1});
            this.toolStrip1.Location = new System.Drawing.Point(1121, 9);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(63, 27);
            this.toolStrip1.TabIndex = 66;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripDropDownButton1.BackColor = System.Drawing.Color.LightGray;
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.switchToProductTableToolStripMenuItem,
            this.switchToMaterialsTableToolStripMenuItem,
            this.refreshToolStripMenuItem,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(60, 24);
            this.toolStripDropDownButton1.Text = "Menu";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(257, 26);
            this.toolStripMenuItem1.Text = "View Product Report";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(257, 26);
            this.toolStripMenuItem2.Text = "View Materials Report";
            // 
            // switchToProductTableToolStripMenuItem
            // 
            this.switchToProductTableToolStripMenuItem.Name = "switchToProductTableToolStripMenuItem";
            this.switchToProductTableToolStripMenuItem.Size = new System.Drawing.Size(257, 26);
            this.switchToProductTableToolStripMenuItem.Text = "Switch to Product Table";
            this.switchToProductTableToolStripMenuItem.Click += new System.EventHandler(this.switchToProductTableToolStripMenuItem_Click);
            // 
            // switchToMaterialsTableToolStripMenuItem
            // 
            this.switchToMaterialsTableToolStripMenuItem.Name = "switchToMaterialsTableToolStripMenuItem";
            this.switchToMaterialsTableToolStripMenuItem.Size = new System.Drawing.Size(257, 26);
            this.switchToMaterialsTableToolStripMenuItem.Text = "Switch to Materials Table";
            this.switchToMaterialsTableToolStripMenuItem.Click += new System.EventHandler(this.switchToMaterialsTableToolStripMenuItem_Click);
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(257, 26);
            this.refreshToolStripMenuItem.Text = "Refresh";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(257, 26);
            this.toolStripMenuItem3.Text = "Go Back";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(257, 26);
            this.toolStripMenuItem4.Text = "Exit";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // ProductManagerForm
            // 
            this.AcceptButton = this.btnFilter;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1193, 666);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.confirmChangesBtn);
            this.Controls.Add(this.rawMatsView);
            this.Controls.Add(this.itemsView);
            this.Controls.Add(this.removeItemBtn);
            this.Controls.Add(this.stsStripDisplayInfo);
            this.Controls.Add(this.quantityEquations);
            this.Controls.Add(this.cBoxQuality);
            this.Controls.Add(this.filterMenu);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.cBoxLocation);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.txtFilterByItem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addItemBtn);
            this.Controls.Add(this.filterLbl);
            this.Controls.Add(this.quantityLbl);
            this.Controls.Add(this.nameLbl);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.addItemLbl);
            this.Controls.Add(this.prodDataGridView);
            this.Controls.Add(this.Admin);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ProductManagerForm";
            this.Text = "Product Manager Form";
            this.Load += new System.EventHandler(this.ProductManagerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.prodDataGridView)).EndInit();
            this.stsStripDisplayInfo.ResumeLayout(false);
            this.stsStripDisplayInfo.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Admin;
        private System.Windows.Forms.DataGridView prodDataGridView;
        private System.Windows.Forms.Label addItemLbl;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.Label quantityLbl;
        private System.Windows.Forms.Label filterLbl;
        private System.Windows.Forms.Button addItemBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFilterByItem;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cBoxLocation;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ComboBox filterMenu;
        private System.Windows.Forms.ComboBox cBoxQuality;
        private System.Windows.Forms.ComboBox quantityEquations;
        private System.Windows.Forms.StatusStrip stsStripDisplayInfo;
        private System.Windows.Forms.ToolStripStatusLabel stsStripLabel;
        private System.Windows.Forms.Button removeItemBtn;
        private System.Windows.Forms.ListView itemsView;
        private System.Windows.Forms.ListView rawMatsView;
        private System.Windows.Forms.Button confirmChangesBtn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewProductReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewMaterialsReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem goBackToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem switchToProductTableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem switchToMaterialsTableToolStripMenuItem;
    }
}

