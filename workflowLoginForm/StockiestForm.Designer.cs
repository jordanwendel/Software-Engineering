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
            this.changeqnt = new System.Windows.Forms.Button();
            this.refreshBtn = new System.Windows.Forms.Button();
            this.stockDataGridView = new System.Windows.Forms.DataGridView();
            this.addItemLbl = new System.Windows.Forms.Label();
            this.itemLbl = new System.Windows.Forms.Label();
            this.quantityLbl = new System.Windows.Forms.Label();
            this.addNewMat_Btn = new System.Windows.Forms.Button();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.filterLbl = new System.Windows.Forms.Label();
            this.itembox = new System.Windows.Forms.TextBox();
            this.qtnBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.stockDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // Stockiest
            // 
            this.Stockiest.Font = new System.Drawing.Font("Impact", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Stockiest.ForeColor = System.Drawing.Color.White;
            this.Stockiest.Location = new System.Drawing.Point(546, 17);
            this.Stockiest.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Stockiest.Name = "Stockiest";
            this.Stockiest.Size = new System.Drawing.Size(856, 97);
            this.Stockiest.TabIndex = 2;
            this.Stockiest.Text = "Stockiest Page";
            this.Stockiest.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Logout
            // 
            this.Logout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(57)))), ((int)(((byte)(52)))));
            this.Logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logout.Location = new System.Drawing.Point(22, 1081);
            this.Logout.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(212, 56);
            this.Logout.TabIndex = 6;
            this.Logout.Text = "LOG OUT";
            this.Logout.UseVisualStyleBackColor = false;
            this.Logout.Click += new System.EventHandler(this.Logout_Click);
            // 
            // changeqnt
            // 
            this.changeqnt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(248)))), ((int)(((byte)(1)))));
            this.changeqnt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changeqnt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeqnt.Location = new System.Drawing.Point(190, 251);
            this.changeqnt.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.changeqnt.Name = "changeqnt";
            this.changeqnt.Size = new System.Drawing.Size(160, 58);
            this.changeqnt.TabIndex = 2;
            this.changeqnt.Text = "Edit";
            this.changeqnt.UseVisualStyleBackColor = false;
            this.changeqnt.Click += new System.EventHandler(this.addNewMatBtn_Click);
            // 
            // refreshBtn
            // 
            this.refreshBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(214)))), ((int)(((byte)(243)))));
            this.refreshBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refreshBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshBtn.Location = new System.Drawing.Point(1528, 1069);
            this.refreshBtn.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(194, 67);
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
            this.stockDataGridView.Location = new System.Drawing.Point(420, 119);
            this.stockDataGridView.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.stockDataGridView.Name = "stockDataGridView";
            this.stockDataGridView.RowHeadersWidth = 51;
            this.stockDataGridView.Size = new System.Drawing.Size(1302, 914);
            this.stockDataGridView.TabIndex = 5;
            // 
            // addItemLbl
            // 
            this.addItemLbl.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addItemLbl.ForeColor = System.Drawing.Color.White;
            this.addItemLbl.Location = new System.Drawing.Point(22, 45);
            this.addItemLbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.addItemLbl.Name = "addItemLbl";
            this.addItemLbl.Size = new System.Drawing.Size(362, 69);
            this.addItemLbl.TabIndex = 12;
            this.addItemLbl.Text = "Change Quantity";
            this.addItemLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // itemLbl
            // 
            this.itemLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemLbl.ForeColor = System.Drawing.Color.White;
            this.itemLbl.Location = new System.Drawing.Point(48, 141);
            this.itemLbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.itemLbl.Name = "itemLbl";
            this.itemLbl.Size = new System.Drawing.Size(92, 44);
            this.itemLbl.TabIndex = 13;
            this.itemLbl.Text = "Item:";
            this.itemLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // quantityLbl
            // 
            this.quantityLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityLbl.ForeColor = System.Drawing.Color.White;
            this.quantityLbl.Location = new System.Drawing.Point(-12, 191);
            this.quantityLbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.quantityLbl.Name = "quantityLbl";
            this.quantityLbl.Size = new System.Drawing.Size(152, 44);
            this.quantityLbl.TabIndex = 14;
            this.quantityLbl.Text = "Quantity:";
            this.quantityLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // addNewMat_Btn
            // 
            this.addNewMat_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.addNewMat_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addNewMat_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addNewMat_Btn.Location = new System.Drawing.Point(16, 336);
            this.addNewMat_Btn.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.addNewMat_Btn.Name = "addNewMat_Btn";
            this.addNewMat_Btn.Size = new System.Drawing.Size(390, 58);
            this.addNewMat_Btn.TabIndex = 3;
            this.addNewMat_Btn.Text = "ADD NEW ITEM";
            this.addNewMat_Btn.UseVisualStyleBackColor = false;
            this.addNewMat_Btn.Click += new System.EventHandler(this.addNewMat_Btn_Click);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(16, 564);
            this.checkedListBox1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(388, 452);
            this.checkedListBox1.TabIndex = 4;
            // 
            // filterLbl
            // 
            this.filterLbl.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filterLbl.ForeColor = System.Drawing.Color.White;
            this.filterLbl.Location = new System.Drawing.Point(64, 494);
            this.filterLbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.filterLbl.Name = "filterLbl";
            this.filterLbl.Size = new System.Drawing.Size(286, 47);
            this.filterLbl.TabIndex = 29;
            this.filterLbl.Text = "Filter Items";
            this.filterLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // itembox
            // 
            this.itembox.Location = new System.Drawing.Point(149, 150);
            this.itembox.Name = "itembox";
            this.itembox.Size = new System.Drawing.Size(253, 31);
            this.itembox.TabIndex = 30;
            // 
            // qtnBox
            // 
            this.qtnBox.Location = new System.Drawing.Point(149, 204);
            this.qtnBox.Name = "qtnBox";
            this.qtnBox.Size = new System.Drawing.Size(253, 31);
            this.qtnBox.TabIndex = 31;
            // 
            // StockiestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1750, 1158);
            this.Controls.Add(this.qtnBox);
            this.Controls.Add(this.itembox);
            this.Controls.Add(this.filterLbl);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.addNewMat_Btn);
            this.Controls.Add(this.quantityLbl);
            this.Controls.Add(this.itemLbl);
            this.Controls.Add(this.addItemLbl);
            this.Controls.Add(this.stockDataGridView);
            this.Controls.Add(this.refreshBtn);
            this.Controls.Add(this.changeqnt);
            this.Controls.Add(this.Logout);
            this.Controls.Add(this.Stockiest);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
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
        private System.Windows.Forms.Button changeqnt;
        private System.Windows.Forms.Button refreshBtn;
        private System.Windows.Forms.DataGridView stockDataGridView;
        private System.Windows.Forms.Label addItemLbl;
        private System.Windows.Forms.Label itemLbl;
        private System.Windows.Forms.Label quantityLbl;
        private System.Windows.Forms.Button addNewMat_Btn;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Label filterLbl;
        private System.Windows.Forms.TextBox itembox;
        private System.Windows.Forms.TextBox qtnBox;
    }
}

