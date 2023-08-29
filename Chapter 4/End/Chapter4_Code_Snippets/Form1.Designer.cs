namespace Chapter4_Code_Snippets
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
            txtPassword = new TextBox();
            btnGeneratePassword = new Button();
            lstPasswords = new ListBox();
            btnCopy = new Button();
            label1 = new Label();
            chkIncludeSpecialCharacters = new CheckBox();
            SuspendLayout();
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtPassword.Location = new Point(22, 28);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(171, 33);
            txtPassword.TabIndex = 0;
            txtPassword.Text = "123456789";
            txtPassword.TextAlign = HorizontalAlignment.Center;
            // 
            // btnGeneratePassword
            // 
            btnGeneratePassword.BackColor = Color.FromArgb(19, 24, 70);
            btnGeneratePassword.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnGeneratePassword.ForeColor = Color.White;
            btnGeneratePassword.Location = new Point(22, 82);
            btnGeneratePassword.Name = "btnGeneratePassword";
            btnGeneratePassword.Size = new Size(209, 76);
            btnGeneratePassword.TabIndex = 1;
            btnGeneratePassword.Text = "Generate Password";
            btnGeneratePassword.UseVisualStyleBackColor = false;
            btnGeneratePassword.Click += btnGeneratePassword_Click;
            // 
            // lstPasswords
            // 
            lstPasswords.FormattingEnabled = true;
            lstPasswords.ItemHeight = 15;
            lstPasswords.Location = new Point(22, 249);
            lstPasswords.Name = "lstPasswords";
            lstPasswords.Size = new Size(260, 244);
            lstPasswords.TabIndex = 2;
            // 
            // btnCopy
            // 
            btnCopy.BackColor = Color.FromArgb(26, 178, 88);
            btnCopy.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnCopy.ForeColor = Color.White;
            btnCopy.Location = new Point(200, 28);
            btnCopy.Name = "btnCopy";
            btnCopy.Size = new Size(88, 33);
            btnCopy.TabIndex = 3;
            btnCopy.Text = "Copy";
            btnCopy.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(22, 212);
            label1.Name = "label1";
            label1.Size = new Size(162, 21);
            label1.TabIndex = 4;
            label1.Text = "Generated Passwords:";
            // 
            // chkIncludeSpecialCharacters
            // 
            chkIncludeSpecialCharacters.AutoSize = true;
            chkIncludeSpecialCharacters.ForeColor = Color.White;
            chkIncludeSpecialCharacters.Location = new Point(22, 164);
            chkIncludeSpecialCharacters.Name = "chkIncludeSpecialCharacters";
            chkIncludeSpecialCharacters.Size = new Size(164, 19);
            chkIncludeSpecialCharacters.TabIndex = 5;
            chkIncludeSpecialCharacters.Text = "Include Special Characters";
            chkIncludeSpecialCharacters.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(1, 4, 26);
            ClientSize = new Size(300, 505);
            Controls.Add(chkIncludeSpecialCharacters);
            Controls.Add(label1);
            Controls.Add(btnCopy);
            Controls.Add(lstPasswords);
            Controls.Add(btnGeneratePassword);
            Controls.Add(txtPassword);
            Name = "Form1";
            Text = "Password Generator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPassword;
        private Button btnGeneratePassword;
        private ListBox lstPasswords;
        private Button btnCopy;
        private Label label1;
        private CheckBox chkIncludeSpecialCharacters;
    }
}