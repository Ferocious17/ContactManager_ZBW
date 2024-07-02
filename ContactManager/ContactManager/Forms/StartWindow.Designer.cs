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
            btnSearch = new Button();
            btnClientRegistration = new Button();
            txtBoxTitel = new TextBox();
            btnUserRegistration = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnSearch
            // 
            btnSearch.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnSearch.Location = new Point(431, 36);
            btnSearch.Margin = new Padding(1);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(213, 54);
            btnSearch.TabIndex = 1;
            btnSearch.Text = "Suche";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnClientRegistration
            // 
            btnClientRegistration.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnClientRegistration.Location = new Point(216, 35);
            btnClientRegistration.Margin = new Padding(1);
            btnClientRegistration.Name = "btnClientRegistration";
            btnClientRegistration.Size = new Size(213, 55);
            btnClientRegistration.TabIndex = 2;
            btnClientRegistration.Text = "Kunden Erfassung";
            btnClientRegistration.UseVisualStyleBackColor = true;
            btnClientRegistration.Click += btnClientRegistration_Click;
            // 
            // txtBoxTitel
            // 
            txtBoxTitel.Font = new Font("Segoe UI", 15F);
            txtBoxTitel.Location = new Point(39, 43);
            txtBoxTitel.Margin = new Padding(1);
            txtBoxTitel.Name = "txtBoxTitel";
            txtBoxTitel.Size = new Size(267, 41);
            txtBoxTitel.TabIndex = 0;
            txtBoxTitel.TabStop = false;
            txtBoxTitel.Text = "CONTACT MANAGER";
            txtBoxTitel.TextChanged += txtBoxTitel_TextChanged;
            // 
            // btnUserRegistration
            // 
            btnUserRegistration.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnUserRegistration.Location = new Point(1, 35);
            btnUserRegistration.Margin = new Padding(1);
            btnUserRegistration.Name = "btnUserRegistration";
            btnUserRegistration.Size = new Size(213, 55);
            btnUserRegistration.TabIndex = 0;
            btnUserRegistration.Text = "Mitarbeiter Erfassung";
            btnUserRegistration.UseVisualStyleBackColor = true;
            btnUserRegistration.Click += btnUserRegistration_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Controls.Add(btnUserRegistration, 0, 0);
            tableLayoutPanel1.Controls.Add(btnClientRegistration, 1, 0);
            tableLayoutPanel1.Controls.Add(btnSearch, 2, 0);
            tableLayoutPanel1.Location = new Point(39, 120);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(645, 126);
            tableLayoutPanel1.TabIndex = 4;
            // 
            // StartWindow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CausesValidation = false;
            ClientSize = new Size(726, 322);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(txtBoxTitel);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(1);
            MaximizeBox = false;
            Name = "StartWindow";
            Text = "Contact Manager";
            Load += StartWindow_Load;
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnSearch;
        private Button btnClientRegistration;
        private TextBox txtBoxTitel;
        private Button btnUserRegistration;
        private TableLayoutPanel tableLayoutPanel1;
    }
}
