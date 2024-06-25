namespace ContactManager.Forms
{
    partial class StartWindow
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
            btnUserRegistration = new Button();
            btnSearch = new Button();
            btnClientRegistration = new Button();
            txtBoxTitel = new TextBox();
            SuspendLayout();
            // 
            // btnUserRegistration
            // 
            btnUserRegistration.Location = new Point(52, 120);
            btnUserRegistration.Margin = new Padding(1, 1, 1, 1);
            btnUserRegistration.Name = "btnUserRegistration";
            btnUserRegistration.Size = new Size(161, 55);
            btnUserRegistration.TabIndex = 0;
            btnUserRegistration.Text = "Mitarbeiter Erfassung";
            btnUserRegistration.UseVisualStyleBackColor = true;
            btnUserRegistration.Click += btnUserRegistration_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(385, 121);
            btnSearch.Margin = new Padding(1, 1, 1, 1);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(99, 54);
            btnSearch.TabIndex = 1;
            btnSearch.Text = "Suche";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnClientRegistration
            // 
            btnClientRegistration.Location = new Point(235, 120);
            btnClientRegistration.Margin = new Padding(1, 1, 1, 1);
            btnClientRegistration.Name = "btnClientRegistration";
            btnClientRegistration.Size = new Size(124, 55);
            btnClientRegistration.TabIndex = 2;
            btnClientRegistration.Text = "Kuden Erfassung";
            btnClientRegistration.UseVisualStyleBackColor = true;
            btnClientRegistration.Click += btnClientRegistration_Click;
            // 
            // txtBoxTitel
            // 
            txtBoxTitel.Font = new Font("Segoe UI", 15F);
            txtBoxTitel.Location = new Point(58, 34);
            txtBoxTitel.Margin = new Padding(1, 1, 1, 1);
            txtBoxTitel.Multiline = true;
            txtBoxTitel.Name = "txtBoxTitel";
            txtBoxTitel.Size = new Size(253, 41);
            txtBoxTitel.TabIndex = 3;
            txtBoxTitel.Text = "CONTACT MANAGER";
            txtBoxTitel.TextChanged += txtBoxTitel_TextChanged;
            // 
            // StartWindow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(601, 253);
            Controls.Add(txtBoxTitel);
            Controls.Add(btnClientRegistration);
            Controls.Add(btnSearch);
            Controls.Add(btnUserRegistration);
            Margin = new Padding(1, 1, 1, 1);
            Name = "StartWindow";
            Text = "Contact Manager";
            Load += StartWindow_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnUserRegistration;
        private Button btnSearch;
        private Button btnClientRegistration;
        private TextBox txtBoxTitel;
    }
}
