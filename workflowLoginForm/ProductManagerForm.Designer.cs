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
            this.refreshBtn = new System.Windows.Forms.Button();
            this.prodDataGridView = new System.Windows.Forms.DataGridView();
            this.addItemLbl = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.nameLbl = new System.Windows.Forms.Label();
            this.quantityLbl = new System.Windows.Forms.Label();
            this.filterLbl = new System.Windows.Forms.Label();
            this.addItemBtn = new System.Windows.Forms.Button();
            this.viewProdBtn = new System.Windows.Forms.Button();
            this.viewMatBtn = new System.Windows.Forms.Button();
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
            this.viewDbLbl = new System.Windows.Forms.Label();
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
            this.Logout.Location = new System.Drawing.Point(1048, 14);
            this.Logout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(131, 33);
            this.Logout.TabIndex = 5;
            this.Logout.Text = "LOG OUT";
            this.Logout.UseVisualStyleBackColor = false;
            this.Logout.Click += new System.EventHandler(this.Logout_Click);
            // 
            // refreshBtn
            // 
            this.refreshBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.refreshBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(214)))), ((int)(((byte)(243)))));
            this.refreshBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refreshBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshBtn.Location = new System.Drawing.Point(27, 586);
            this.refreshBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(129, 47);
            this.refreshBtn.TabIndex = 11;
            this.refreshBtn.Text = "REFRESH";
            this.refreshBtn.UseVisualStyleBackColor = false;
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // prodDataGridView
            // 
            this.prodDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.prodDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.prodDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.prodDataGridView.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.prodDataGridView.Location = new System.Drawing.Point(305, 78);
            this.prodDataGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.prodDataGridView.Name = "prodDataGridView";
            this.prodDataGridView.RowHeadersWidth = 51;
            this.prodDataGridView.Size = new System.Drawing.Size(873, 555);
            this.prodDataGridView.TabIndex = 12;
            // 
            // addItemLbl
            // 
            this.addItemLbl.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addItemLbl.ForeColor = System.Drawing.Color.White;
            this.addItemLbl.Location = new System.Drawing.Point(83, 38);
            this.addItemLbl.Name = "addItemLbl";
            this.addItemLbl.Size = new System.Drawing.Size(181, 37);
            this.addItemLbl.TabIndex = 19;
            this.addItemLbl.Text = "Add Product";
            this.addItemLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(124, 109);
            this.txtQuantity.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(172, 22);
            this.txtQuantity.TabIndex = 22;
            this.txtQuantity.Text = "Enter Quantity";
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
            // quantityLbl
            // 
            this.quantityLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityLbl.ForeColor = System.Drawing.Color.White;
            this.quantityLbl.Location = new System.Drawing.Point(14, 104);
            this.quantityLbl.Name = "quantityLbl";
            this.quantityLbl.Size = new System.Drawing.Size(103, 28);
            this.quantityLbl.TabIndex = 26;
            this.quantityLbl.Text = "Quantity:";
            this.quantityLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // filterLbl
            // 
            this.filterLbl.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filterLbl.ForeColor = System.Drawing.Color.White;
            this.filterLbl.Location = new System.Drawing.Point(61, 386);
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
            this.addItemBtn.Location = new System.Drawing.Point(124, 147);
            this.addItemBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addItemBtn.Name = "addItemBtn";
            this.addItemBtn.Size = new System.Drawing.Size(88, 34);
            this.addItemBtn.TabIndex = 29;
            this.addItemBtn.Text = "ADD ";
            this.addItemBtn.UseVisualStyleBackColor = false;
            this.addItemBtn.Click += new System.EventHandler(this.addItemBtn_Click);
            // 
            // viewProdBtn
            // 
            this.viewProdBtn.Location = new System.Drawing.Point(9, 311);
            this.viewProdBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.viewProdBtn.Name = "viewProdBtn";
            this.viewProdBtn.Size = new System.Drawing.Size(144, 48);
            this.viewProdBtn.TabIndex = 30;
            this.viewProdBtn.Text = "View Products";
            this.viewProdBtn.UseVisualStyleBackColor = true;
            this.viewProdBtn.Click += new System.EventHandler(this.viewProdBtn_Click);
            // 
            // viewMatBtn
            // 
            this.viewMatBtn.Location = new System.Drawing.Point(154, 312);
            this.viewMatBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.viewMatBtn.Name = "viewMatBtn";
            this.viewMatBtn.Size = new System.Drawing.Size(144, 48);
            this.viewMatBtn.TabIndex = 31;
            this.viewMatBtn.Text = "View Raw Materials";
            this.viewMatBtn.UseVisualStyleBackColor = true;
            this.viewMatBtn.Click += new System.EventHandler(this.viewMatBtn_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(8, 464);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 28);
            this.label1.TabIndex = 32;
            this.label1.Text = "Item Name:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtFilterByItem
            // 
            this.txtFilterByItem.Location = new System.Drawing.Point(135, 468);
            this.txtFilterByItem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFilterByItem.Name = "txtFilterByItem";
            this.txtFilterByItem.Size = new System.Drawing.Size(163, 22);
            this.txtFilterByItem.TabIndex = 33;
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(161, 586);
            this.btnFilter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(137, 48);
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
            this.label2.Location = new System.Drawing.Point(33, 433);
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
            this.label3.Location = new System.Drawing.Point(25, 496);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 28);
            this.label3.TabIndex = 41;
            this.label3.Text = "Quality:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(271, 526);
            this.txtNum.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(27, 22);
            this.txtNum.TabIndex = 44;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(28, 524);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 28);
            this.label4.TabIndex = 45;
            this.label4.Text = "Quantity:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(28, 553);
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
            this.cBoxLocation.Location = new System.Drawing.Point(135, 553);
            this.cBoxLocation.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cBoxLocation.Name = "cBoxLocation";
            this.cBoxLocation.Size = new System.Drawing.Size(163, 24);
            this.cBoxLocation.TabIndex = 47;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(124, 79);
            this.txtName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(172, 22);
            this.txtName.TabIndex = 48;
            this.txtName.Text = "Enter Name";
            // 
            // filterMenu
            // 
            this.filterMenu.FormattingEnabled = true;
            this.filterMenu.Items.AddRange(new object[] {
            "Name",
            "Quality",
            "Quantity",
            "Location"});
            this.filterMenu.Location = new System.Drawing.Point(133, 434);
            this.filterMenu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            "Defective"});
            this.cBoxQuality.Location = new System.Drawing.Point(135, 496);
            this.cBoxQuality.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.quantityEquations.Location = new System.Drawing.Point(135, 524);
            this.quantityEquations.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.quantityEquations.Name = "quantityEquations";
            this.quantityEquations.Size = new System.Drawing.Size(128, 24);
            this.quantityEquations.TabIndex = 51;
            // 
            // viewDbLbl
            // 
            this.viewDbLbl.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewDbLbl.ForeColor = System.Drawing.Color.White;
            this.viewDbLbl.Location = new System.Drawing.Point(45, 271);
            this.viewDbLbl.Name = "viewDbLbl";
            this.viewDbLbl.Size = new System.Drawing.Size(237, 37);
            this.viewDbLbl.TabIndex = 52;
            this.viewDbLbl.Text = "Switch Data";
            this.viewDbLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ProductManagerForm
            // 
            this.AcceptButton = this.btnFilter;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1193, 657);
            this.Controls.Add(this.viewDbLbl);
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
            this.Controls.Add(this.viewMatBtn);
            this.Controls.Add(this.viewProdBtn);
            this.Controls.Add(this.addItemBtn);
            this.Controls.Add(this.filterLbl);
            this.Controls.Add(this.quantityLbl);
            this.Controls.Add(this.nameLbl);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.addItemLbl);
            this.Controls.Add(this.prodDataGridView);
            this.Controls.Add(this.refreshBtn);
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
        private System.Windows.Forms.Button refreshBtn;
        private System.Windows.Forms.DataGridView prodDataGridView;
        private System.Windows.Forms.Label addItemLbl;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.Label quantityLbl;
        private System.Windows.Forms.Label filterLbl;
        private System.Windows.Forms.Button addItemBtn;
        private System.Windows.Forms.Button viewProdBtn;
        private System.Windows.Forms.Button viewMatBtn;
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
        private System.Windows.Forms.Label viewDbLbl;
    }
}

