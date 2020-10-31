namespace PasswordManager
{
    partial class Main
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
            this.ListBox_Passwords = new System.Windows.Forms.ListView();
            this.cH_Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cH_Password = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_SelectFile = new System.Windows.Forms.Button();
            this.btn_CreatFile = new System.Windows.Forms.Button();
            this.btn_addPassword = new System.Windows.Forms.Button();
            this.btn_Encrypt = new System.Windows.Forms.Button();
            this.btn_removePass = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ListBox_Passwords
            // 
            this.ListBox_Passwords.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ListBox_Passwords.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cH_Name,
            this.cH_Password});
            this.ListBox_Passwords.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListBox_Passwords.HideSelection = false;
            this.ListBox_Passwords.Location = new System.Drawing.Point(0, 1);
            this.ListBox_Passwords.Name = "ListBox_Passwords";
            this.ListBox_Passwords.Size = new System.Drawing.Size(360, 342);
            this.ListBox_Passwords.TabIndex = 0;
            this.ListBox_Passwords.UseCompatibleStateImageBehavior = false;
            this.ListBox_Passwords.View = System.Windows.Forms.View.Details;
            // 
            // cH_Name
            // 
            this.cH_Name.Text = "Name";
            this.cH_Name.Width = 163;
            // 
            // cH_Password
            // 
            this.cH_Password.Text = "Password";
            this.cH_Password.Width = 175;
            // 
            // btn_SelectFile
            // 
            this.btn_SelectFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_SelectFile.Location = new System.Drawing.Point(12, 349);
            this.btn_SelectFile.Name = "btn_SelectFile";
            this.btn_SelectFile.Size = new System.Drawing.Size(85, 23);
            this.btn_SelectFile.TabIndex = 1;
            this.btn_SelectFile.Text = "Select File";
            this.btn_SelectFile.UseVisualStyleBackColor = true;
            this.btn_SelectFile.Click += new System.EventHandler(this.btn_SelectFile_Click);
            // 
            // btn_CreatFile
            // 
            this.btn_CreatFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_CreatFile.Location = new System.Drawing.Point(12, 378);
            this.btn_CreatFile.Name = "btn_CreatFile";
            this.btn_CreatFile.Size = new System.Drawing.Size(85, 23);
            this.btn_CreatFile.TabIndex = 2;
            this.btn_CreatFile.Text = "Create File";
            this.btn_CreatFile.UseVisualStyleBackColor = true;
            this.btn_CreatFile.Click += new System.EventHandler(this.btn_CreatFile_Click);
            // 
            // btn_addPassword
            // 
            this.btn_addPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_addPassword.Location = new System.Drawing.Point(103, 349);
            this.btn_addPassword.Name = "btn_addPassword";
            this.btn_addPassword.Size = new System.Drawing.Size(85, 23);
            this.btn_addPassword.TabIndex = 3;
            this.btn_addPassword.Text = "Add Password";
            this.btn_addPassword.UseVisualStyleBackColor = true;
            this.btn_addPassword.Click += new System.EventHandler(this.btn_addPassword_Click);
            // 
            // btn_Encrypt
            // 
            this.btn_Encrypt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_Encrypt.Location = new System.Drawing.Point(103, 378);
            this.btn_Encrypt.Name = "btn_Encrypt";
            this.btn_Encrypt.Size = new System.Drawing.Size(85, 23);
            this.btn_Encrypt.TabIndex = 4;
            this.btn_Encrypt.Text = "Encrypt";
            this.btn_Encrypt.UseVisualStyleBackColor = true;
            this.btn_Encrypt.Click += new System.EventHandler(this.btn_Encrypt_Click);
            // 
            // btn_removePass
            // 
            this.btn_removePass.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_removePass.Location = new System.Drawing.Point(194, 378);
            this.btn_removePass.Name = "btn_removePass";
            this.btn_removePass.Size = new System.Drawing.Size(85, 23);
            this.btn_removePass.TabIndex = 5;
            this.btn_removePass.Text = "Remove Pass";
            this.btn_removePass.UseVisualStyleBackColor = true;
            this.btn_removePass.Click += new System.EventHandler(this.btn_removePass_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 407);
            this.Controls.Add(this.btn_removePass);
            this.Controls.Add(this.btn_Encrypt);
            this.Controls.Add(this.btn_addPassword);
            this.Controls.Add(this.btn_CreatFile);
            this.Controls.Add(this.btn_SelectFile);
            this.Controls.Add(this.ListBox_Passwords);
            this.Name = "Main";
            this.Text = "Password Manager";
            this.Activated += new System.EventHandler(this.Main_Activated);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_SelectFile;
        private System.Windows.Forms.Button btn_CreatFile;
        private System.Windows.Forms.Button btn_addPassword;
        private System.Windows.Forms.Button btn_Encrypt;
        private System.Windows.Forms.ColumnHeader cH_Name;
        private System.Windows.Forms.ColumnHeader cH_Password;
        private System.Windows.Forms.ListView ListBox_Passwords;
        private System.Windows.Forms.Button btn_removePass;
    }
}

