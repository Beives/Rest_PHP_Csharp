
namespace REST_CLIENT
{
    partial class Módosítás
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
            this.hurokLabel = new System.Windows.Forms.Label();
            this.tipusTxtBox = new System.Windows.Forms.TextBox();
            this.hurokNumeric = new System.Windows.Forms.NumericUpDown();
            this.hangszedoTxtBox = new System.Windows.Forms.TextBox();
            this.bundokNumeric = new System.Windows.Forms.NumericUpDown();
            this.markaTxtBox = new System.Windows.Forms.TextBox();
            this.formaTxtBox = new System.Windows.Forms.TextBox();
            this.tipusLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.bundokLabel = new System.Windows.Forms.Label();
            this.formaLabel = new System.Windows.Forms.Label();
            this.markaLabel = new System.Windows.Forms.Label();
            this.modositBtn = new System.Windows.Forms.Button();
            this.megsemBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.hurokNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bundokNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // hurokLabel
            // 
            this.hurokLabel.AutoSize = true;
            this.hurokLabel.Location = new System.Drawing.Point(21, 164);
            this.hurokLabel.Name = "hurokLabel";
            this.hurokLabel.Size = new System.Drawing.Size(76, 15);
            this.hurokLabel.TabIndex = 37;
            this.hurokLabel.Text = "Húrok száma";
            // 
            // tipusTxtBox
            // 
            this.tipusTxtBox.Location = new System.Drawing.Point(102, 198);
            this.tipusTxtBox.Name = "tipusTxtBox";
            this.tipusTxtBox.Size = new System.Drawing.Size(100, 23);
            this.tipusTxtBox.TabIndex = 36;
            // 
            // hurokNumeric
            // 
            this.hurokNumeric.Location = new System.Drawing.Point(103, 162);
            this.hurokNumeric.Name = "hurokNumeric";
            this.hurokNumeric.Size = new System.Drawing.Size(100, 23);
            this.hurokNumeric.TabIndex = 35;
            // 
            // hangszedoTxtBox
            // 
            this.hangszedoTxtBox.Location = new System.Drawing.Point(104, 127);
            this.hangszedoTxtBox.Name = "hangszedoTxtBox";
            this.hangszedoTxtBox.Size = new System.Drawing.Size(100, 23);
            this.hangszedoTxtBox.TabIndex = 34;
            // 
            // bundokNumeric
            // 
            this.bundokNumeric.Location = new System.Drawing.Point(103, 90);
            this.bundokNumeric.Name = "bundokNumeric";
            this.bundokNumeric.Size = new System.Drawing.Size(100, 23);
            this.bundokNumeric.TabIndex = 33;
            // 
            // markaTxtBox
            // 
            this.markaTxtBox.Location = new System.Drawing.Point(103, 12);
            this.markaTxtBox.Name = "markaTxtBox";
            this.markaTxtBox.Size = new System.Drawing.Size(100, 23);
            this.markaTxtBox.TabIndex = 32;
            // 
            // formaTxtBox
            // 
            this.formaTxtBox.Location = new System.Drawing.Point(103, 52);
            this.formaTxtBox.Name = "formaTxtBox";
            this.formaTxtBox.Size = new System.Drawing.Size(100, 23);
            this.formaTxtBox.TabIndex = 31;
            // 
            // tipusLabel
            // 
            this.tipusLabel.AutoSize = true;
            this.tipusLabel.Location = new System.Drawing.Point(61, 201);
            this.tipusLabel.Name = "tipusLabel";
            this.tipusLabel.Size = new System.Drawing.Size(35, 15);
            this.tipusLabel.TabIndex = 30;
            this.tipusLabel.Text = "Típus";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 15);
            this.label5.TabIndex = 29;
            this.label5.Text = "Hangszedők";
            // 
            // bundokLabel
            // 
            this.bundokLabel.AutoSize = true;
            this.bundokLabel.Location = new System.Drawing.Point(13, 92);
            this.bundokLabel.Name = "bundokLabel";
            this.bundokLabel.Size = new System.Drawing.Size(84, 15);
            this.bundokLabel.TabIndex = 28;
            this.bundokLabel.Text = "Bundok száma";
            // 
            // formaLabel
            // 
            this.formaLabel.AutoSize = true;
            this.formaLabel.Location = new System.Drawing.Point(56, 55);
            this.formaLabel.Name = "formaLabel";
            this.formaLabel.Size = new System.Drawing.Size(41, 15);
            this.formaLabel.TabIndex = 27;
            this.formaLabel.Text = "Forma";
            // 
            // markaLabel
            // 
            this.markaLabel.AutoSize = true;
            this.markaLabel.Location = new System.Drawing.Point(57, 15);
            this.markaLabel.Name = "markaLabel";
            this.markaLabel.Size = new System.Drawing.Size(40, 15);
            this.markaLabel.TabIndex = 26;
            this.markaLabel.Text = "Márka";
            // 
            // modositBtn
            // 
            this.modositBtn.Location = new System.Drawing.Point(27, 253);
            this.modositBtn.Name = "modositBtn";
            this.modositBtn.Size = new System.Drawing.Size(75, 23);
            this.modositBtn.TabIndex = 38;
            this.modositBtn.Text = "Módosítás";
            this.modositBtn.UseVisualStyleBackColor = true;
            this.modositBtn.Click += new System.EventHandler(this.modositBtn_Click);
            // 
            // megsemBtn
            // 
            this.megsemBtn.Location = new System.Drawing.Point(143, 253);
            this.megsemBtn.Name = "megsemBtn";
            this.megsemBtn.Size = new System.Drawing.Size(75, 23);
            this.megsemBtn.TabIndex = 39;
            this.megsemBtn.Text = "Mégsem";
            this.megsemBtn.UseVisualStyleBackColor = true;
            this.megsemBtn.Click += new System.EventHandler(this.megsemBtn_Click);
            // 
            // Módosítás
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(246, 289);
            this.Controls.Add(this.megsemBtn);
            this.Controls.Add(this.modositBtn);
            this.Controls.Add(this.hurokLabel);
            this.Controls.Add(this.tipusTxtBox);
            this.Controls.Add(this.hurokNumeric);
            this.Controls.Add(this.hangszedoTxtBox);
            this.Controls.Add(this.bundokNumeric);
            this.Controls.Add(this.markaTxtBox);
            this.Controls.Add(this.formaTxtBox);
            this.Controls.Add(this.tipusLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.bundokLabel);
            this.Controls.Add(this.formaLabel);
            this.Controls.Add(this.markaLabel);
            this.Name = "Módosítás";
            this.Text = "modositoForm";
            ((System.ComponentModel.ISupportInitialize)(this.hurokNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bundokNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label hurokLabel;
        private System.Windows.Forms.TextBox tipusTxtBox;
        private System.Windows.Forms.NumericUpDown hurokNumeric;
        private System.Windows.Forms.TextBox hangszedoTxtBox;
        private System.Windows.Forms.NumericUpDown bundokNumeric;
        private System.Windows.Forms.TextBox markaTxtBox;
        private System.Windows.Forms.TextBox formaTxtBox;
        private System.Windows.Forms.Label tipusLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label bundokLabel;
        private System.Windows.Forms.Label formaLabel;
        private System.Windows.Forms.Label markaLabel;
        private System.Windows.Forms.Button modositBtn;
        private System.Windows.Forms.Button megsemBtn;
    }
}