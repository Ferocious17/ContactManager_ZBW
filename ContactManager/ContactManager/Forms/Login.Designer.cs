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
            TxtLoginUsername.Location = new Point(35, 127);
            TxtLoginUsername.Margin = new Padding(1);
            TxtLoginUsername.Name = "TxtLoginUsername";
            TxtLoginUsername.Size = new Size(297, 27);
            TxtLoginUsername.TabIndex = 0;
            // 
            // TxtLoginPassword
            // 
            TxtLoginPassword.Location = new Point(35, 186);
            TxtLoginPassword.Margin = new Padding(1);
            TxtLoginPassword.Name = "TxtLoginPassword";
            TxtLoginPassword.Size = new Size(297, 27);
            TxtLoginPassword.TabIndex = 1;
            TxtLoginPassword.UseSystemPasswordChar = true;
            // 
            // LblLoginUsername
            // 
            LblLoginUsername.AutoSize = true;
            LblLoginUsername.Location = new Point(35, 105);
            LblLoginUsername.Margin = new Padding(1, 0, 1, 0);
            LblLoginUsername.Name = "LblLoginUsername";
            LblLoginUsername.Size = new Size(104, 20);
            LblLoginUsername.TabIndex = 2;
            LblLoginUsername.Text = "Benutzername";
            // 
            // LblLoginPassword
            // 
            LblLoginPassword.AutoSize = true;
            LblLoginPassword.Location = new Point(35, 164);
            LblLoginPassword.Margin = new Padding(1, 0, 1, 0);
            LblLoginPassword.Name = "LblLoginPassword";
            LblLoginPassword.Size = new Size(66, 20);
            LblLoginPassword.TabIndex = 3;
            LblLoginPassword.Text = "Passwort";
            // 
            // TxtLoginTitle
            // 
            TxtLoginTitle.Font = new Font("Segoe UI", 15F);
            TxtLoginTitle.Location = new Point(35, 26);
            TxtLoginTitle.Margin = new Padding(1);
            TxtLoginTitle.Multiline = true;
            TxtLoginTitle.Name = "TxtLoginTitle";
            TxtLoginTitle.Size = new Size(166, 45);
            TxtLoginTitle.TabIndex = 43;
            TxtLoginTitle.TabStop = false;
            TxtLoginTitle.Text = "Anmeldung";
            TxtLoginTitle.TextChanged += LblCostumerTitle_TextChanged;
            // 
            // BtnLoginSave
            // 
            BtnLoginSave.Location = new Point(244, 276);
            BtnLoginSave.Margin = new Padding(1);
            BtnLoginSave.Name = "BtnLoginSave";
            BtnLoginSave.Size = new Size(88, 28);
            BtnLoginSave.TabIndex = 44;
            BtnLoginSave.Text = "Weiter";
            BtnLoginSave.UseVisualStyleBackColor = true;
            BtnLoginSave.Click += BtnLoginSave_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(370, 330);
            Controls.Add(BtnLoginSave);
            Controls.Add(TxtLoginTitle);
            Controls.Add(LblLoginPassword);
            Controls.Add(LblLoginUsername);
            Controls.Add(TxtLoginPassword);
            Controls.Add(TxtLoginUsername);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(1);
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