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
            this.quantityLbl = new System.Windows.Forms.Label();
            this.qualityLbl = new System.Windows.Forms.Label();
            this.nameLbl = new System.Windows.Forms.Label();
            this.locationMenu = new System.Windows.Forms.ComboBox();
            this.quantityTxt = new System.Windows.Forms.TextBox();
            this.qualityMenu = new System.Windows.Forms.ComboBox();
            this.nameMenu = new System.Windows.Forms.ComboBox();
            this.addItemLbl = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.prodDataGridView = new System.Windows.Forms.DataGridView();
            this.refreshBtn = new System.Windows.Forms.Button();
            this.addItemBtn = new System.Windows.Forms.Button();
            this.addNewMat_Btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.prodDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // Admin
            // 
            this.Admin.Font = new System.Drawing.Font("Impact", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Admin.ForeColor = System.Drawing.Color.White;
            this.Admin.Location = new System.Drawing.Point(275, 9);
            this.Admin.Name = "Admin";
            this.Admin.Size = new System.Drawing.Size(428, 50);
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
            this.Logout.Location = new System.Drawing.Point(28, 655);
            this.Logout.Margin = new System.Windows.Forms.Padding(2);
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(95, 29);
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
            this.filterLbl.Location = new System.Drawing.Point(84, 351);
            this.filterLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.filterLbl.Name = "filterLbl";
            this.filterLbl.Size = new System.Drawing.Size(112, 24);
            this.filterLbl.TabIndex = 45;
            this.filterLbl.Text = "Filter Items";
            // 
            // locationLbl
            // 
            this.locationLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locationLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.locationLbl.Location = new System.Drawing.Point(19, 161);
            this.locationLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.locationLbl.Name = "locationLbl";
            this.locationLbl.Size = new System.Drawing.Size(104, 28);
            this.locationLbl.TabIndex = 44;
            this.locationLbl.Text = "Location:";
            this.locationLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // quantityLbl
            // 
            this.quantityLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.quantityLbl.Location = new System.Drawing.Point(20, 128);
            this.quantityLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.quantityLbl.Name = "quantityLbl";
            this.quantityLbl.Size = new System.Drawing.Size(103, 28);
            this.quantityLbl.TabIndex = 43;
            this.quantityLbl.Text = "Quantity:";
            this.quantityLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // qualityLbl
            // 
            this.qualityLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qualityLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.qualityLbl.Location = new System.Drawing.Point(38, 100);
            this.qualityLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.qualityLbl.Name = "qualityLbl";
            this.qualityLbl.Size = new System.Drawing.Size(85, 28);
            this.qualityLbl.TabIndex = 42;
            this.qualityLbl.Text = "Quality:";
            this.qualityLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // nameLbl
            // 
            this.nameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.nameLbl.Location = new System.Drawing.Point(62, 67);
            this.nameLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(61, 28);
            this.nameLbl.TabIndex = 41;
            this.nameLbl.Text = "Item:";
            this.nameLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // locationMenu
            // 
            this.locationMenu.FormattingEnabled = true;
            this.locationMenu.Location = new System.Drawing.Point(124, 165);
            this.locationMenu.Margin = new System.Windows.Forms.Padding(4);
            this.locationMenu.Name = "locationMenu";
            this.locationMenu.Size = new System.Drawing.Size(157, 21);
            this.locationMenu.TabIndex = 40;
            this.locationMenu.Text = "Click to expand...";
            // 
            // quantityTxt
            // 
            this.quantityTxt.Location = new System.Drawing.Point(124, 133);
            this.quantityTxt.Margin = new System.Windows.Forms.Padding(4);
            this.quantityTxt.Name = "quantityTxt";
            this.quantityTxt.Size = new System.Drawing.Size(157, 20);
            this.quantityTxt.TabIndex = 39;
            this.quantityTxt.Text = "Enter Quantity";
            // 
            // qualityMenu
            // 
            this.qualityMenu.FormattingEnabled = true;
            this.qualityMenu.Location = new System.Drawing.Point(124, 100);
            this.qualityMenu.Margin = new System.Windows.Forms.Padding(4);
            this.qualityMenu.Name = "qualityMenu";
            this.qualityMenu.Size = new System.Drawing.Size(157, 21);
            this.qualityMenu.TabIndex = 38;
            this.qualityMenu.Text = "Click to expand...";
            // 
            // nameMenu
            // 
            this.nameMenu.FormattingEnabled = true;
            this.nameMenu.Location = new System.Drawing.Point(124, 67);
            this.nameMenu.Margin = new System.Windows.Forms.Padding(4);
            this.nameMenu.Name = "nameMenu";
            this.nameMenu.Size = new System.Drawing.Size(157, 21);
            this.nameMenu.TabIndex = 37;
            this.nameMenu.Text = "Click to expand...";
            // 
            // addItemLbl
            // 
            this.addItemLbl.AutoSize = true;
            this.addItemLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addItemLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addItemLbl.Location = new System.Drawing.Point(103, 30);
            this.addItemLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.addItemLbl.Name = "addItemLbl";
            this.addItemLbl.Size = new System.Drawing.Size(93, 24);
            this.addItemLbl.TabIndex = 36;
            this.addItemLbl.Text = "Add Item";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(22, 379);
            this.checkedListBox1.Margin = new System.Windows.Forms.Padding(4);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(259, 244);
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
            this.prodDataGridView.Location = new System.Drawing.Point(298, 67);
            this.prodDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.prodDataGridView.Name = "prodDataGridView";
            this.prodDataGridView.RowHeadersWidth = 51;
            this.prodDataGridView.Size = new System.Drawing.Size(588, 556);
            this.prodDataGridView.TabIndex = 34;
            this.prodDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.prodDataGridView_CellContentClick);
            // 
            // refreshBtn
            // 
            this.refreshBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.refreshBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(214)))), ((int)(((byte)(243)))));
            this.refreshBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refreshBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshBtn.Location = new System.Drawing.Point(785, 640);
            this.refreshBtn.Margin = new System.Windows.Forms.Padding(2);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(101, 42);
            this.refreshBtn.TabIndex = 47;
            this.refreshBtn.Text = "REFRESH";
            this.refreshBtn.UseVisualStyleBackColor = false;
            // 
            // addItemBtn
            // 
            this.addItemBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(248)))), ((int)(((byte)(1)))));
            this.addItemBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addItemBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addItemBtn.Location = new System.Drawing.Point(215, 192);
            this.addItemBtn.Margin = new System.Windows.Forms.Padding(2);
            this.addItemBtn.Name = "addItemBtn";
            this.addItemBtn.Size = new System.Drawing.Size(66, 28);
            this.addItemBtn.TabIndex = 48;
            this.addItemBtn.Text = "ADD ";
            this.addItemBtn.UseVisualStyleBackColor = false;
            // 
            // addNewMat_Btn
            // 
            this.addNewMat_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.addNewMat_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addNewMat_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addNewMat_Btn.Location = new System.Drawing.Point(86, 225);
            this.addNewMat_Btn.Name = "addNewMat_Btn";
            this.addNewMat_Btn.Size = new System.Drawing.Size(195, 30);
            this.addNewMat_Btn.TabIndex = 49;
            this.addNewMat_Btn.Text = "ADD NEW ITEM";
            this.addNewMat_Btn.UseVisualStyleBackColor = false;
            // 
            // DeliveryManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(892, 693);
            this.Controls.Add(this.addNewMat_Btn);
            this.Controls.Add(this.addItemBtn);
            this.Controls.Add(this.refreshBtn);
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
            this.Controls.Add(this.Logout);
            this.Controls.Add(this.Admin);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "DeliveryManagerForm";
            this.Text = "Delivery Manager Form";
            ((System.ComponentModel.ISupportInitialize)(this.prodDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Admin;
        private System.Windows.Forms.Button Logout;
        private System.Windows.Forms.Label filterLbl;
        private System.Windows.Forms.Label locationLbl;
        private System.Windows.Forms.Label quantityLbl;
        private System.Windows.Forms.Label qualityLbl;
        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.ComboBox locationMenu;
        private System.Windows.Forms.TextBox quantityTxt;
        private System.Windows.Forms.ComboBox qualityMenu;
        private System.Windows.Forms.ComboBox nameMenu;
        private System.Windows.Forms.Label addItemLbl;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.DataGridView prodDataGridView;
        private System.Windows.Forms.Button refreshBtn;
        private System.Windows.Forms.Button addItemBtn;
        private System.Windows.Forms.Button addNewMat_Btn;
    }
}

