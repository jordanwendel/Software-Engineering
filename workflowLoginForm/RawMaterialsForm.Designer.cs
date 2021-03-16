
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnInsertInformation = new System.Windows.Forms.Button();
            this.txtRawMatName = new System.Windows.Forms.TextBox();
            this.txtRawMatQuanity = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblRawMat
            // 
            this.lblRawMat.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRawMat.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRawMat.Location = new System.Drawing.Point(127, 49);
            this.lblRawMat.Name = "lblRawMat";
            this.lblRawMat.Size = new System.Drawing.Size(451, 57);
            this.lblRawMat.TabIndex = 24;
            this.lblRawMat.Text = "Raw Materials Forms";
            this.lblRawMat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(549, 259);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 23;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(124, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 22);
            this.label3.TabIndex = 20;
            this.label3.Text = "Quantity of Raw Material";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(124, 156);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(166, 17);
            this.lblName.TabIndex = 19;
            this.lblName.Text = "Name of Raw Material";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(124, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 22);
            this.label1.TabIndex = 17;
            // 
            // btnInsertInformation
            // 
            this.btnInsertInformation.Location = new System.Drawing.Point(320, 259);
            this.btnInsertInformation.Name = "btnInsertInformation";
            this.btnInsertInformation.Size = new System.Drawing.Size(187, 23);
            this.btnInsertInformation.TabIndex = 16;
            this.btnInsertInformation.Text = "Insert into Database";
            this.btnInsertInformation.UseVisualStyleBackColor = true;
            this.btnInsertInformation.Click += new System.EventHandler(this.btnInsertInformation_Click);
            // 
            // txtRawMatName
            // 
            this.txtRawMatName.Location = new System.Drawing.Point(292, 152);
            this.txtRawMatName.Name = "txtRawMatName";
            this.txtRawMatName.Size = new System.Drawing.Size(288, 22);
            this.txtRawMatName.TabIndex = 14;
            // 
            // txtRawMatQuanity
            // 
            this.txtRawMatQuanity.Location = new System.Drawing.Point(291, 212);
            this.txtRawMatQuanity.Name = "txtRawMatQuanity";
            this.txtRawMatQuanity.Size = new System.Drawing.Size(288, 22);
            this.txtRawMatQuanity.TabIndex = 13;
            // 
            // RawMats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblRawMat);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnInsertInformation);
            this.Controls.Add(this.txtRawMatName);
            this.Controls.Add(this.txtRawMatQuanity);
            this.Name = "RawMats";
            this.Text = "Prodcut Form";
            this.Load += new System.EventHandler(this.RawMaterials_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRawMat;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnInsertInformation;
        private System.Windows.Forms.TextBox txtRawMatName;
        private System.Windows.Forms.TextBox txtRawMatQuanity;
    }
}

