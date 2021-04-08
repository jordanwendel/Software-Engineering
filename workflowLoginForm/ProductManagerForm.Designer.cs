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
            this.Admin = new System.Windows.Forms.Label();
            this.Logout = new System.Windows.Forms.Button();
            this.addProduct = new System.Windows.Forms.Button();
            this.refreshBtn = new System.Windows.Forms.Button();
            this.prodDataGridView = new System.Windows.Forms.DataGridView();
            this.addItemLbl = new System.Windows.Forms.Label();
            this.nameMenu = new System.Windows.Forms.ComboBox();
            this.qualityMenu = new System.Windows.Forms.ComboBox();
            this.quantityTxt = new System.Windows.Forms.TextBox();
            this.locationMenu = new System.Windows.Forms.ComboBox();
            this.nameLbl = new System.Windows.Forms.Label();
            this.qualityLbl = new System.Windows.Forms.Label();
            this.quantityLbl = new System.Windows.Forms.Label();
            this.locationLbl = new System.Windows.Forms.Label();
            this.filterLbl = new System.Windows.Forms.Label();
            this.addItemBtn = new System.Windows.Forms.Button();
            this.viewProdBtn = new System.Windows.Forms.Button();
            this.viewMatBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFilterByItem = new System.Windows.Forms.TextBox();
            this.btnFilter = new System.Windows.Forms.Button();
            this.lstBoxProducts = new System.Windows.Forms.ListBox();
            this.radBtnName = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.radBtnQuality = new System.Windows.Forms.RadioButton();
            this.radBtnQuantity = new System.Windows.Forms.RadioButton();
            this.radBtnLocation = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.cBoxQuality = new System.Windows.Forms.ComboBox();
            this.txtTest = new System.Windows.Forms.TextBox();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cBoxLocation = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.prodDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // Admin
            // 
            this.Admin.Font = new System.Drawing.Font("Impact", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Admin.ForeColor = System.Drawing.Color.White;
            this.Admin.Location = new System.Drawing.Point(393, 0);
            this.Admin.Name = "Admin";
            this.Admin.Size = new System.Drawing.Size(515, 62);
            this.Admin.TabIndex = 2;
            this.Admin.Text = "Product Manager Page";
            this.Admin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Logout
            // 
            this.Logout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(57)))), ((int)(((byte)(52)))));
            this.Logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logout.Location = new System.Drawing.Point(77, 695);
            this.Logout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(131, 33);
            this.Logout.TabIndex = 5;
            this.Logout.Text = "LOG OUT";
            this.Logout.UseVisualStyleBackColor = false;
            this.Logout.Click += new System.EventHandler(this.Logout_Click);
            // 
            // addProduct
            // 
            this.addProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.addProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProduct.Location = new System.Drawing.Point(23, 247);
            this.addProduct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addProduct.Name = "addProduct";
            this.addProduct.Size = new System.Drawing.Size(251, 37);
            this.addProduct.TabIndex = 10;
            this.addProduct.Text = "ADD NEW ITEM";
            this.addProduct.UseVisualStyleBackColor = false;
            this.addProduct.Click += new System.EventHandler(this.addProduct_Click);
            // 
            // refreshBtn
            // 
            this.refreshBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.refreshBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(214)))), ((int)(((byte)(243)))));
            this.refreshBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refreshBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshBtn.Location = new System.Drawing.Point(1049, 679);
            this.refreshBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(129, 49);
            this.refreshBtn.TabIndex = 11;
            this.refreshBtn.Text = "REFRESH";
            this.refreshBtn.UseVisualStyleBackColor = false;
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // prodDataGridView
            // 
            this.prodDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.prodDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.prodDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.prodDataGridView.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.prodDataGridView.Location = new System.Drawing.Point(284, 78);
            this.prodDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.prodDataGridView.Name = "prodDataGridView";
            this.prodDataGridView.RowHeadersWidth = 51;
            this.prodDataGridView.Size = new System.Drawing.Size(895, 222);
            this.prodDataGridView.TabIndex = 12;
            // 
            // addItemLbl
            // 
            this.addItemLbl.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addItemLbl.ForeColor = System.Drawing.Color.White;
            this.addItemLbl.Location = new System.Drawing.Point(96, 25);
            this.addItemLbl.Name = "addItemLbl";
            this.addItemLbl.Size = new System.Drawing.Size(139, 37);
            this.addItemLbl.TabIndex = 19;
            this.addItemLbl.Text = "Add Item";
            // 
            // nameMenu
            // 
            this.nameMenu.FormattingEnabled = true;
            this.nameMenu.Location = new System.Drawing.Point(116, 78);
            this.nameMenu.Margin = new System.Windows.Forms.Padding(4);
            this.nameMenu.Name = "nameMenu";
            this.nameMenu.Size = new System.Drawing.Size(157, 24);
            this.nameMenu.TabIndex = 20;
            this.nameMenu.Text = "Click to expand...";
            // 
            // qualityMenu
            // 
            this.qualityMenu.FormattingEnabled = true;
            this.qualityMenu.Location = new System.Drawing.Point(116, 111);
            this.qualityMenu.Margin = new System.Windows.Forms.Padding(4);
            this.qualityMenu.Name = "qualityMenu";
            this.qualityMenu.Size = new System.Drawing.Size(157, 24);
            this.qualityMenu.TabIndex = 21;
            this.qualityMenu.Text = "Click to expand...";
            // 
            // quantityTxt
            // 
            this.quantityTxt.Location = new System.Drawing.Point(116, 144);
            this.quantityTxt.Margin = new System.Windows.Forms.Padding(4);
            this.quantityTxt.Name = "quantityTxt";
            this.quantityTxt.Size = new System.Drawing.Size(157, 22);
            this.quantityTxt.TabIndex = 22;
            this.quantityTxt.Text = "Enter Quantity";
            // 
            // locationMenu
            // 
            this.locationMenu.FormattingEnabled = true;
            this.locationMenu.Location = new System.Drawing.Point(116, 176);
            this.locationMenu.Margin = new System.Windows.Forms.Padding(4);
            this.locationMenu.Name = "locationMenu";
            this.locationMenu.Size = new System.Drawing.Size(157, 24);
            this.locationMenu.TabIndex = 23;
            this.locationMenu.Text = "Click to expand...";
            // 
            // nameLbl
            // 
            this.nameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLbl.ForeColor = System.Drawing.Color.White;
            this.nameLbl.Location = new System.Drawing.Point(48, 74);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(61, 28);
            this.nameLbl.TabIndex = 24;
            this.nameLbl.Text = "Item:";
            this.nameLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // qualityLbl
            // 
            this.qualityLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qualityLbl.ForeColor = System.Drawing.Color.White;
            this.qualityLbl.Location = new System.Drawing.Point(23, 111);
            this.qualityLbl.Name = "qualityLbl";
            this.qualityLbl.Size = new System.Drawing.Size(91, 20);
            this.qualityLbl.TabIndex = 25;
            this.qualityLbl.Text = "Quality: ";
            this.qualityLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // quantityLbl
            // 
            this.quantityLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityLbl.ForeColor = System.Drawing.Color.White;
            this.quantityLbl.Location = new System.Drawing.Point(15, 140);
            this.quantityLbl.Name = "quantityLbl";
            this.quantityLbl.Size = new System.Drawing.Size(103, 28);
            this.quantityLbl.TabIndex = 26;
            this.quantityLbl.Text = "Quantity:";
            this.quantityLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // locationLbl
            // 
            this.locationLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locationLbl.ForeColor = System.Drawing.Color.White;
            this.locationLbl.Location = new System.Drawing.Point(13, 176);
            this.locationLbl.Name = "locationLbl";
            this.locationLbl.Size = new System.Drawing.Size(104, 28);
            this.locationLbl.TabIndex = 27;
            this.locationLbl.Text = "Location:";
            this.locationLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // filterLbl
            // 
            this.filterLbl.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filterLbl.ForeColor = System.Drawing.Color.White;
            this.filterLbl.Location = new System.Drawing.Point(37, 308);
            this.filterLbl.Name = "filterLbl";
            this.filterLbl.Size = new System.Drawing.Size(223, 44);
            this.filterLbl.TabIndex = 28;
            this.filterLbl.Text = "Filter Items";
            this.filterLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // addItemBtn
            // 
            this.addItemBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(248)))), ((int)(((byte)(1)))));
            this.addItemBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addItemBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addItemBtn.Location = new System.Drawing.Point(188, 208);
            this.addItemBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addItemBtn.Name = "addItemBtn";
            this.addItemBtn.Size = new System.Drawing.Size(88, 34);
            this.addItemBtn.TabIndex = 29;
            this.addItemBtn.Text = "ADD ";
            this.addItemBtn.UseVisualStyleBackColor = false;
            // 
            // viewProdBtn
            // 
            this.viewProdBtn.Location = new System.Drawing.Point(345, 679);
            this.viewProdBtn.Margin = new System.Windows.Forms.Padding(4);
            this.viewProdBtn.Name = "viewProdBtn";
            this.viewProdBtn.Size = new System.Drawing.Size(184, 48);
            this.viewProdBtn.TabIndex = 30;
            this.viewProdBtn.Text = "View Product Data";
            this.viewProdBtn.UseVisualStyleBackColor = true;
            this.viewProdBtn.Click += new System.EventHandler(this.viewProdBtn_Click);
            // 
            // viewMatBtn
            // 
            this.viewMatBtn.Location = new System.Drawing.Point(709, 679);
            this.viewMatBtn.Margin = new System.Windows.Forms.Padding(4);
            this.viewMatBtn.Name = "viewMatBtn";
            this.viewMatBtn.Size = new System.Drawing.Size(184, 48);
            this.viewMatBtn.TabIndex = 31;
            this.viewMatBtn.Text = "View Raw Materials";
            this.viewMatBtn.UseVisualStyleBackColor = true;
            this.viewMatBtn.Click += new System.EventHandler(this.viewMatBtn_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(10, 462);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 28);
            this.label1.TabIndex = 32;
            this.label1.Text = "Item:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtFilterByItem
            // 
            this.txtFilterByItem.Location = new System.Drawing.Point(116, 468);
            this.txtFilterByItem.Name = "txtFilterByItem";
            this.txtFilterByItem.Size = new System.Drawing.Size(163, 22);
            this.txtFilterByItem.TabIndex = 33;
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(19, 642);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(75, 23);
            this.btnFilter.TabIndex = 34;
            this.btnFilter.Text = "Filter";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // lstBoxProducts
            // 
            this.lstBoxProducts.FormattingEnabled = true;
            this.lstBoxProducts.ItemHeight = 16;
            this.lstBoxProducts.Location = new System.Drawing.Point(284, 323);
            this.lstBoxProducts.Name = "lstBoxProducts";
            this.lstBoxProducts.Size = new System.Drawing.Size(894, 324);
            this.lstBoxProducts.TabIndex = 35;
            // 
            // radBtnName
            // 
            this.radBtnName.AutoSize = true;
            this.radBtnName.Location = new System.Drawing.Point(17, 396);
            this.radBtnName.Name = "radBtnName";
            this.radBtnName.Size = new System.Drawing.Size(66, 21);
            this.radBtnName.TabIndex = 36;
            this.radBtnName.TabStop = true;
            this.radBtnName.Text = "Name";
            this.radBtnName.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 355);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 17);
            this.label2.TabIndex = 37;
            this.label2.Text = "Select one to filter by";
            // 
            // radBtnQuality
            // 
            this.radBtnQuality.AutoSize = true;
            this.radBtnQuality.Location = new System.Drawing.Point(116, 396);
            this.radBtnQuality.Name = "radBtnQuality";
            this.radBtnQuality.Size = new System.Drawing.Size(73, 21);
            this.radBtnQuality.TabIndex = 38;
            this.radBtnQuality.TabStop = true;
            this.radBtnQuality.Text = "Quality";
            this.radBtnQuality.UseVisualStyleBackColor = true;
            this.radBtnQuality.CheckedChanged += new System.EventHandler(this.radBtnQuality_CheckedChanged);
            // 
            // radBtnQuantity
            // 
            this.radBtnQuantity.AutoSize = true;
            this.radBtnQuantity.Location = new System.Drawing.Point(17, 423);
            this.radBtnQuantity.Name = "radBtnQuantity";
            this.radBtnQuantity.Size = new System.Drawing.Size(82, 21);
            this.radBtnQuantity.TabIndex = 39;
            this.radBtnQuantity.TabStop = true;
            this.radBtnQuantity.Text = "Quantity";
            this.radBtnQuantity.UseVisualStyleBackColor = true;
            // 
            // radBtnLocation
            // 
            this.radBtnLocation.AutoSize = true;
            this.radBtnLocation.Location = new System.Drawing.Point(116, 423);
            this.radBtnLocation.Name = "radBtnLocation";
            this.radBtnLocation.Size = new System.Drawing.Size(83, 21);
            this.radBtnLocation.TabIndex = 40;
            this.radBtnLocation.TabStop = true;
            this.radBtnLocation.Text = "Location";
            this.radBtnLocation.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(-21, 490);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 28);
            this.label3.TabIndex = 41;
            this.label3.Text = "Quality:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cBoxQuality
            // 
            this.cBoxQuality.FormattingEnabled = true;
            this.cBoxQuality.Items.AddRange(new object[] {
            "Good",
            "Satisfactory"});
            this.cBoxQuality.Location = new System.Drawing.Point(116, 496);
            this.cBoxQuality.Name = "cBoxQuality";
            this.cBoxQuality.Size = new System.Drawing.Size(163, 24);
            this.cBoxQuality.TabIndex = 42;
            // 
            // txtTest
            // 
            this.txtTest.Location = new System.Drawing.Point(178, 653);
            this.txtTest.Name = "txtTest";
            this.txtTest.Size = new System.Drawing.Size(141, 22);
            this.txtTest.TabIndex = 43;
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(116, 526);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(163, 22);
            this.txtNum.TabIndex = 44;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(-11, 520);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 28);
            this.label4.TabIndex = 45;
            this.label4.Text = "Quanity:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(-6, 551);
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
            "Sales"});
            this.cBoxLocation.Location = new System.Drawing.Point(116, 553);
            this.cBoxLocation.Name = "cBoxLocation";
            this.cBoxLocation.Size = new System.Drawing.Size(163, 24);
            this.cBoxLocation.TabIndex = 47;
            // 
            // ProductManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1193, 742);
            this.Controls.Add(this.cBoxLocation);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.txtTest);
            this.Controls.Add(this.cBoxQuality);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.radBtnLocation);
            this.Controls.Add(this.radBtnQuantity);
            this.Controls.Add(this.radBtnQuality);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.radBtnName);
            this.Controls.Add(this.lstBoxProducts);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.txtFilterByItem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.viewMatBtn);
            this.Controls.Add(this.viewProdBtn);
            this.Controls.Add(this.addItemBtn);
            this.Controls.Add(this.filterLbl);
            this.Controls.Add(this.locationLbl);
            this.Controls.Add(this.quantityLbl);
            this.Controls.Add(this.qualityLbl);
            this.Controls.Add(this.nameLbl);
            this.Controls.Add(this.locationMenu);
            this.Controls.Add(this.quantityTxt);
            this.Controls.Add(this.qualityMenu);
            this.Controls.Add(this.nameMenu);
            this.Controls.Add(this.addItemLbl);
            this.Controls.Add(this.prodDataGridView);
            this.Controls.Add(this.refreshBtn);
            this.Controls.Add(this.addProduct);
            this.Controls.Add(this.Logout);
            this.Controls.Add(this.Admin);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ProductManagerForm";
            this.Text = "Product Manager Form";
            this.Load += new System.EventHandler(this.ProductManagerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.prodDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Admin;
        private System.Windows.Forms.Button Logout;
        private System.Windows.Forms.Button addProduct;
        private System.Windows.Forms.Button refreshBtn;
        private System.Windows.Forms.DataGridView prodDataGridView;
        private System.Windows.Forms.Label addItemLbl;
        private System.Windows.Forms.ComboBox nameMenu;
        private System.Windows.Forms.ComboBox qualityMenu;
        private System.Windows.Forms.TextBox quantityTxt;
        private System.Windows.Forms.ComboBox locationMenu;
        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.Label qualityLbl;
        private System.Windows.Forms.Label quantityLbl;
        private System.Windows.Forms.Label locationLbl;
        private System.Windows.Forms.Label filterLbl;
        private System.Windows.Forms.Button addItemBtn;
        private System.Windows.Forms.Button viewProdBtn;
        private System.Windows.Forms.Button viewMatBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFilterByItem;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.ListBox lstBoxProducts;
        private System.Windows.Forms.RadioButton radBtnName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radBtnQuality;
        private System.Windows.Forms.RadioButton radBtnQuantity;
        private System.Windows.Forms.RadioButton radBtnLocation;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cBoxQuality;
        private System.Windows.Forms.TextBox txtTest;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cBoxLocation;
    }
}

