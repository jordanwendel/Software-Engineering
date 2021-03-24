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
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.prodDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // Admin
            // 
            this.Admin.Font = new System.Drawing.Font("Tahoma", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Admin.Location = new System.Drawing.Point(317, 12);
            this.Admin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Admin.Name = "Admin";
            this.Admin.Size = new System.Drawing.Size(571, 62);
            this.Admin.TabIndex = 2;
            this.Admin.Text = "PRODUCT MANAGER PAGE";
            this.Admin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Logout
            // 
            this.Logout.Location = new System.Drawing.Point(15, 673);
            this.Logout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(103, 47);
            this.Logout.TabIndex = 5;
            this.Logout.Text = "Logout";
            this.Logout.UseVisualStyleBackColor = true;
            this.Logout.Click += new System.EventHandler(this.Logout_Click);
            // 
            // addProduct
            // 
            this.addProduct.Location = new System.Drawing.Point(140, 209);
            this.addProduct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addProduct.Name = "addProduct";
            this.addProduct.Size = new System.Drawing.Size(139, 34);
            this.addProduct.TabIndex = 10;
            this.addProduct.Text = "Add New";
            this.addProduct.UseVisualStyleBackColor = true;
            this.addProduct.Click += new System.EventHandler(this.addProduct_Click);
            // 
            // refreshBtn
            // 
            this.refreshBtn.Location = new System.Drawing.Point(1039, 671);
            this.refreshBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(129, 49);
            this.refreshBtn.TabIndex = 11;
            this.refreshBtn.Text = "Refresh Inventory";
            this.refreshBtn.UseVisualStyleBackColor = true;
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
            this.prodDataGridView.Location = new System.Drawing.Point(283, 78);
            this.prodDataGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.prodDataGridView.Name = "prodDataGridView";
            this.prodDataGridView.RowHeadersWidth = 51;
            this.prodDataGridView.Size = new System.Drawing.Size(887, 582);
            this.prodDataGridView.TabIndex = 12;
            this.prodDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.prodDataGridView_CellContentClick);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(16, 378);
            this.checkedListBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(228, 276);
            this.checkedListBox1.TabIndex = 18;
            // 
            // addItemLbl
            // 
            this.addItemLbl.AutoSize = true;
            this.addItemLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addItemLbl.Location = new System.Drawing.Point(76, 36);
            this.addItemLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.addItemLbl.Name = "addItemLbl";
            this.addItemLbl.Size = new System.Drawing.Size(116, 29);
            this.addItemLbl.TabIndex = 19;
            this.addItemLbl.Text = "Add Item";
            // 
            // nameMenu
            // 
            this.nameMenu.FormattingEnabled = true;
            this.nameMenu.Location = new System.Drawing.Point(116, 78);
            this.nameMenu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nameMenu.Name = "nameMenu";
            this.nameMenu.Size = new System.Drawing.Size(157, 24);
            this.nameMenu.TabIndex = 20;
            this.nameMenu.Text = "Click to expand...";
            // 
            // qualityMenu
            // 
            this.qualityMenu.FormattingEnabled = true;
            this.qualityMenu.Location = new System.Drawing.Point(116, 111);
            this.qualityMenu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.qualityMenu.Name = "qualityMenu";
            this.qualityMenu.Size = new System.Drawing.Size(157, 24);
            this.qualityMenu.TabIndex = 21;
            this.qualityMenu.Text = "Click to expand...";
            // 
            // quantityTxt
            // 
            this.quantityTxt.Location = new System.Drawing.Point(116, 144);
            this.quantityTxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.quantityTxt.Name = "quantityTxt";
            this.quantityTxt.Size = new System.Drawing.Size(157, 22);
            this.quantityTxt.TabIndex = 22;
            this.quantityTxt.Text = "Enter Quantity";
            // 
            // locationMenu
            // 
            this.locationMenu.FormattingEnabled = true;
            this.locationMenu.Location = new System.Drawing.Point(116, 176);
            this.locationMenu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.locationMenu.Name = "locationMenu";
            this.locationMenu.Size = new System.Drawing.Size(157, 24);
            this.locationMenu.TabIndex = 23;
            this.locationMenu.Text = "Click to expand...";
            // 
            // nameLbl
            // 
            this.nameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLbl.Location = new System.Drawing.Point(16, 78);
            this.nameLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(61, 28);
            this.nameLbl.TabIndex = 24;
            this.nameLbl.Text = "Item";
            this.nameLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // qualityLbl
            // 
            this.qualityLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qualityLbl.Location = new System.Drawing.Point(11, 111);
            this.qualityLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.qualityLbl.Name = "qualityLbl";
            this.qualityLbl.Size = new System.Drawing.Size(85, 28);
            this.qualityLbl.TabIndex = 25;
            this.qualityLbl.Text = "Quality";
            this.qualityLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // quantityLbl
            // 
            this.quantityLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityLbl.Location = new System.Drawing.Point(5, 144);
            this.quantityLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.quantityLbl.Name = "quantityLbl";
            this.quantityLbl.Size = new System.Drawing.Size(103, 28);
            this.quantityLbl.TabIndex = 26;
            this.quantityLbl.Text = "Quantity";
            this.quantityLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // locationLbl
            // 
            this.locationLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locationLbl.Location = new System.Drawing.Point(5, 176);
            this.locationLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.locationLbl.Name = "locationLbl";
            this.locationLbl.Size = new System.Drawing.Size(104, 28);
            this.locationLbl.TabIndex = 27;
            this.locationLbl.Text = "Location";
            this.locationLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // filterLbl
            // 
            this.filterLbl.AutoSize = true;
            this.filterLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filterLbl.Location = new System.Drawing.Point(88, 345);
            this.filterLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.filterLbl.Name = "filterLbl";
            this.filterLbl.Size = new System.Drawing.Size(74, 29);
            this.filterLbl.TabIndex = 28;
            this.filterLbl.Text = "Filter";
            // 
            // addItemBtn
            // 
            this.addItemBtn.Location = new System.Drawing.Point(9, 209);
            this.addItemBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addItemBtn.Name = "addItemBtn";
            this.addItemBtn.Size = new System.Drawing.Size(124, 34);
            this.addItemBtn.TabIndex = 29;
            this.addItemBtn.Text = "Add Item";
            this.addItemBtn.UseVisualStyleBackColor = true;
            // 
            // ProductManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 731);
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
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.prodDataGridView);
            this.Controls.Add(this.refreshBtn);
            this.Controls.Add(this.addProduct);
            this.Controls.Add(this.Logout);
            this.Controls.Add(this.Admin);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ProductManagerForm";
            this.Text = "ProductManager";
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
        private System.Windows.Forms.CheckedListBox checkedListBox1;
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
    }
}

