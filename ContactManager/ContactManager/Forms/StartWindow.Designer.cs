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
            LblStartSearch = new Button();
            LblStartCostumerRegistration = new Button();
            LblStartTitle = new TextBox();
            LblStartEmployeeRegistration = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            button1 = new Button();
            button2 = new Button();
            tableLayoutPanel3 = new TableLayoutPanel();
            button3 = new Button();
            button4 = new Button();
            tableLayoutPanel4 = new TableLayoutPanel();
            CmdStartExport = new Button();
            CmdStartImport = new Button();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            SuspendLayout();
            // 
            // LblStartSearch
            // 
            LblStartSearch.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            LblStartSearch.Location = new Point(431, 35);
            LblStartSearch.Margin = new Padding(1);
            LblStartSearch.Name = "LblStartSearch";
            LblStartSearch.Size = new Size(214, 55);
            LblStartSearch.TabIndex = 1;
            LblStartSearch.Text = "Suche";
            LblStartSearch.UseVisualStyleBackColor = true;
            LblStartSearch.Click += btnSearch_Click;
            // 
            // LblStartCostumerRegistration
            // 
            LblStartCostumerRegistration.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            LblStartCostumerRegistration.Location = new Point(216, 35);
            LblStartCostumerRegistration.Margin = new Padding(1);
            LblStartCostumerRegistration.Name = "LblStartCostumerRegistration";
            LblStartCostumerRegistration.Size = new Size(213, 55);
            LblStartCostumerRegistration.TabIndex = 2;
            LblStartCostumerRegistration.Text = "Kunden Erfassung";
            LblStartCostumerRegistration.UseVisualStyleBackColor = true;
            LblStartCostumerRegistration.Click += btnClientRegistration_Click;
            // 
            // LblStartTitle
            // 
            LblStartTitle.Font = new Font("Segoe UI", 15F);
            LblStartTitle.Location = new Point(39, 43);
            LblStartTitle.Margin = new Padding(1);
            LblStartTitle.Name = "LblStartTitle";
            LblStartTitle.Size = new Size(267, 41);
            LblStartTitle.TabIndex = 0;
            LblStartTitle.TabStop = false;
            LblStartTitle.Text = "CONTACT MANAGER";
            LblStartTitle.TextChanged += txtBoxTitel_TextChanged;
            // 
            // LblStartEmployeeRegistration
            // 
            LblStartEmployeeRegistration.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            LblStartEmployeeRegistration.Location = new Point(1, 35);
            LblStartEmployeeRegistration.Margin = new Padding(1);
            LblStartEmployeeRegistration.Name = "LblStartEmployeeRegistration";
            LblStartEmployeeRegistration.Size = new Size(213, 55);
            LblStartEmployeeRegistration.TabIndex = 0;
            LblStartEmployeeRegistration.Text = "Mitarbeiter Erfassung";
            LblStartEmployeeRegistration.UseVisualStyleBackColor = true;
            LblStartEmployeeRegistration.Click += btnUserRegistration_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Controls.Add(LblStartEmployeeRegistration, 0, 0);
            tableLayoutPanel1.Controls.Add(LblStartCostumerRegistration, 1, 0);
            tableLayoutPanel1.Controls.Add(LblStartSearch, 2, 0);
            tableLayoutPanel1.Location = new Point(39, 120);
            tableLayoutPanel1.Margin = new Padding(2, 3, 2, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 125F));
            tableLayoutPanel1.Size = new Size(646, 125);
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
            tableLayoutPanel4.Controls.Add(CmdStartExport, 1, 0);
            tableLayoutPanel4.Controls.Add(CmdStartImport, 0, 0);
            tableLayoutPanel4.Location = new Point(383, 32);
            tableLayoutPanel4.Margin = new Padding(1);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Size = new Size(280, 33);
            tableLayoutPanel4.TabIndex = 5;
            // 
            // CmdStartExport
            // 
            CmdStartExport.Location = new Point(141, 1);
            CmdStartExport.Margin = new Padding(1);
            CmdStartExport.Name = "CmdStartExport";
            CmdStartExport.Size = new Size(137, 31);
            CmdStartExport.TabIndex = 7;
            CmdStartExport.Text = "Exportieren";
            CmdStartExport.UseVisualStyleBackColor = true;
            CmdStartExport.Click += CmdStartExport_Click;
            // 
            // CmdStartImport
            // 
            CmdStartImport.Location = new Point(1, 1);
            CmdStartImport.Margin = new Padding(1);
            CmdStartImport.Name = "CmdStartImport";
            CmdStartImport.Size = new Size(137, 31);
            CmdStartImport.TabIndex = 6;
            CmdStartImport.Text = "Importieren";
            CmdStartImport.UseVisualStyleBackColor = true;
            CmdStartImport.Click += CmdStartImport_Click;
            // 
            // StartWindow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CausesValidation = false;
            ClientSize = new Size(726, 321);
            Controls.Add(tableLayoutPanel4);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(LblStartTitle);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(1);
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
        private Button LblStartSearch;
        private Button LblStartCostumerRegistration;
        private TextBox LblStartTitle;
        private Button LblStartEmployeeRegistration;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Button button1;
        private Button button2;
        private TableLayoutPanel tableLayoutPanel3;
        private Button button3;
        private Button button4;
        private TableLayoutPanel tableLayoutPanel4;
        private Button CmdStartExport;
        private Button CmdStartImport;
    }
}
