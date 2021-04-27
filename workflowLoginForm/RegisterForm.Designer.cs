
namespace workflowLoginForm
{
    
    partial class RegisterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            this.usernameLbl = new System.Windows.Forms.Label();
            this.usernameTxt = new System.Windows.Forms.TextBox();
            this.passwordTxt = new System.Windows.Forms.TextBox();
            this.registerBtn = new System.Windows.Forms.Button();
            this.boxOccupation = new System.Windows.Forms.ComboBox();
            this.confirmpasswordtxt = new System.Windows.Forms.TextBox();
            this.RegTitle = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.goBackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.firstnametxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lastnametxt = new System.Windows.Forms.TextBox();
            this.emailtxt = new System.Windows.Forms.TextBox();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // usernameLbl
            // 
            this.usernameLbl.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLbl.ForeColor = System.Drawing.Color.White;
            this.usernameLbl.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.usernameLbl.Location = new System.Drawing.Point(544, 130);
            this.usernameLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.usernameLbl.Name = "usernameLbl";
            this.usernameLbl.Size = new System.Drawing.Size(195, 28);
            this.usernameLbl.TabIndex = 0;
            this.usernameLbl.Text = "Username: ";
            this.usernameLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // usernameTxt
            // 
            this.usernameTxt.BackColor = System.Drawing.SystemColors.Control;
            this.usernameTxt.Location = new System.Drawing.Point(747, 135);
            this.usernameTxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.usernameTxt.Name = "usernameTxt";
            this.usernameTxt.Size = new System.Drawing.Size(132, 22);
            this.usernameTxt.TabIndex = 0;
            // 
            // passwordTxt
            // 
            this.passwordTxt.BackColor = System.Drawing.SystemColors.Control;
            this.passwordTxt.Location = new System.Drawing.Point(747, 185);
            this.passwordTxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.passwordTxt.Name = "passwordTxt";
            this.passwordTxt.PasswordChar = '*';
            this.passwordTxt.Size = new System.Drawing.Size(132, 22);
            this.passwordTxt.TabIndex = 1;
            this.passwordTxt.UseSystemPasswordChar = true;
            // 
            // registerBtn
            // 
            this.registerBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(220)))), ((int)(((byte)(109)))));
            this.registerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registerBtn.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerBtn.Location = new System.Drawing.Point(415, 399);
            this.registerBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.registerBtn.Name = "registerBtn";
            this.registerBtn.Size = new System.Drawing.Size(200, 50);
            this.registerBtn.TabIndex = 5;
            this.registerBtn.Text = "Register";
            this.registerBtn.UseVisualStyleBackColor = false;
            this.registerBtn.Click += new System.EventHandler(this.registerBtn_Click);
            // 
            // boxOccupation
            // 
            this.boxOccupation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.boxOccupation.FormattingEnabled = true;
            this.boxOccupation.Items.AddRange(new object[] {
            "Administrator",
            "Delivery Manager",
            "Product Manager",
            "Quality Analyzer",
            "Report Manager",
            "Stockiest"});
            this.boxOccupation.Location = new System.Drawing.Point(547, 322);
            this.boxOccupation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.boxOccupation.Name = "boxOccupation";
            this.boxOccupation.Size = new System.Drawing.Size(132, 24);
            this.boxOccupation.TabIndex = 3;
            // 
            // confirmpasswordtxt
            // 
            this.confirmpasswordtxt.BackColor = System.Drawing.SystemColors.Control;
            this.confirmpasswordtxt.Location = new System.Drawing.Point(747, 235);
            this.confirmpasswordtxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.confirmpasswordtxt.Name = "confirmpasswordtxt";
            this.confirmpasswordtxt.PasswordChar = '*';
            this.confirmpasswordtxt.Size = new System.Drawing.Size(132, 22);
            this.confirmpasswordtxt.TabIndex = 2;
            this.confirmpasswordtxt.UseSystemPasswordChar = true;
            // 
            // RegTitle
            // 
            this.RegTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RegTitle.AutoSize = true;
            this.RegTitle.Font = new System.Drawing.Font("Lucida Bright", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegTitle.ForeColor = System.Drawing.Color.White;
            this.RegTitle.Location = new System.Drawing.Point(271, 43);
            this.RegTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RegTitle.Name = "RegTitle";
            this.RegTitle.Size = new System.Drawing.Size(463, 53);
            this.RegTitle.TabIndex = 11;
            this.RegTitle.Text = "Register New User";
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.LightGray;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1});
            this.toolStrip1.Location = new System.Drawing.Point(868, 9);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(66, 27);
            this.toolStrip1.TabIndex = 66;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripDropDownButton1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearToolStripMenuItem,
            this.goBackToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(63, 24);
            this.toolStripDropDownButton1.Text = "Menu";
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.clearToolStripMenuItem.Text = "Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
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
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(544, 178);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 28);
            this.label2.TabIndex = 67;
            this.label2.Text = "Password:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Location = new System.Drawing.Point(520, 229);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(219, 28);
            this.label3.TabIndex = 68;
            this.label3.Text = "Confirm Password:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.Location = new System.Drawing.Point(339, 322);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(201, 26);
            this.label4.TabIndex = 69;
            this.label4.Text = "Select Job Type:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(131, 229);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 28);
            this.label1.TabIndex = 75;
            this.label1.Text = "Enter Email:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label5.Location = new System.Drawing.Point(111, 178);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(220, 28);
            this.label5.TabIndex = 74;
            this.label5.Text = "Last Name:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // firstnametxt
            // 
            this.firstnametxt.BackColor = System.Drawing.SystemColors.Control;
            this.firstnametxt.Location = new System.Drawing.Point(339, 135);
            this.firstnametxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.firstnametxt.Name = "firstnametxt";
            this.firstnametxt.Size = new System.Drawing.Size(132, 22);
            this.firstnametxt.TabIndex = 70;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label6.Location = new System.Drawing.Point(105, 130);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(227, 28);
            this.label6.TabIndex = 71;
            this.label6.Text = "First Name:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lastnametxt
            // 
            this.lastnametxt.BackColor = System.Drawing.SystemColors.Control;
            this.lastnametxt.Location = new System.Drawing.Point(339, 185);
            this.lastnametxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lastnametxt.Name = "lastnametxt";
            this.lastnametxt.Size = new System.Drawing.Size(132, 22);
            this.lastnametxt.TabIndex = 76;
            // 
            // emailtxt
            // 
            this.emailtxt.BackColor = System.Drawing.SystemColors.Control;
            this.emailtxt.Location = new System.Drawing.Point(339, 235);
            this.emailtxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.emailtxt.Name = "emailtxt";
            this.emailtxt.Size = new System.Drawing.Size(132, 22);
            this.emailtxt.TabIndex = 77;
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(981, 553);
            this.Controls.Add(this.emailtxt);
            this.Controls.Add(this.lastnametxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.firstnametxt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.RegTitle);
            this.Controls.Add(this.confirmpasswordtxt);
            this.Controls.Add(this.boxOccupation);
            this.Controls.Add(this.registerBtn);
            this.Controls.Add(this.passwordTxt);
            this.Controls.Add(this.usernameTxt);
            this.Controls.Add(this.usernameLbl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "RegisterForm";
            this.Text = "Add New User";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label usernameLbl;
        private System.Windows.Forms.TextBox usernameTxt;
        private System.Windows.Forms.TextBox passwordTxt;
        private System.Windows.Forms.Button registerBtn;
        private System.Windows.Forms.ComboBox boxOccupation;
        private System.Windows.Forms.TextBox confirmpasswordtxt;
        private System.Windows.Forms.Label RegTitle;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem goBackToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox firstnametxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox lastnametxt;
        private System.Windows.Forms.TextBox emailtxt;
    }
}