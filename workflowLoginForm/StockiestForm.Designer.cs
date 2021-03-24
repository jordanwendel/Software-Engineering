namespace workflowLoginForm
{
    partial class StockiestForm
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
            this.Stockiest = new System.Windows.Forms.Label();
            this.Logout = new System.Windows.Forms.Button();
            this.addNewMatBtn = new System.Windows.Forms.Button();
            this.refreshBtn = new System.Windows.Forms.Button();
            this.stockDataGridView = new System.Windows.Forms.DataGridView();
            this.rawMatsList = new System.Windows.Forms.ComboBox();
            this.addItemLbl = new System.Windows.Forms.Label();
            this.itemLbl = new System.Windows.Forms.Label();
            this.quantityLbl = new System.Windows.Forms.Label();
            this.addItemBtn = new System.Windows.Forms.Button();
            this.quantityTxt = new System.Windows.Forms.TextBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.filterLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.stockDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // Stockiest
            // 
            this.Stockiest.Font = new System.Drawing.Font("Tahoma", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Stockiest.Location = new System.Drawing.Point(239, 9);
            this.Stockiest.Name = "Stockiest";
            this.Stockiest.Size = new System.Drawing.Size(428, 50);
            this.Stockiest.TabIndex = 2;
            this.Stockiest.Text = "STOCKIEST PAGE";
            this.Stockiest.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Logout
            // 
            this.Logout.Location = new System.Drawing.Point(11, 552);
            this.Logout.Margin = new System.Windows.Forms.Padding(2);
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(84, 39);
            this.Logout.TabIndex = 5;
            this.Logout.Text = "Logout";
            this.Logout.UseVisualStyleBackColor = true;
            this.Logout.Click += new System.EventHandler(this.Logout_Click);
            // 
            // addNewMatBtn
            // 
            this.addNewMatBtn.Location = new System.Drawing.Point(109, 177);
            this.addNewMatBtn.Margin = new System.Windows.Forms.Padding(2);
            this.addNewMatBtn.Name = "addNewMatBtn";
            this.addNewMatBtn.Size = new System.Drawing.Size(98, 28);
            this.addNewMatBtn.TabIndex = 6;
            this.addNewMatBtn.Text = "Add New";
            this.addNewMatBtn.UseVisualStyleBackColor = true;
            this.addNewMatBtn.Click += new System.EventHandler(this.addNewMatBtn_Click);
            // 
            // refreshBtn
            // 
            this.refreshBtn.Location = new System.Drawing.Point(766, 552);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(97, 40);
            this.refreshBtn.TabIndex = 7;
            this.refreshBtn.Text = "Refresh Inventory";
            this.refreshBtn.UseVisualStyleBackColor = true;
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // stockDataGridView
            // 
            this.stockDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.stockDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.stockDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stockDataGridView.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.stockDataGridView.Location = new System.Drawing.Point(210, 62);
            this.stockDataGridView.Name = "stockDataGridView";
            this.stockDataGridView.Size = new System.Drawing.Size(651, 475);
            this.stockDataGridView.TabIndex = 8;
            // 
            // rawMatsList
            // 
            this.rawMatsList.FormattingEnabled = true;
            this.rawMatsList.Location = new System.Drawing.Point(85, 102);
            this.rawMatsList.Name = "rawMatsList";
            this.rawMatsList.Size = new System.Drawing.Size(119, 21);
            this.rawMatsList.TabIndex = 10;
            this.rawMatsList.Text = "Click to expand...";
            // 
            // addItemLbl
            // 
            this.addItemLbl.AutoSize = true;
            this.addItemLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addItemLbl.Location = new System.Drawing.Point(60, 62);
            this.addItemLbl.Name = "addItemLbl";
            this.addItemLbl.Size = new System.Drawing.Size(93, 24);
            this.addItemLbl.TabIndex = 12;
            this.addItemLbl.Text = "Add Item";
            // 
            // itemLbl
            // 
            this.itemLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemLbl.Location = new System.Drawing.Point(8, 102);
            this.itemLbl.Name = "itemLbl";
            this.itemLbl.Size = new System.Drawing.Size(46, 23);
            this.itemLbl.TabIndex = 13;
            this.itemLbl.Text = "Item";
            this.itemLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // quantityLbl
            // 
            this.quantityLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityLbl.Location = new System.Drawing.Point(8, 137);
            this.quantityLbl.Name = "quantityLbl";
            this.quantityLbl.Size = new System.Drawing.Size(87, 23);
            this.quantityLbl.TabIndex = 14;
            this.quantityLbl.Text = "Quantity";
            this.quantityLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // addItemBtn
            // 
            this.addItemBtn.Location = new System.Drawing.Point(11, 177);
            this.addItemBtn.Name = "addItemBtn";
            this.addItemBtn.Size = new System.Drawing.Size(93, 28);
            this.addItemBtn.TabIndex = 15;
            this.addItemBtn.Text = "Add Item";
            this.addItemBtn.UseVisualStyleBackColor = true;
            // 
            // quantityTxt
            // 
            this.quantityTxt.Location = new System.Drawing.Point(85, 139);
            this.quantityTxt.Name = "quantityTxt";
            this.quantityTxt.Size = new System.Drawing.Size(119, 20);
            this.quantityTxt.TabIndex = 16;
            this.quantityTxt.Text = "Enter Quantity";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(11, 308);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(172, 229);
            this.checkedListBox1.TabIndex = 17;
            // 
            // filterLbl
            // 
            this.filterLbl.AutoSize = true;
            this.filterLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filterLbl.Location = new System.Drawing.Point(71, 281);
            this.filterLbl.Name = "filterLbl";
            this.filterLbl.Size = new System.Drawing.Size(57, 24);
            this.filterLbl.TabIndex = 29;
            this.filterLbl.Text = "Filter";
            // 
            // StockiestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 602);
            this.Controls.Add(this.filterLbl);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.quantityTxt);
            this.Controls.Add(this.addItemBtn);
            this.Controls.Add(this.quantityLbl);
            this.Controls.Add(this.itemLbl);
            this.Controls.Add(this.addItemLbl);
            this.Controls.Add(this.rawMatsList);
            this.Controls.Add(this.stockDataGridView);
            this.Controls.Add(this.refreshBtn);
            this.Controls.Add(this.addNewMatBtn);
            this.Controls.Add(this.Logout);
            this.Controls.Add(this.Stockiest);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "StockiestForm";
            this.Text = "Stockiest";
            this.Load += new System.EventHandler(this.StockiestForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.stockDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Stockiest;
        private System.Windows.Forms.Button Logout;
        private System.Windows.Forms.Button addNewMatBtn;
        private System.Windows.Forms.Button refreshBtn;
        private System.Windows.Forms.DataGridView stockDataGridView;
        private System.Windows.Forms.ComboBox rawMatsList;
        private System.Windows.Forms.Label addItemLbl;
        private System.Windows.Forms.Label itemLbl;
        private System.Windows.Forms.Label quantityLbl;
        private System.Windows.Forms.Button addItemBtn;
        private System.Windows.Forms.TextBox quantityTxt;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Label filterLbl;
    }
}

