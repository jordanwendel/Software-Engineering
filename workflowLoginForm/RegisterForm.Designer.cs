
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
            this.usernameLbl = new System.Windows.Forms.Label();
            this.passwordLbl = new System.Windows.Forms.Label();
            this.usernameTxt = new System.Windows.Forms.TextBox();
            this.passwordTxt = new System.Windows.Forms.TextBox();
            this.registerBtn = new System.Windows.Forms.Button();
            this.jobLbl = new System.Windows.Forms.Label();
            this.clearBtn = new System.Windows.Forms.Button();
            this.boxOccupation = new System.Windows.Forms.ComboBox();
            this.confirmpasswordtxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // usernameLbl
            // 
            this.usernameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLbl.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.usernameLbl.Location = new System.Drawing.Point(68, 80);
            this.usernameLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.usernameLbl.Name = "usernameLbl";
            this.usernameLbl.Size = new System.Drawing.Size(154, 28);
            this.usernameLbl.TabIndex = 0;
            this.usernameLbl.Text = "Enter Username: ";
            this.usernameLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // passwordLbl
            // 
            this.passwordLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLbl.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.passwordLbl.Location = new System.Drawing.Point(68, 120);
            this.passwordLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.passwordLbl.Name = "passwordLbl";
            this.passwordLbl.Size = new System.Drawing.Size(141, 28);
            this.passwordLbl.TabIndex = 1;
            this.passwordLbl.Text = "Enter Password: ";
            this.passwordLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // usernameTxt
            // 
            this.usernameTxt.Location = new System.Drawing.Point(219, 84);
            this.usernameTxt.Margin = new System.Windows.Forms.Padding(4);
            this.usernameTxt.Name = "usernameTxt";
            this.usernameTxt.Size = new System.Drawing.Size(132, 22);
            this.usernameTxt.TabIndex = 2;
            // 
            // passwordTxt
            // 
            this.passwordTxt.Location = new System.Drawing.Point(217, 124);
            this.passwordTxt.Margin = new System.Windows.Forms.Padding(4);
            this.passwordTxt.Name = "passwordTxt";
            this.passwordTxt.PasswordChar = '*';
            this.passwordTxt.Size = new System.Drawing.Size(132, 22);
            this.passwordTxt.TabIndex = 3;
            this.passwordTxt.UseSystemPasswordChar = true;
            // 
            // registerBtn
            // 
            this.registerBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerBtn.Location = new System.Drawing.Point(393, 120);
            this.registerBtn.Margin = new System.Windows.Forms.Padding(4);
            this.registerBtn.Name = "registerBtn";
            this.registerBtn.Size = new System.Drawing.Size(136, 44);
            this.registerBtn.TabIndex = 4;
            this.registerBtn.Text = "Register";
            this.registerBtn.UseVisualStyleBackColor = true;
            this.registerBtn.Click += new System.EventHandler(this.registerBtn_Click);
            // 
            // jobLbl
            // 
            this.jobLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jobLbl.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.jobLbl.Location = new System.Drawing.Point(71, 193);
            this.jobLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.jobLbl.Name = "jobLbl";
            this.jobLbl.Size = new System.Drawing.Size(139, 28);
            this.jobLbl.TabIndex = 5;
            this.jobLbl.Text = "Enter Job:";
            this.jobLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // clearBtn
            // 
            this.clearBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearBtn.Location = new System.Drawing.Point(412, 172);
            this.clearBtn.Margin = new System.Windows.Forms.Padding(4);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(100, 28);
            this.clearBtn.TabIndex = 7;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // boxOccupation
            // 
            this.boxOccupation.FormattingEnabled = true;
            this.boxOccupation.Items.AddRange(new object[] {
            "Administrator",
            "Delivery Manager",
            "Product Manager",
            "Quality Analyzer",
            "Report Manager",
            "Stockiest"});
            this.boxOccupation.Location = new System.Drawing.Point(217, 200);
            this.boxOccupation.Margin = new System.Windows.Forms.Padding(2);
            this.boxOccupation.Name = "boxOccupation";
            this.boxOccupation.Size = new System.Drawing.Size(132, 24);
            this.boxOccupation.TabIndex = 8;
            // 
            // confirmpasswordtxt
            // 
            this.confirmpasswordtxt.Location = new System.Drawing.Point(217, 165);
            this.confirmpasswordtxt.Margin = new System.Windows.Forms.Padding(4);
            this.confirmpasswordtxt.Name = "confirmpasswordtxt";
            this.confirmpasswordtxt.PasswordChar = '*';
            this.confirmpasswordtxt.Size = new System.Drawing.Size(132, 22);
            this.confirmpasswordtxt.TabIndex = 9;
            this.confirmpasswordtxt.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(55, 161);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 28);
            this.label1.TabIndex = 10;
            this.label1.Text = "Comfirm Password";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 298);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.confirmpasswordtxt);
            this.Controls.Add(this.boxOccupation);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.jobLbl);
            this.Controls.Add(this.registerBtn);
            this.Controls.Add(this.passwordTxt);
            this.Controls.Add(this.usernameTxt);
            this.Controls.Add(this.passwordLbl);
            this.Controls.Add(this.usernameLbl);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "RegisterForm";
            this.Text = "Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label usernameLbl;
        private System.Windows.Forms.Label passwordLbl;
        private System.Windows.Forms.TextBox usernameTxt;
        private System.Windows.Forms.TextBox passwordTxt;
        private System.Windows.Forms.Button registerBtn;
        private System.Windows.Forms.Label jobLbl;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.ComboBox boxOccupation;
        private System.Windows.Forms.TextBox confirmpasswordtxt;
        private System.Windows.Forms.Label label1;
    }
}