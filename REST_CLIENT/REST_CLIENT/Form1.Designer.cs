
namespace REST_CLIENT
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.FelhasznaloLabel = new System.Windows.Forms.Label();
            this.JelszoLabel = new System.Windows.Forms.Label();
            this.usernameTxtBox = new System.Windows.Forms.TextBox();
            this.passwordTxtBox = new System.Windows.Forms.TextBox();
            this.registerBtn = new System.Windows.Forms.Button();
            this.loginBtn = new System.Windows.Forms.Button();
            this.listaBtn = new System.Windows.Forms.Button();
            this.idListaBtn = new System.Windows.Forms.Button();
            this.IdNumeric = new System.Windows.Forms.NumericUpDown();
            this.listView = new System.Windows.Forms.ListView();
            this.exitBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.IdNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // FelhasznaloLabel
            // 
            this.FelhasznaloLabel.AutoSize = true;
            this.FelhasznaloLabel.Location = new System.Drawing.Point(12, 88);
            this.FelhasznaloLabel.Name = "FelhasznaloLabel";
            this.FelhasznaloLabel.Size = new System.Drawing.Size(87, 15);
            this.FelhasznaloLabel.TabIndex = 0;
            this.FelhasznaloLabel.Text = "Felhasználónév";
            // 
            // JelszoLabel
            // 
            this.JelszoLabel.AutoSize = true;
            this.JelszoLabel.Location = new System.Drawing.Point(62, 138);
            this.JelszoLabel.Name = "JelszoLabel";
            this.JelszoLabel.Size = new System.Drawing.Size(37, 15);
            this.JelszoLabel.TabIndex = 1;
            this.JelszoLabel.Text = "Jelszó";
            // 
            // usernameTxtBox
            // 
            this.usernameTxtBox.Location = new System.Drawing.Point(135, 85);
            this.usernameTxtBox.Name = "usernameTxtBox";
            this.usernameTxtBox.Size = new System.Drawing.Size(100, 23);
            this.usernameTxtBox.TabIndex = 2;
            // 
            // passwordTxtBox
            // 
            this.passwordTxtBox.Location = new System.Drawing.Point(135, 135);
            this.passwordTxtBox.Name = "passwordTxtBox";
            this.passwordTxtBox.Size = new System.Drawing.Size(100, 23);
            this.passwordTxtBox.TabIndex = 3;
            // 
            // registerBtn
            // 
            this.registerBtn.Location = new System.Drawing.Point(22, 222);
            this.registerBtn.Name = "registerBtn";
            this.registerBtn.Size = new System.Drawing.Size(89, 32);
            this.registerBtn.TabIndex = 5;
            this.registerBtn.Text = "Regisztráció";
            this.registerBtn.UseVisualStyleBackColor = true;
            this.registerBtn.Click += new System.EventHandler(this.registerBtn_Click);
            // 
            // loginBtn
            // 
            this.loginBtn.Location = new System.Drawing.Point(187, 222);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(91, 32);
            this.loginBtn.TabIndex = 6;
            this.loginBtn.Text = "Bejelentkezés";
            this.loginBtn.UseVisualStyleBackColor = true;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // listaBtn
            // 
            this.listaBtn.Location = new System.Drawing.Point(389, 333);
            this.listaBtn.Name = "listaBtn";
            this.listaBtn.Size = new System.Drawing.Size(100, 40);
            this.listaBtn.TabIndex = 7;
            this.listaBtn.Text = "Listázás";
            this.listaBtn.UseVisualStyleBackColor = true;
            this.listaBtn.Click += new System.EventHandler(this.listaBtn_Click);
            // 
            // idListaBtn
            // 
            this.idListaBtn.Location = new System.Drawing.Point(543, 333);
            this.idListaBtn.Name = "idListaBtn";
            this.idListaBtn.Size = new System.Drawing.Size(100, 40);
            this.idListaBtn.TabIndex = 8;
            this.idListaBtn.Text = "Lekérés ID-vel";
            this.idListaBtn.UseVisualStyleBackColor = true;
            this.idListaBtn.Click += new System.EventHandler(this.idListaBtn_Click);
            // 
            // IdNumeric
            // 
            this.IdNumeric.Location = new System.Drawing.Point(649, 344);
            this.IdNumeric.Name = "IdNumeric";
            this.IdNumeric.Size = new System.Drawing.Size(100, 23);
            this.IdNumeric.TabIndex = 9;
            // 
            // listView
            // 
            this.listView.HideSelection = false;
            this.listView.Location = new System.Drawing.Point(302, 12);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(450, 300);
            this.listView.TabIndex = 10;
            this.listView.UseCompatibleStateImageBehavior = false;
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(12, 376);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(75, 23);
            this.exitBtn.TabIndex = 11;
            this.exitBtn.Text = "Kilépés";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 411);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.IdNumeric);
            this.Controls.Add(this.idListaBtn);
            this.Controls.Add(this.listaBtn);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.registerBtn);
            this.Controls.Add(this.passwordTxtBox);
            this.Controls.Add(this.usernameTxtBox);
            this.Controls.Add(this.JelszoLabel);
            this.Controls.Add(this.FelhasznaloLabel);
            this.Name = "Form1";
            this.Text = "Guest window";
            ((System.ComponentModel.ISupportInitialize)(this.IdNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FelhasznaloLabel;
        private System.Windows.Forms.Label JelszoLabel;
        private System.Windows.Forms.TextBox usernameTxtBox;
        private System.Windows.Forms.TextBox passwordTxtBox;
        private System.Windows.Forms.Button registerBtn;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.Button listaBtn;
        private System.Windows.Forms.Button idListaBtn;
        private System.Windows.Forms.NumericUpDown IdNumeric;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.Button exitBtn;
    }
}

