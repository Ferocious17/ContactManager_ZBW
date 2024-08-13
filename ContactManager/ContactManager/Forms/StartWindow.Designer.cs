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
            tableLayoutPanel2 = new TableLayoutPanel();
            button1 = new Button();
            button2 = new Button();
            tableLayoutPanel3 = new TableLayoutPanel();
            button3 = new Button();
            button4 = new Button();
            tableLayoutPanel4 = new TableLayoutPanel();
            btnExportAll = new Button();
            btnImportAll = new Button();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            SuspendLayout();
            // 
            // btnSearch
            // 
            btnSearch.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnSearch.Location = new Point(377, 26);
            btnSearch.Margin = new Padding(1, 1, 1, 1);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(187, 41);
            btnSearch.TabIndex = 1;
            btnSearch.Text = "Suche";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnClientRegistration
            // 
            btnClientRegistration.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnClientRegistration.Location = new Point(189, 26);
            btnClientRegistration.Margin = new Padding(1, 1, 1, 1);
            btnClientRegistration.Name = "btnClientRegistration";
            btnClientRegistration.Size = new Size(186, 41);
            btnClientRegistration.TabIndex = 2;
            btnClientRegistration.Text = "Kunden Erfassung";
            btnClientRegistration.UseVisualStyleBackColor = true;
            btnClientRegistration.Click += btnClientRegistration_Click;
            // 
            // txtBoxTitel
            // 
            txtBoxTitel.Font = new Font("Segoe UI", 15F);
            txtBoxTitel.Location = new Point(34, 32);
            txtBoxTitel.Margin = new Padding(1, 1, 1, 1);
            txtBoxTitel.Name = "txtBoxTitel";
            txtBoxTitel.Size = new Size(234, 34);
            txtBoxTitel.TabIndex = 0;
            txtBoxTitel.TabStop = false;
            txtBoxTitel.Text = "CONTACT MANAGER";
            txtBoxTitel.TextChanged += txtBoxTitel_TextChanged;
            // 
            // btnUserRegistration
            // 
            btnUserRegistration.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnUserRegistration.Location = new Point(1, 26);
            btnUserRegistration.Margin = new Padding(1, 1, 1, 1);
            btnUserRegistration.Name = "btnUserRegistration";
            btnUserRegistration.Size = new Size(186, 41);
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
            tableLayoutPanel1.Location = new Point(34, 90);
            tableLayoutPanel1.Margin = new Padding(2, 2, 2, 2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 94F));
            tableLayoutPanel1.Size = new Size(565, 94);
            tableLayoutPanel1.TabIndex = 4;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.Controls.Add(button1, 0, 0);
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(200, 100);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            button1.Location = new Point(2, 2);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(62, 96);
            button1.TabIndex = 0;
            button1.Text = "Mitarbeiter Erfassung";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            button2.Location = new Point(68, 2);
            button2.Margin = new Padding(2);
            button2.Name = "button2";
            button2.Size = new Size(62, 113);
            button2.TabIndex = 2;
            button2.Text = "Kunden Erfassung";
            button2.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel3.ColumnCount = 3;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel3.Controls.Add(button3, 0, 0);
            tableLayoutPanel3.Location = new Point(0, 0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Size = new Size(200, 100);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            button3.Location = new Point(2, 2);
            button3.Margin = new Padding(2);
            button3.Name = "button3";
            button3.Size = new Size(62, 96);
            button3.TabIndex = 0;
            button3.Text = "Mitarbeiter Erfassung";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            button4.Location = new Point(68, 2);
            button4.Margin = new Padding(2);
            button4.Name = "button4";
            button4.Size = new Size(62, 113);
            button4.TabIndex = 2;
            button4.Text = "Kunden Erfassung";
            button4.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Controls.Add(btnExportAll, 1, 0);
            tableLayoutPanel4.Controls.Add(btnImportAll, 0, 0);
            tableLayoutPanel4.Location = new Point(335, 24);
            tableLayoutPanel4.Margin = new Padding(1, 1, 1, 1);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Size = new Size(245, 25);
            tableLayoutPanel4.TabIndex = 5;
            // 
            // btnExportAll
            // 
            btnExportAll.Location = new Point(123, 1);
            btnExportAll.Margin = new Padding(1, 1, 1, 1);
            btnExportAll.Name = "btnExportAll";
            btnExportAll.Size = new Size(120, 23);
            btnExportAll.TabIndex = 7;
            btnExportAll.Text = "Exportieren";
            btnExportAll.UseVisualStyleBackColor = true;
            // 
            // btnImportAll
            // 
            btnImportAll.Location = new Point(1, 1);
            btnImportAll.Margin = new Padding(1, 1, 1, 1);
            btnImportAll.Name = "btnImportAll";
            btnImportAll.Size = new Size(120, 23);
            btnImportAll.TabIndex = 6;
            btnImportAll.Text = "Importieren";
            btnImportAll.UseVisualStyleBackColor = true;
            // 
            // StartWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CausesValidation = false;
            ClientSize = new Size(635, 241);
            Controls.Add(tableLayoutPanel4);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(txtBoxTitel);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(1, 1, 1, 1);
            MaximizeBox = false;
            Name = "StartWindow";
            Text = "Contact Manager";
            Load += StartWindow_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnSearch;
        private Button btnClientRegistration;
        private TextBox txtBoxTitel;
        private Button btnUserRegistration;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Button button1;
        private Button button2;
        private TableLayoutPanel tableLayoutPanel3;
        private Button button3;
        private Button button4;
        private TableLayoutPanel tableLayoutPanel4;
        private Button btnExportAll;
        private Button btnImportAll;
    }
}
