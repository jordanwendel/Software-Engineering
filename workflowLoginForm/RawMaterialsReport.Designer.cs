﻿
namespace workflowLoginForm
{
    partial class RawMaterialsReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RawMaterialsReport));
            this.lblNumbers = new System.Windows.Forms.Label();
            this.stockDataGridView = new System.Windows.Forms.DataGridView();
            this.Logout = new System.Windows.Forms.Button();
            this.Stockiest = new System.Windows.Forms.Label();
            this.countlbl = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.averagelbl = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.goBackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.stockDataGridView)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNumbers
            // 
            this.lblNumbers.Font = new System.Drawing.Font("Impact", 14F);
            this.lblNumbers.ForeColor = System.Drawing.Color.White;
            this.lblNumbers.Location = new System.Drawing.Point(29, 69);
            this.lblNumbers.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumbers.Name = "lblNumbers";
            this.lblNumbers.Size = new System.Drawing.Size(288, 44);
            this.lblNumbers.TabIndex = 70;
            this.lblNumbers.Text = "Number of unique materials";
            this.lblNumbers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // stockDataGridView
            // 
            this.stockDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.stockDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.stockDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stockDataGridView.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.stockDataGridView.Location = new System.Drawing.Point(349, 69);
            this.stockDataGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.stockDataGridView.Name = "stockDataGridView";
            this.stockDataGridView.RowHeadersWidth = 51;
            this.stockDataGridView.Size = new System.Drawing.Size(708, 570);
            this.stockDataGridView.TabIndex = 68;
            this.stockDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.stockDataGridView_CellContentClick);
            // 
            // Logout
            // 
            this.Logout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(57)))), ((int)(((byte)(52)))));
            this.Logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logout.Location = new System.Drawing.Point(1002, 22);
            this.Logout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(141, 36);
            this.Logout.TabIndex = 69;
            this.Logout.Text = "LOG OUT";
            this.Logout.UseVisualStyleBackColor = false;
            // 
            // Stockiest
            // 
            this.Stockiest.Font = new System.Drawing.Font("Impact", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Stockiest.ForeColor = System.Drawing.Color.White;
            this.Stockiest.Location = new System.Drawing.Point(340, 3);
            this.Stockiest.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Stockiest.Name = "Stockiest";
            this.Stockiest.Size = new System.Drawing.Size(571, 62);
            this.Stockiest.TabIndex = 65;
            this.Stockiest.Text = "Raw Materials Report";
            this.Stockiest.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // countlbl
            // 
            this.countlbl.Font = new System.Drawing.Font("Impact", 10F);
            this.countlbl.ForeColor = System.Drawing.Color.White;
            this.countlbl.Location = new System.Drawing.Point(52, 113);
            this.countlbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.countlbl.Name = "countlbl";
            this.countlbl.Size = new System.Drawing.Size(241, 44);
            this.countlbl.TabIndex = 71;
            this.countlbl.Text = "Unknown";
            this.countlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(228, 43);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 72;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Impact", 14F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(15, 168);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(326, 44);
            this.label1.TabIndex = 73;
            this.label1.Text = "Average Quantity of materials";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // averagelbl
            // 
            this.averagelbl.Font = new System.Drawing.Font("Impact", 10F);
            this.averagelbl.ForeColor = System.Drawing.Color.White;
            this.averagelbl.Location = new System.Drawing.Point(52, 212);
            this.averagelbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.averagelbl.Name = "averagelbl";
            this.averagelbl.Size = new System.Drawing.Size(241, 44);
            this.averagelbl.TabIndex = 74;
            this.averagelbl.Text = "Unknown";
            this.averagelbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(810, 27);
            this.toolStrip1.TabIndex = 75;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshToolStripMenuItem,
            this.goBackToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(60, 24);
            this.toolStripDropDownButton1.Text = "Menu";
            // 
            // goBackToolStripMenuItem
            // 
            this.goBackToolStripMenuItem.Name = "goBackToolStripMenuItem";
            this.goBackToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.goBackToolStripMenuItem.Text = "Go Back";
            this.goBackToolStripMenuItem.Click += new System.EventHandler(this.goBackToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.refreshToolStripMenuItem.Text = "Refresh";
            // 
            // RawMaterialsReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(810, 456);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.averagelbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.countlbl);
            this.Controls.Add(this.lblNumbers);
            this.Controls.Add(this.stockDataGridView);
            this.Controls.Add(this.Logout);
            this.Controls.Add(this.Stockiest);
            this.Name = "RawMaterialsReport";
            this.Text = "Raw Materials Report";
            ((System.ComponentModel.ISupportInitialize)(this.stockDataGridView)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblNumbers;
        private System.Windows.Forms.DataGridView stockDataGridView;
        private System.Windows.Forms.Button Logout;
        private System.Windows.Forms.Label Stockiest;
        public System.Windows.Forms.Label countlbl;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label averagelbl;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem goBackToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
    }
}