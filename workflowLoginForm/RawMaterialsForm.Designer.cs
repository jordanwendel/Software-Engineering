
namespace workflowLoginForm
{
    partial class RawMaterialsForm
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
            this.lblRawMat = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.btnInsertInformation = new System.Windows.Forms.Button();
            this.txtRawMatName = new System.Windows.Forms.TextBox();
            this.txtRawMatQuanity = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblRawMat
            // 
            this.lblRawMat.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRawMat.Font = new System.Drawing.Font("Impact", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRawMat.ForeColor = System.Drawing.Color.White;
            this.lblRawMat.Location = new System.Drawing.Point(81, 33);
            this.lblRawMat.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRawMat.Name = "lblRawMat";
            this.lblRawMat.Size = new System.Drawing.Size(434, 46);
            this.lblRawMat.TabIndex = 24;
            this.lblRawMat.Text = "Raw Materials Database";
            this.lblRawMat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(80)))), ((int)(((byte)(75)))));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(11, 330);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 25);
            this.btnExit.TabIndex = 23;
            this.btnExit.Text = "EXIT ";
            this.btnExit.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(152, 198);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 18);
            this.label3.TabIndex = 20;
            this.label3.Text = "Item Quantity:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblName
            // 
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(164, 151);
            this.lblName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(105, 20);
            this.lblName.TabIndex = 19;
            this.lblName.Text = "Item Name:";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnInsertInformation
            // 
            this.btnInsertInformation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(214)))), ((int)(((byte)(98)))));
            this.btnInsertInformation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsertInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertInformation.Location = new System.Drawing.Point(489, 320);
            this.btnInsertInformation.Margin = new System.Windows.Forms.Padding(2);
            this.btnInsertInformation.Name = "btnInsertInformation";
            this.btnInsertInformation.Size = new System.Drawing.Size(100, 35);
            this.btnInsertInformation.TabIndex = 16;
            this.btnInsertInformation.Text = "INSERT";
            this.btnInsertInformation.UseVisualStyleBackColor = false;
            this.btnInsertInformation.Click += new System.EventHandler(this.btnInsertInformation_Click);
            // 
            // txtRawMatName
            // 
            this.txtRawMatName.Location = new System.Drawing.Point(273, 153);
            this.txtRawMatName.Margin = new System.Windows.Forms.Padding(2);
            this.txtRawMatName.Name = "txtRawMatName";
            this.txtRawMatName.Size = new System.Drawing.Size(160, 20);
            this.txtRawMatName.TabIndex = 14;
            // 
            // txtRawMatQuanity
            // 
            this.txtRawMatQuanity.Location = new System.Drawing.Point(273, 199);
            this.txtRawMatQuanity.Margin = new System.Windows.Forms.Padding(2);
            this.txtRawMatQuanity.Name = "txtRawMatQuanity";
            this.txtRawMatQuanity.Size = new System.Drawing.Size(160, 20);
            this.txtRawMatQuanity.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(224, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Add a Raw Material";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RawMaterialsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblRawMat);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnInsertInformation);
            this.Controls.Add(this.txtRawMatName);
            this.Controls.Add(this.txtRawMatQuanity);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "RawMaterialsForm";
            this.Text = "Raw Materials Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRawMat;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnInsertInformation;
        private System.Windows.Forms.TextBox txtRawMatName;
        private System.Windows.Forms.TextBox txtRawMatQuanity;
        private System.Windows.Forms.Label label1;
    }
}

