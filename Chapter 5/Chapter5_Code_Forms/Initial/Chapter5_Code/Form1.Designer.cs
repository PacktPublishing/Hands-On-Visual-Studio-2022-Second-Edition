namespace Chapter5_Code
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
            btnLoad = new Button();
            lstCustomers = new CheckedListBox();
            btnRemove = new Button();
            SuspendLayout();
            // 
            // btnLoad
            // 
            btnLoad.BackColor = Color.FromArgb(224, 247, 213);
            btnLoad.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnLoad.Location = new Point(12, 12);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(349, 54);
            btnLoad.TabIndex = 0;
            btnLoad.Text = "Load Customers";
            btnLoad.UseVisualStyleBackColor = false;
            btnLoad.Click += btnLoad_Click;
            // 
            // lstCustomers
            // 
            lstCustomers.FormattingEnabled = true;
            lstCustomers.Location = new Point(12, 72);
            lstCustomers.Name = "lstCustomers";
            lstCustomers.Size = new Size(349, 238);
            lstCustomers.TabIndex = 1;
            // 
            // btnRemove
            // 
            btnRemove.BackColor = Color.Maroon;
            btnRemove.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnRemove.ForeColor = SystemColors.ButtonHighlight;
            btnRemove.Location = new Point(12, 327);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(349, 54);
            btnRemove.TabIndex = 2;
            btnRemove.Text = "Remove Selected Customers";
            btnRemove.UseVisualStyleBackColor = false;
            btnRemove.Click += btnRemove_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(45, 4, 111);
            ClientSize = new Size(373, 393);
            Controls.Add(btnRemove);
            Controls.Add(lstCustomers);
            Controls.Add(btnLoad);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnLoad;
        private CheckedListBox lstCustomers;
        private Button btnRemove;
    }
}