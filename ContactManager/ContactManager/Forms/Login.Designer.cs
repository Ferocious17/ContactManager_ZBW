namespace ContactManager.Forms
{
    partial class Login
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
            TxtLoginUsername = new TextBox();
            TxtLoginPassword = new TextBox();
            LblLoginUsername = new Label();
            LblLoginPassword = new Label();
            TxtLoginTitle = new TextBox();
            BtnLoginSave = new Button();
            SuspendLayout();
            // 
            // TxtLoginUsername
            // 
            TxtLoginUsername.Location = new Point(74, 260);
            TxtLoginUsername.Name = "TxtLoginUsername";
            TxtLoginUsername.Size = new Size(294, 47);
            TxtLoginUsername.TabIndex = 0;
            // 
            // TxtLoginPassword
            // 
            TxtLoginPassword.Location = new Point(74, 381);
            TxtLoginPassword.Name = "TxtLoginPassword";
            TxtLoginPassword.Size = new Size(294, 47);
            TxtLoginPassword.TabIndex = 1;
            TxtLoginPassword.UseSystemPasswordChar = true;
            // 
            // LblLoginUsername
            // 
            LblLoginUsername.AutoSize = true;
            LblLoginUsername.Location = new Point(74, 216);
            LblLoginUsername.Name = "LblLoginUsername";
            LblLoginUsername.Size = new Size(209, 41);
            LblLoginUsername.TabIndex = 2;
            LblLoginUsername.Text = "Benutzername";
            // 
            // LblLoginPassword
            // 
            LblLoginPassword.AutoSize = true;
            LblLoginPassword.Location = new Point(74, 337);
            LblLoginPassword.Name = "LblLoginPassword";
            LblLoginPassword.Size = new Size(135, 41);
            LblLoginPassword.TabIndex = 3;
            LblLoginPassword.Text = "Passwort";
            // 
            // TxtLoginTitle
            // 
            TxtLoginTitle.Font = new Font("Segoe UI", 15F);
            TxtLoginTitle.Location = new Point(74, 54);
            TxtLoginTitle.Margin = new Padding(2, 3, 2, 3);
            TxtLoginTitle.Multiline = true;
            TxtLoginTitle.Name = "TxtLoginTitle";
            TxtLoginTitle.Size = new Size(294, 89);
            TxtLoginTitle.TabIndex = 43;
            TxtLoginTitle.TabStop = false;
            TxtLoginTitle.Text = "Anmeldung";
            TxtLoginTitle.TextChanged += LblCostumerTitle_TextChanged;
            // 
            // BtnLoginSave
            // 
            BtnLoginSave.Location = new Point(712, 690);
            BtnLoginSave.Name = "BtnLoginSave";
            BtnLoginSave.Size = new Size(188, 58);
            BtnLoginSave.TabIndex = 44;
            BtnLoginSave.Text = "Weiter";
            BtnLoginSave.UseVisualStyleBackColor = true;
            BtnLoginSave.Click += BtnLoginSave_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1002, 794);
            Controls.Add(BtnLoginSave);
            Controls.Add(TxtLoginTitle);
            Controls.Add(LblLoginPassword);
            Controls.Add(LblLoginUsername);
            Controls.Add(TxtLoginPassword);
            Controls.Add(TxtLoginUsername);
            Name = "Login";
            Text = "Login";
            Load += Login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TxtLoginUsername;
        private TextBox TxtLoginPassword;
        private Label LblLoginUsername;
        private Label LblLoginPassword;
        private TextBox TxtLoginTitle;
        private Button BtnLoginSave;
    }
}