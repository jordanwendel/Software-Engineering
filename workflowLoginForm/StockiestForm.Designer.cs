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
            this.addNewMat_Btn = new System.Windows.Forms.Button();
            this.quantityTxt = new System.Windows.Forms.TextBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.filterLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.stockDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // Stockiest
            // 
            this.Stockiest.Font = new System.Drawing.Font("Impact", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Stockiest.ForeColor = System.Drawing.Color.White;
            this.Stockiest.Location = new System.Drawing.Point(273, 9);
            this.Stockiest.Name = "Stockiest";
            this.Stockiest.Size = new System.Drawing.Size(428, 50);
            this.Stockiest.TabIndex = 2;
            this.Stockiest.Text = "Stockiest Page";
            this.Stockiest.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Logout
            // 
            this.Logout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(57)))), ((int)(((byte)(52)))));
            this.Logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logout.Location = new System.Drawing.Point(11, 562);
            this.Logout.Margin = new System.Windows.Forms.Padding(2);
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(106, 29);
            this.Logout.TabIndex = 5;
            this.Logout.Text = "LOG OUT";
            this.Logout.UseVisualStyleBackColor = false;
            this.Logout.Click += new System.EventHandler(this.Logout_Click);
            // 
            // addNewMatBtn
            // 
            this.addNewMatBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(248)))), ((int)(((byte)(1)))));
            this.addNewMatBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addNewMatBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addNewMatBtn.Location = new System.Drawing.Point(113, 140);
            this.addNewMatBtn.Margin = new System.Windows.Forms.Padding(2);
            this.addNewMatBtn.Name = "addNewMatBtn";
            this.addNewMatBtn.Size = new System.Drawing.Size(90, 30);
            this.addNewMatBtn.TabIndex = 6;
            this.addNewMatBtn.Text = "ADD";
            this.addNewMatBtn.UseVisualStyleBackColor = false;
            // 
            // refreshBtn
            // 
            this.refreshBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(214)))), ((int)(((byte)(243)))));
            this.refreshBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refreshBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshBtn.Location = new System.Drawing.Point(764, 556);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(97, 35);
            this.refreshBtn.TabIndex = 7;
            this.refreshBtn.Text = "REFRESH";
            this.refreshBtn.UseVisualStyleBackColor = false;
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
            this.rawMatsList.Location = new System.Drawing.Point(76, 75);
            this.rawMatsList.Name = "rawMatsList";
            this.rawMatsList.Size = new System.Drawing.Size(127, 21);
            this.rawMatsList.TabIndex = 10;
            this.rawMatsList.Text = "Click to expand...";
            // 
            // addItemLbl
            // 
            this.addItemLbl.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addItemLbl.ForeColor = System.Drawing.Color.White;
            this.addItemLbl.Location = new System.Drawing.Point(32, 35);
            this.addItemLbl.Name = "addItemLbl";
            this.addItemLbl.Size = new System.Drawing.Size(138, 24);
            this.addItemLbl.TabIndex = 12;
            this.addItemLbl.Text = "Add Item";
            this.addItemLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // itemLbl
            // 
            this.itemLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemLbl.ForeColor = System.Drawing.Color.White;
            this.itemLbl.Location = new System.Drawing.Point(24, 73);
            this.itemLbl.Name = "itemLbl";
            this.itemLbl.Size = new System.Drawing.Size(46, 23);
            this.itemLbl.TabIndex = 13;
            this.itemLbl.Text = "Item:";
            this.itemLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // quantityLbl
            // 
            this.quantityLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityLbl.ForeColor = System.Drawing.Color.White;
            this.quantityLbl.Location = new System.Drawing.Point(-6, 99);
            this.quantityLbl.Name = "quantityLbl";
            this.quantityLbl.Size = new System.Drawing.Size(76, 23);
            this.quantityLbl.TabIndex = 14;
            this.quantityLbl.Text = "Quantity:";
            this.quantityLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // addNewMat_Btn
            // 
            this.addNewMat_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.addNewMat_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addNewMat_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addNewMat_Btn.Location = new System.Drawing.Point(8, 175);
            this.addNewMat_Btn.Name = "addNewMat_Btn";
            this.addNewMat_Btn.Size = new System.Drawing.Size(195, 30);
            this.addNewMat_Btn.TabIndex = 15;
            this.addNewMat_Btn.Text = "ADD NEW ITEM";
            this.addNewMat_Btn.UseVisualStyleBackColor = false;
            this.addNewMat_Btn.Click += new System.EventHandler(this.addNewMat_Btn_Click);
            // 
            // quantityTxt
            // 
            this.quantityTxt.Location = new System.Drawing.Point(76, 102);
            this.quantityTxt.Name = "quantityTxt";
            this.quantityTxt.Size = new System.Drawing.Size(127, 20);
            this.quantityTxt.TabIndex = 16;
            this.quantityTxt.Text = "Enter Quantity";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(8, 293);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(196, 244);
            this.checkedListBox1.TabIndex = 17;
            // 
            // filterLbl
            // 
            this.filterLbl.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filterLbl.ForeColor = System.Drawing.Color.White;
            this.filterLbl.Location = new System.Drawing.Point(32, 257);
            this.filterLbl.Name = "filterLbl";
            this.filterLbl.Size = new System.Drawing.Size(143, 24);
            this.filterLbl.TabIndex = 29;
            this.filterLbl.Text = "Filter Items";
            this.filterLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StockiestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(875, 602);
            this.Controls.Add(this.filterLbl);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.quantityTxt);
            this.Controls.Add(this.addNewMat_Btn);
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
            this.Text = "Stockiest Form";
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
        private System.Windows.Forms.Button addNewMat_Btn;
        private System.Windows.Forms.TextBox quantityTxt;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Label filterLbl;
    }
}

