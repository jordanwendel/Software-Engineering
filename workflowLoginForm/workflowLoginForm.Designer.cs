
namespace workflowLoginForm
{
    partial class workflowLoginForm
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
            this.title = new System.Windows.Forms.Label();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.passwordTxt = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.loginBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.registerBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.title.Font = new System.Drawing.Font("Impact", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.White;
            this.title.Location = new System.Drawing.Point(180, 44);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(435, 65);
            this.title.TabIndex = 0;
            this.title.Text = "BIKES \"R\" US LOGIN";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // userNameLabel
            // 
            this.userNameLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameLabel.ForeColor = System.Drawing.Color.White;
            this.userNameLabel.Location = new System.Drawing.Point(244, 141);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(113, 23);
            this.userNameLabel.TabIndex = 1;
            this.userNameLabel.Text = "Username:";
            this.userNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // passwordTxt
            // 
            this.passwordTxt.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTxt.ForeColor = System.Drawing.Color.White;
            this.passwordTxt.Location = new System.Drawing.Point(244, 194);
            this.passwordTxt.Name = "passwordTxt";
            this.passwordTxt.Size = new System.Drawing.Size(113, 23);
            this.passwordTxt.TabIndex = 2;
            this.passwordTxt.Text = "Password:";
            this.passwordTxt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(363, 144);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(175, 20);
            this.txtUserName.TabIndex = 3;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(363, 197);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(175, 20);
            this.txtPassword.TabIndex = 4;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // loginBtn
            // 
            this.loginBtn.BackColor = System.Drawing.Color.LightGray;
            this.loginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginBtn.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginBtn.Location = new System.Drawing.Point(513, 269);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(102, 34);
            this.loginBtn.TabIndex = 5;
            this.loginBtn.Text = "LOGIN";
            this.loginBtn.UseVisualStyleBackColor = false;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.BackColor = System.Drawing.Color.LightGray;
            this.clearBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.clearBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.clearBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.clearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearBtn.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearBtn.ForeColor = System.Drawing.Color.Black;
            this.clearBtn.Location = new System.Drawing.Point(190, 269);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(102, 34);
            this.clearBtn.TabIndex = 6;
            this.clearBtn.Text = "CLEAR";
            this.clearBtn.UseVisualStyleBackColor = false;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(65)))), ((int)(((byte)(60)))));
            this.exitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitBtn.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.Location = new System.Drawing.Point(738, 408);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(50, 30);
            this.exitBtn.TabIndex = 7;
            this.exitBtn.Text = "EXIT";
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // registerBtn
            // 
            this.registerBtn.BackColor = System.Drawing.Color.LightGray;
            this.registerBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.registerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registerBtn.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerBtn.ForeColor = System.Drawing.Color.Black;
            this.registerBtn.Location = new System.Drawing.Point(351, 269);
            this.registerBtn.Name = "registerBtn";
            this.registerBtn.Size = new System.Drawing.Size(102, 34);
            this.registerBtn.TabIndex = 8;
            this.registerBtn.Text = "REGISTER";
            this.registerBtn.UseVisualStyleBackColor = false;
            this.registerBtn.Click += new System.EventHandler(this.registerBtn_Click);
            // 
            // workflowLoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.registerBtn);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.passwordTxt);
            this.Controls.Add(this.userNameLabel);
            this.Controls.Add(this.title);
            this.Name = "workflowLoginForm";
            this.Text = "Bikes \"R\" Us Program";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.Label passwordTxt;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Button registerBtn;
    }
}

