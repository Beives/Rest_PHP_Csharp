
namespace REST_CLIENT
{
    partial class registerForm
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
            this.registerBtn = new System.Windows.Forms.Button();
            this.megsemBtn = new System.Windows.Forms.Button();
            this.usernameTxtBox = new System.Windows.Forms.TextBox();
            this.passwordTxtBox = new System.Windows.Forms.TextBox();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // registerBtn
            // 
            this.registerBtn.Location = new System.Drawing.Point(25, 107);
            this.registerBtn.Name = "registerBtn";
            this.registerBtn.Size = new System.Drawing.Size(98, 39);
            this.registerBtn.TabIndex = 0;
            this.registerBtn.Text = "Regisztrálás";
            this.registerBtn.UseVisualStyleBackColor = true;
            this.registerBtn.Click += new System.EventHandler(this.registerBtn_Click);
            // 
            // megsemBtn
            // 
            this.megsemBtn.Location = new System.Drawing.Point(158, 107);
            this.megsemBtn.Name = "megsemBtn";
            this.megsemBtn.Size = new System.Drawing.Size(98, 39);
            this.megsemBtn.TabIndex = 1;
            this.megsemBtn.Text = "Mégsem";
            this.megsemBtn.UseVisualStyleBackColor = true;
            this.megsemBtn.Click += new System.EventHandler(this.megsemBtn_Click);
            // 
            // usernameTxtBox
            // 
            this.usernameTxtBox.Location = new System.Drawing.Point(136, 21);
            this.usernameTxtBox.Name = "usernameTxtBox";
            this.usernameTxtBox.Size = new System.Drawing.Size(100, 23);
            this.usernameTxtBox.TabIndex = 2;
            // 
            // passwordTxtBox
            // 
            this.passwordTxtBox.Location = new System.Drawing.Point(136, 64);
            this.passwordTxtBox.Name = "passwordTxtBox";
            this.passwordTxtBox.Size = new System.Drawing.Size(100, 23);
            this.passwordTxtBox.TabIndex = 3;
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(36, 24);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(87, 15);
            this.usernameLabel.TabIndex = 4;
            this.usernameLabel.Text = "Felhasználónév";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(86, 67);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(37, 15);
            this.passwordLabel.TabIndex = 5;
            this.passwordLabel.Text = "Jelszó";
            // 
            // registerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 158);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.passwordTxtBox);
            this.Controls.Add(this.usernameTxtBox);
            this.Controls.Add(this.megsemBtn);
            this.Controls.Add(this.registerBtn);
            this.Name = "registerForm";
            this.Text = "Regisztráció";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button registerBtn;
        private System.Windows.Forms.Button megsemBtn;
        private System.Windows.Forms.TextBox usernameTxtBox;
        private System.Windows.Forms.TextBox passwordTxtBox;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label passwordLabel;
    }
}