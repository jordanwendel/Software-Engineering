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
            this.Admin = new System.Windows.Forms.Label();
            this.Logout = new System.Windows.Forms.Button();
            this.filterLbl = new System.Windows.Forms.Label();
            this.locationLbl = new System.Windows.Forms.Label();
            this.nameLbl = new System.Windows.Forms.Label();
            this.locationMenu = new System.Windows.Forms.ComboBox();
            this.addItemLbl = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.prodDataGridView = new System.Windows.Forms.DataGridView();
            this.refreshBtn = new System.Windows.Forms.Button();
            this.addItemBtn = new System.Windows.Forms.Button();
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.prodDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // Admin
            // 
            this.Admin.Font = new System.Drawing.Font("Impact", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Admin.ForeColor = System.Drawing.Color.White;
            this.Admin.Location = new System.Drawing.Point(550, 17);
            this.Admin.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Admin.Name = "Admin";
            this.Admin.Size = new System.Drawing.Size(856, 97);
            this.Admin.TabIndex = 2;
            this.Admin.Text = "Delivery Manager Page";
            this.Admin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Admin.Click += new System.EventHandler(this.Admin_Click);
            // 
            // Logout
            // 
            this.Logout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Logout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(36)))), ((int)(((byte)(31)))));
            this.Logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logout.Location = new System.Drawing.Point(56, 1259);
            this.Logout.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(190, 56);
            this.Logout.TabIndex = 4;
            this.Logout.Text = "LOG OUT";
            this.Logout.UseVisualStyleBackColor = false;
            this.Logout.Click += new System.EventHandler(this.Logout_Click);
            // 
            // filterLbl
            // 
            this.filterLbl.AutoSize = true;
            this.filterLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filterLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.filterLbl.Location = new System.Drawing.Point(168, 497);
            this.filterLbl.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.filterLbl.Name = "filterLbl";
            this.filterLbl.Size = new System.Drawing.Size(222, 44);
            this.filterLbl.TabIndex = 45;
            this.filterLbl.Text = "Filter Items";
            // 
            // locationLbl
            // 
            this.locationLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locationLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.locationLbl.Location = new System.Drawing.Point(4, 303);
            this.locationLbl.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.locationLbl.Name = "locationLbl";
            this.locationLbl.Size = new System.Drawing.Size(208, 53);
            this.locationLbl.TabIndex = 44;
            this.locationLbl.Text = "Location:";
            this.locationLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // nameLbl
            // 
            this.nameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.nameLbl.Location = new System.Drawing.Point(72, 224);
            this.nameLbl.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(122, 53);
            this.nameLbl.TabIndex = 41;
            this.nameLbl.Text = "Item:";
            this.nameLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // locationMenu
            // 
            this.locationMenu.FormattingEnabled = true;
            this.locationMenu.Items.AddRange(new object[] {
            "Manufacturing",
            "Sales"});
            this.locationMenu.Location = new System.Drawing.Point(232, 303);
            this.locationMenu.Margin = new System.Windows.Forms.Padding(8);
            this.locationMenu.Name = "locationMenu";
            this.locationMenu.Size = new System.Drawing.Size(310, 33);
            this.locationMenu.TabIndex = 40;
            this.locationMenu.Text = "Click to expand...";
            // 
            // addItemLbl
            // 
            this.addItemLbl.AutoSize = true;
            this.addItemLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addItemLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addItemLbl.Location = new System.Drawing.Point(146, 128);
            this.addItemLbl.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.addItemLbl.Name = "addItemLbl";
            this.addItemLbl.Size = new System.Drawing.Size(253, 44);
            this.addItemLbl.TabIndex = 36;
            this.addItemLbl.Text = "Edit Location";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(32, 570);
            this.checkedListBox1.Margin = new System.Windows.Forms.Padding(8);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(514, 452);
            this.checkedListBox1.TabIndex = 35;
            // 
            // prodDataGridView
            // 
            this.prodDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.prodDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.prodDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.prodDataGridView.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.prodDataGridView.Location = new System.Drawing.Point(596, 128);
            this.prodDataGridView.Margin = new System.Windows.Forms.Padding(8);
            this.prodDataGridView.Name = "prodDataGridView";
            this.prodDataGridView.RowHeadersWidth = 51;
            this.prodDataGridView.Size = new System.Drawing.Size(1176, 1069);
            this.prodDataGridView.TabIndex = 34;
            this.prodDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.prodDataGridView_CellContentClick);
            // 
            // refreshBtn
            // 
            this.refreshBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.refreshBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(214)))), ((int)(((byte)(243)))));
            this.refreshBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refreshBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshBtn.Location = new System.Drawing.Point(1570, 1231);
            this.refreshBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(202, 81);
            this.refreshBtn.TabIndex = 47;
            this.refreshBtn.Text = "REFRESH";
            this.refreshBtn.UseVisualStyleBackColor = false;
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // addItemBtn
            // 
            this.addItemBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(220)))), ((int)(((byte)(109)))));
            this.addItemBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addItemBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addItemBtn.Location = new System.Drawing.Point(232, 377);
            this.addItemBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.addItemBtn.Name = "addItemBtn";
            this.addItemBtn.Size = new System.Drawing.Size(132, 53);
            this.addItemBtn.TabIndex = 48;
            this.addItemBtn.Text = "Edit";
            this.addItemBtn.UseVisualStyleBackColor = false;
            this.addItemBtn.Click += new System.EventHandler(this.addItemBtn_Click);
            // 
            // txtItemName
            // 
            this.txtItemName.Location = new System.Drawing.Point(232, 238);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(314, 31);
            this.txtItemName.TabIndex = 49;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(214)))), ((int)(((byte)(243)))));
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Location = new System.Drawing.Point(394, 377);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(152, 53);
            this.btnRefresh.TabIndex = 50;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // DeliveryManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1784, 1333);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.txtItemName);
            this.Controls.Add(this.addItemBtn);
            this.Controls.Add(this.refreshBtn);
            this.Controls.Add(this.filterLbl);
            this.Controls.Add(this.locationLbl);
            this.Controls.Add(this.nameLbl);
            this.Controls.Add(this.locationMenu);
            this.Controls.Add(this.addItemLbl);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.prodDataGridView);
            this.Controls.Add(this.Logout);
            this.Controls.Add(this.Admin);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "DeliveryManagerForm";
            this.Text = "Delivery Manager Form";
            this.Load += new System.EventHandler(this.DeliveryManagerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.prodDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Admin;
        private System.Windows.Forms.Button Logout;
        private System.Windows.Forms.Label filterLbl;
        private System.Windows.Forms.Label locationLbl;
        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.ComboBox locationMenu;
        private System.Windows.Forms.Label addItemLbl;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.DataGridView prodDataGridView;
        private System.Windows.Forms.Button refreshBtn;
        private System.Windows.Forms.Button addItemBtn;
        private System.Windows.Forms.TextBox txtItemName;
        private System.Windows.Forms.Button btnRefresh;
    }
}

